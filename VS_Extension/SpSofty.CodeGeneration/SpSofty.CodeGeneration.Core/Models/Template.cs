using System.Collections.Generic;

namespace SpSofty.CodeGeneration.Core.Models
{
    public class Template
    {
        public string Name { get; set; }
        public string PhysicalPath { get; set; }
        public List<TemplateRule> TemplateRules { get; set; }

        public Template()
        {
            TemplateRules = new List<TemplateRule>();
        }
    }
}
