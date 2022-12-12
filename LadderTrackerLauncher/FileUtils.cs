using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace LadderTrackerLauncher
{
    internal class FileUtils
    {
        const string FOLDER_NAME = "LadderTrackerInstall";

        public static string GetInstalledVersion()
        {
            return new DirectoryInfo(GetInstallDirectory())
                .GetFiles()
                .FirstOrDefault(f => f.FullName.Contains(".zip"))?.Name.Replace(".zip", "");
        }

        public static void ClearInstallDirectory(List<string> exceptions)
        {
            foreach (FileInfo file in new DirectoryInfo(GetInstallDirectory()).GetFiles())
            {
                if(exceptions == null || !exceptions.Contains(file.Name))
                    file.Delete();
            }
        }

        public static void Unzip(string fileName)
        {
            string fileNameWithExtention = (fileName.EndsWith(".zip")) ? fileName : fileName + ".zip";
            ZipArchive zip = new ZipArchive(new StreamReader(Path.Combine(GetInstallDirectory(), fileNameWithExtention)).BaseStream);
            zip.ExtractToDirectory(GetInstallDirectory());
        }

        public static string GetInstallDirectory()
        {
            //CreateDirectory will do nothing if it already exists
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), FOLDER_NAME));
            return Path.Combine(Directory.GetCurrentDirectory(), FOLDER_NAME);
        }
    }
}
