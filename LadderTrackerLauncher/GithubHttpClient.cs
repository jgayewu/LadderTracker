using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace LadderTrackerLauncher
{
    internal class GithubHttpClient
    {
        public static async Task<string> GetLatestVersion()
        {
            HttpResponseMessage response = null;

            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("https://api.github.com/repos/jgayewu/LadderTracker/releases/latest"),
                    Method = HttpMethod.Get,
                };
                request.Headers.Add("User-Agent", "request");

                response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(jsonResponse);
                return jObject["tag_name"].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                throw;
            }
            finally
            {
                if (response != null)
                    response.Dispose();
            }
        }

        public static void DownloadVersion(string version, string downloadDirectory)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                webClient.Headers.Add("User-Agent: request");
                webClient.DownloadFile(new Uri($"https://github.com/jgayewu/LadderTracker/releases/latest/download/{version}.zip"), Path.Combine(downloadDirectory, $"{version}.zip"));
            }
            catch(Exception e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                throw;
            }
        }
    }
}
