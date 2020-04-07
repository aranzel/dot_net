using System.IO.Compression;

namespace SpSofty.CodeGeneration.Core.Cores
{
    internal class CompactorCore
    { 
        public void ZipPath(string pathZip, string fileZip)
        {
            ZipFile.CreateFromDirectory(pathZip, fileZip);
        }

        public void UnzipPath(string fileZip, string pathZip)
        {
            ZipFile.ExtractToDirectory(fileZip, pathZip);
        }
    }
}
