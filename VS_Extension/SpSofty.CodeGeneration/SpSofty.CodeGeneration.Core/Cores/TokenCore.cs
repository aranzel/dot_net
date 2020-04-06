using SpSofty.CodeGeneration.Core.Constants;
using SpSofty.CodeGeneration.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpSofty.CodeGeneration.Core.Cores
{
    public class TokenCore
    {
        private readonly Configuration configuration;

        public TokenCore(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public TemplateBuilder Make(TemplateBuilder templateBuilder)
        {
            templateBuilder.FileName = templateBuilder.FileName.Replace(Tokens.TARGET_NAME, templateBuilder.NameDefault);
            templateBuilder.DestinationPath = templateBuilder.DestinationPath.Replace(Tokens.TARGET_PROJECT_NAME, templateBuilder.PathNamespace);


            string fileContent = templateBuilder.FileContent;
            fileContent = fileContent.Replace(Tokens.SAFE_NAME, templateBuilder.NameDefault);
            fileContent = fileContent.Replace(Tokens.ROOT_NAMESPACE, templateBuilder.PathNamespace);

            templateBuilder.FileContent = fileContent;
            return templateBuilder;
        }

        internal TemplateBuilder MakeValidateStructure(TemplateBuilder templateBuilder, string file)
        {
            string fileContent = templateBuilder.FileContent.Replace(Tokens.VALIDATE_STRUCTURE, file);

            TemplateBuilder resultTemplateBuilder = new TemplateBuilder
            {
                FileName = templateBuilder.FileName.Replace(Tokens.VALIDATE_STRUCTURE, file),
                DestinationPath = templateBuilder.DestinationPath,
                NameDefault = templateBuilder.NameDefault.Replace(Tokens.VALIDATE_STRUCTURE, file),
                Overide = templateBuilder.Overide,
                PathNamespace = templateBuilder.PathNamespace,
                SolutionPath = templateBuilder.SolutionPath,
                FileContent = fileContent
            };

            return resultTemplateBuilder;
        }

        internal string PrepareEditNewFile(string nameClass, string namespaceClass, string contentFile)
        {
            string className = Path.GetFileNameWithoutExtension(nameClass);
            
            string contentFileClassName = Regex.Replace(contentFile, 
                Basic.EREGEX_CLASS_NAME.Replace(Basic.TOKEN_CLASS_NAME, className), Tokens.SAFE_NAME);
            string contentFileResult = Regex.Replace(contentFileClassName, 
                namespaceClass.Replace(".", @"\."), Tokens.ROOT_NAMESPACE);

            return contentFileResult;
        }
    }
}
