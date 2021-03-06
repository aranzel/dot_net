﻿using Newtonsoft.Json;
using SpSofty.CodeGeneration.Core.Constants;
using SpSofty.CodeGeneration.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SpSofty.CodeGeneration.Core.Cores
{
    internal class TemplateCore
    {
        public Configuration Configuration { get; }
        public List<Template> Templates { get; private set; }

        private FileCore fileCore;
        private TokenCore tokenCore;
        private CompactorCore compactorCore;

        public TemplateCore(Configuration configuration)
        {
            Configuration = configuration;
            Initialize();
        }

        #region Internal Methods
        internal void ReloadTemplates()
        {
            Templates = fileCore.ReadTemplates().ToList();
        }

        internal void SaveTemplates()
        {
            if (Templates.Any())
            {
                IEnumerable<Template> templateOrder = Templates.OrderBy(t => t.Name).ToList();
                foreach (var template in templateOrder)
                {
                    template.TemplateRules = template.TemplateRules.OrderBy(tr => tr.Name).ToList();
                }

                fileCore.WriteTemplates(templateOrder);
            }
        }

        internal List<KeyValuePair<string, bool>> CreateNewFile(string nameNewFile, Template template)
        {
            List<KeyValuePair<string, bool>> process = new List<KeyValuePair<string, bool>>();
            List<TemplateBuilder> templateBuilders = BuildTemplates(nameNewFile, Configuration.SolutionPath, template.TemplateRules);

            foreach (TemplateBuilder templateBuilder in templateBuilders)
            {
                fileCore.WriteTemplateFile(templateBuilder);
            }

            return process;
        }

        internal bool Exists(string nameTemplate)
        {
            return Templates.Any(t => t.Name.Equals(nameTemplate));
        }

        internal void CreateTemplate(Template template)
        {
            Templates.Add(template);
            SaveTemplates();
        }

        internal void DeleteTemplate(string name)
        {
            Template template = GetTemplate(name);

            if (Directory.Exists(template.PhysicalPath))
            {
                Directory.Delete(template.PhysicalPath, true);
            }
            Templates.Remove(template);

            SaveTemplates();
        }

        internal void Imporetes(string fileImporteTemplates)
        {
            string pathUnzip = Path.Combine(Configuration.PhysicalPathTemplate, $"__temp_unzip_templates_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}");
            if (Directory.Exists(pathUnzip))
            {
                Directory.Delete(pathUnzip, true);
            }
            Directory.CreateDirectory(pathUnzip);

            try
            {
                compactorCore.UnzipPath(fileImporteTemplates, pathUnzip);
                string contetConfiguretaion = fileCore.GetImportFileConfiguration(pathUnzip);
                List<Template> importeTemplates = JsonConvert.DeserializeObject<List<Template>>(contetConfiguretaion);

                var importeFilter = importeTemplates.Where(it => !Templates.Exists(t => t.Name.Equals(it.Name)));
                foreach (Template templateTemplate in importeFilter)
                {
                    string pathRules = Path.Combine(pathUnzip, templateTemplate.Name);
                    string targetPathRules = Path.Combine(Configuration.PhysicalPathTemplate, templateTemplate.Name);

                    Directory.Move(pathRules, targetPathRules);
                }

                Templates.AddRange(importeFilter);
                SaveTemplates();
            }
            finally
            {
                Directory.Delete(pathUnzip, true);
            }
        }

        internal string GetNamespace(string fileName)
        {
            string contentFile = fileCore.ReadFile(fileName);
            
            var regex = new Regex(Basic.REGEX_NAMESTACE);
            var match = regex.Match(contentFile);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return Tokens.TARGET_PROJECT_NAME;
        }

        internal KeyValuePair<string, string> NamespaceToTargetAndProjectNamespace(string namespaceClass, string fullName)
        {
            string resultPath = string.Empty;
            string retultNamespaceProject = string.Empty;
            string[] namespaceClassSplit = namespaceClass.Split('.');
            string currentPath = Path.GetDirectoryName(fullName);

            for (int i = namespaceClassSplit.Length - 1; i >= 0; i--)
            {
                string currentNamePath = Path.GetFileName(currentPath);
                currentPath = Path.GetDirectoryName(currentPath);
                if (!namespaceClassSplit[i].Equals(currentNamePath))
                {
                    retultNamespaceProject = currentNamePath;
                    break;
                }
                resultPath = string.IsNullOrEmpty(resultPath)
                    ? currentNamePath : $"{currentNamePath}\\{resultPath}";
            }

            return new KeyValuePair<string, string>($"{Tokens.TARGET_PROJECT_NAME}\\{resultPath}", retultNamespaceProject);
        }

        internal string PrepareEditFile(string nameClass, string namespaceClass, string fileName)
        {
            string contentFile = fileCore.ReadFile(fileName);

            if (!string.IsNullOrEmpty(contentFile))
            {
                return tokenCore.PrepareEditNewFile(nameClass, namespaceClass, contentFile);
            }

            return contentFile;
        }

        internal Template GetTemplate(string name)
        {
            return Templates.FirstOrDefault(t => t.Name.Equals(name));
        }

        internal string GetFileName(string fileName)
        {
            return Path.GetFileName(fileName);
        }

        internal string PrepareRuleName(string ruleName)
        {
            return $"{Tokens.TARGET_NAME}{Path.GetExtension(ruleName)}";
        }

        internal string CreateFileRulePath(string templateName, string fullName)
        {
            Template template = GetTemplate(templateName);

            if (template != null)
            {
                return Path.Combine(template.Name, GetFileName(fullName));
            }

            throw new KeyNotFoundException($"The Template with name '{templateName}' was not found.");
        }

        internal void CreateRule(string templateName, TemplateRule templateRule, string contentFile)
        {
            fileCore.CreteRule(templateRule, contentFile);
            
            Template template = GetTemplate(templateName);
            template.TemplateRules.Add(templateRule);
            
            SaveTemplates();
        }

        internal void EditRule(string templateName, TemplateRule templateRule, string contentFile)
        {
            fileCore.EditRule(templateRule, contentFile);

            Template template = GetTemplate(templateName);
            TemplateRule templateRuleOld = template.TemplateRules.First(tr => tr.Name.Equals(templateRule.Name));
            template.TemplateRules.Remove(templateRuleOld);
            template.TemplateRules.Add(templateRule);

            SaveTemplates();
        }

        internal void DeleteRule(string templateName, string ruleName)
        {
            Template template = GetTemplate(templateName);
            TemplateRule templateRule = template.TemplateRules.First(tr => tr.File.Equals(ruleName));

            fileCore.DeleteRule(templateRule);
            template.TemplateRules.Remove(templateRule);
        }

        internal string GetEditFile(TemplateRule templateRule)
        {
            return fileCore.ReadEditFile(templateRule);
        }

        internal int ValidateStructure(string templateName)
        {
            Template template = GetTemplate(templateName);
            List<TemplateBuilder> templateBuilders = BuildTemplates(Tokens.VALIDATE_STRUCTURE, Configuration.SolutionPath, template.TemplateRules);
            Dictionary<TemplateBuilder, List<string>> dicCurretState = GetCurretState(templateBuilders);

            int count = 0;

            foreach (KeyValuePair<TemplateBuilder, List<string>> item in dicCurretState)
            {
                if (item.Value.Any())
                {
                    var dicOtherTemplates = dicCurretState.Where(d => d.Key != item.Key);
                    foreach (var itemOther in dicOtherTemplates)
                    {
                        Regex regexItem = new Regex(item.Key.FileName.Replace(Tokens.VALIDATE_STRUCTURE, @"(\w+)"));
                        Regex regexOther = new Regex(itemOther.Key.FileName.Replace(Tokens.VALIDATE_STRUCTURE, @"(\w+)"));

                        List<string> newFiles = item.Value.Where(i =>
                                !itemOther.Value.Exists(EqualsFiles(regexItem, i, regexOther)))
                            .Select(i => regexItem.Match(i).Groups[1].Value).ToList();

                        CreateValidateStructureFiles(itemOther, newFiles);
                        count += newFiles.Count;
                    }
                }
            }

            return count;

            Predicate<string> EqualsFiles(Regex regexItem, string item, Regex regexOther)
            {
                return other => 
                {
                    var matchItem = regexItem.Match(item);
                    var matchOther = regexOther.Match(other);

                    return matchItem.Success && matchOther.Success
                        && matchItem.Groups[1].Value.Equals(matchOther.Groups[1].Value);
                };
            }
        }

        internal void ExportTemplates(string fileNameZip)
        {
            compactorCore.ZipPath(Configuration.PhysicalPathTemplate, fileNameZip);
        }
        #endregion

        #region Private Methods
        private void CreateValidateStructureFiles(KeyValuePair<TemplateBuilder, List<string>> itemOther, List<string> newFiles)
        {
            if (newFiles.Any())
            {
                foreach (string file in newFiles)
                {
                    TemplateBuilder templateBuilder = tokenCore.MakeValidateStructure(itemOther.Key, file);
                    fileCore.WriteTemplateFile(templateBuilder);
                }
            }
        }

        private Dictionary<TemplateBuilder, List<string>> GetCurretState(List<TemplateBuilder> templateBuilders)
        {
            Dictionary<TemplateBuilder, List<string>> dicCurretState = new Dictionary<TemplateBuilder, List<string>>();

            foreach (TemplateBuilder templateBuilder in templateBuilders)
            {
                string path = templateBuilder.PhysicalPath;
                string extention = Path.GetExtension(templateBuilder.FileName);
                List<string> files = fileCore.GetValidateStructureFiles(path, extention);

                dicCurretState.Add(templateBuilder, files);
            }

            return dicCurretState;
        }

        private List<TemplateBuilder> BuildTemplates(string nameNewFile, string solutionPath, IEnumerable<TemplateRule> templateRules)
        {
            List<TemplateBuilder> templateBuilders = new List<TemplateBuilder>();

            foreach (TemplateRule rule in templateRules)
            {
                TemplateBuilder templateBuilder = CreateTemplateBuider(nameNewFile, solutionPath, rule);
                templateBuilders.Add(tokenCore.Make(templateBuilder));
            }

            return templateBuilders;
        }

        private TemplateBuilder CreateTemplateBuider(string nameNewFile, string solutionPath, TemplateRule rule)
        {
            return new TemplateBuilder
            {
                NameDefault = nameNewFile,
                PathNamespace = rule.TargeNamespace,//Path.GetFileName(solutionPath),

                FileName = rule.Target,
                SolutionPath = solutionPath,
                DestinationPath = rule.DestinationPath,
                FileContent = fileCore.ReadTemplateFile(Path.Combine(Configuration.PhysicalPathTemplate, rule.File)),
                Overide = rule.Overide
            };
        }

        private void Initialize()
        {
            fileCore = new FileCore(Configuration);
            tokenCore = new TokenCore(Configuration);
            compactorCore = new CompactorCore();

            Templates = fileCore.ReadTemplates().ToList();
        }
        #endregion

    }
}
