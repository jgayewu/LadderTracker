using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LadderTrackerLauncher
{
    internal class VersionManager
    {
        const string EXE_NAME = "LadderTracker.exe";

        public static void UpdateAndLaunch()
        {
            string currentVersion = FileUtils.GetInstalledVersion();
            string latestVersion = GithubHttpClient.GetLatestVersion().Result;

            if(IsNewerVersion(currentVersion, latestVersion))
            {
                FileUtils.ClearInstallDirectory(new List<string>() { "LadderTrackerDB.db" });
                GithubHttpClient.DownloadVersion(latestVersion, FileUtils.GetInstallDirectory());
                FileUtils.Unzip(latestVersion);
            }

            Process.Start(Path.Combine(FileUtils.GetInstallDirectory(), EXE_NAME));
        }

        static bool IsNewerVersion(string originalVersion, string newVersion)
        {
            if (originalVersion == null)
                return true;

            if (originalVersion == newVersion)
                return false;

            string origExtracted = Regex.Match(originalVersion, @"(\d+\.\d+\.\d+)").Groups[0].Value;
            string newExtracted = Regex.Match(newVersion, @"(\d+\.\d+\.\d+)").Groups[0].Value;

            string[] firstVersions = origExtracted.Split('.');
            string[] secondVersions = newExtracted.Split('.');

            int firstNumerical = (int.Parse(firstVersions[0]) * 100) + (int.Parse(firstVersions[1]) * 10) + int.Parse(firstVersions[2]);
            int secondNumerical = (int.Parse(secondVersions[0]) * 100) + (int.Parse(secondVersions[1]) * 10) + int.Parse(secondVersions[2]);

            return firstNumerical < secondNumerical;
        }
    }
}
