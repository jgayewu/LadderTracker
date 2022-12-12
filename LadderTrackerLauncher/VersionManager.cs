using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace LadderTrackerLauncher
{
    internal class VersionManager
    {
        const string EXE_NAME = "LadderTracker.exe";
        private static List<string> FILE_DELETION_EXCEPTIONS = new List<string>(){ "LadderTrackerDB.db" };

        public static void UpdateAndLaunch()
        {
            string currentVersion = FileUtils.GetInstalledVersion();
            string latestVersion = GithubHttpClient.GetLatestVersion().Result;

            if(IsNewerVersion(currentVersion, latestVersion))
            {
                FileUtils.ClearInstallDirectory(FILE_DELETION_EXCEPTIONS);
                GithubHttpClient.DownloadVersion(latestVersion, FileUtils.GetInstallDirectory());
                FileUtils.Unzip(latestVersion);
            }

            Process.Start(Path.Combine(FileUtils.GetInstallDirectory(), EXE_NAME));
        }

        static bool IsNewerVersion(string originalVersion, string incomingVersion)
        {
            if (originalVersion == null)
                return true;

            if (originalVersion == incomingVersion)
                return false;

            //regex magic to pull just the x.x.x numbering
            string origExtracted = Regex.Match(originalVersion, @"(\d+\.\d+\.\d+)").Groups[0].Value;
            string newExtracted = Regex.Match(incomingVersion, @"(\d+\.\d+\.\d+)").Groups[0].Value;

            string[] originalVersionNumbers = origExtracted.Split('.');
            string[] incomingVersionNumbers = newExtracted.Split('.');

            //major
            if (int.Parse(originalVersionNumbers[0]) < int.Parse(incomingVersionNumbers[0]))
                return true;

            //minor
            if (int.Parse(originalVersionNumbers[1]) < int.Parse(incomingVersionNumbers[1]))
                return true;

            //revision
            if (int.Parse(originalVersionNumbers[2]) < int.Parse(incomingVersionNumbers[2]))
                return true;

            return false;
        }
    }
}
