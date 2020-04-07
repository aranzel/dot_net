using Newtonsoft.Json;
using SpSofty.CodeGeneration.Core.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SpSofty.CodeGeneration.Core.Cores
{
    internal class FileCore
    {
        private readonly Configuration configuration;

        public FileCore(Configuration configuration)
        {
            this.configuration = configuration;
        }

        #region Internal Methods
        internal IEnumerable<Template> ReadTemplates()
        {
            return ReadTemplates(configuration.ConfigurationFile);
        }

        internal IEnumerable<Template> ReadTemplates(string fileImporteTemplates)
        {
            if (File.Exists(fileImporteTemplates))
            {
                using (StreamReader reader = GetReader(fileImporteTemplates))
                {
                    return JsonConvert.DeserializeObject<IEnumerable<Template>>(reader.ReadToEnd());
                }
            }
            else
            {
                return new List<Template>();
            }
        }

        internal void WriteTemplates(IEnumerable<Template> templates)
        {
            templates.ToList().ForEach(t => CreateDirectory(t.PhysicalPath));

            using (StreamWriter writer = GetWriter(configuration.ConfigurationFile))
            {
                writer.Write(JsonConvert.SerializeObject(templates));
            }
        }

        internal string ReadTemplateFile(string fullName)
        {
            using (StreamReader reader = GetReader(fullName))
            {
                return reader.ReadToEnd();
            }
        }

        internal string ReadEditFile(TemplateRule templateRule)
        {
            string fullName = GetFullNameFileRule(templateRule);
            return ReadTemplateFile(fullName);
        }

        internal void WriteTemplateFile(TemplateBuilder templateBuilder)
        {
            if (templateBuilder.Overide
                || !File.Exists(templateBuilder.FullName))
            {
                if (!Directory.Exists(templateBuilder.PhysicalPath))
                {
                    Directory.CreateDirectory(templateBuilder.PhysicalPath);
                }

                using (StreamWriter writer = GetWriter(templateBuilder.FullName))
                {
                    writer.WriteLine(templateBuilder.FileContent);
                }
            }
        }

        internal string ReadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = GetReader(fileName))
                {
                    return reader.ReadToEnd();
                }
            }

            return string.Empty;
        }

        internal string GetImportFileConfiguration(string pathUnzip)
        {
            string[] files = Directory.GetFiles(pathUnzip, @"*.json");
            
            if (files.Length == 0)
            {
                throw new FileNotFoundException("Template configuration file not found.");
            }
            if (files.Length > 1)
            {
                throw new FileLoadException("More than one template configuration file was found. It is not possible to load more than one configuration file.");
            }

            using (StreamReader reader = GetReader(files[0]))
            {
                return reader.ReadToEnd();
            }
        }

        internal void CreteRule(TemplateRule templateRule, string contentFile)
        {
            string fullName = GetFullNameFileRule(templateRule);

            if (!Directory.Exists(Path.GetDirectoryName(fullName)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fullName));
            }

            using (StreamWriter writer = GetWriter(fullName))
            {
                writer.Write(contentFile);
            }
        }

        internal List<string> GetValidateStructureFiles(string path, string extension)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, $"*{extension}");
                if (files != null && files.Any())
                {
                    return files.Select(f => Path.GetFileName(f)).ToList();
                }
            }

            return new List<string>();
        }

        internal void EditRule(TemplateRule templateRule, string contentFile)
        {
            string fullName = GetFullNameFileRule(templateRule);
            using (StreamWriter writer = GetWriter(fullName))
            {
                writer.Write(contentFile);
            }
        }

        internal void DeleteRule(TemplateRule templateRule)
        {
            string fullName = GetFullNameFileRule(templateRule);
            File.Delete(fullName);
        }
        #endregion

        #region Private Methods
        private string GetFullNameFileRule(TemplateRule templateRule)
        {
            return Path.Combine(configuration.PhysicalPathTemplate, templateRule.File);
        }

        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private StreamReader GetReader(string path)
        {
            return new StreamReader(File.Open(path, FileMode.Open), Encoding.UTF8);
        }

        private StreamWriter GetWriter(string path)
        {
            return new StreamWriter(File.Open(path, FileMode.Create), Encoding.UTF8);
        }
        #endregion
    }
}
