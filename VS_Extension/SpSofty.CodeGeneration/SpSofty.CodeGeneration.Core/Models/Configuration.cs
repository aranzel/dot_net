namespace SpSofty.CodeGeneration.Core.Models
{
    public class Configuration
    {
        public string ConfigurationFile { get; }
        public string SolutionPath { get; }
        public string PhysicalPathTemplate { get { return System.IO.Path.GetDirectoryName(ConfigurationFile); } }

        public Configuration(string configurationFile, string solutionPath)
        {
            ConfigurationFile = configurationFile;
            SolutionPath = solutionPath;
        }
    }
}
