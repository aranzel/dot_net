namespace SpSofty.CodeGeneration.Core.Models
{
    public class TemplateRule
    {
        public string Target { get; set; }
        public string TargeNamespace { get; set; }
        public string DestinationPath { get; set; }
        public string File { get; set; }
        public string Name { get { return System.IO.Path.GetFileName(File); } }
        public bool Overide { get; set; }

        public TemplateRule()
        {
            Overide = false;
        }
    }
}
