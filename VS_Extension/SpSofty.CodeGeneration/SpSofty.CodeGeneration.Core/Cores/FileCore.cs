using Newtonsoft.Json;
using SpSofty.CodeGeneration.Core.Models;
using System;
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

        public IEnumerable<Template> ReadTemplates()
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

        public void WriteTemplates(IEnumerable<Template> templates)
        {
            templates.ToList().ForEach(t => CreateDirectory(t.PhysicalPath));

            using (StreamWriter writer = GetWriter(configuration.ConfigurationFile))
            {
                writer.Write(JsonConvert.SerializeObject(templates));
            }
        }

        public string ReadTemplateFile(string fullName)
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

        public void WriteTemplateFile(TemplateBuilder templateBuilder)
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
    }
}
