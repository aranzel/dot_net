using System.ComponentModel;

namespace SpSofty.CodeGeneration.Core.Models
{
    public class TemplateBuilder
    {
        public string NameDefault { get; set; }
        public string PathNamespace { get; set; }

        public string FileName { get; set; }
        public string SolutionPath { get; set; }
        public string DestinationPath { get; set; }
        public string FileContent { get; set; }
        public bool Overide { get; set; }

        public string PhysicalPath { get { return System.IO.Path.Combine(SolutionPath, DestinationPath); } }
        public string FullName { get { return System.IO.Path.Combine(PhysicalPath, FileName); } }

    }
}
