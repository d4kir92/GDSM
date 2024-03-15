using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GModDedicatedServer
{
    class IP
    {
        public static async Task<string> GetPublicIP()
        {
            string publicIP;
            try
            {
                using HttpClient client = new();
                HttpResponseMessage response = await client.GetAsync("http://checkip.dyndns.org");
                response.EnsureSuccessStatusCode(); // Check for HTTP errors

                string responseString = await response.Content.ReadAsStringAsync();
                publicIP = responseString.Split(':')[1][1..].Split('<')[0].Trim();
            }
            catch (Exception ex)
            {
                publicIP = "[CATCH] NO INTERNET";
                Console.WriteLine($"Error getting public IP: {ex.Message}"); // Log the exception (optional)
            }
            return publicIP;
        }

        public static async Task<string> GetLocalIP()
        {
            string localIP;
            try
            {
                // Replaced Dns call with HttpClient to get own IP from a public server
                using HttpClient client = new();
                HttpResponseMessage response = await client.GetAsync("https://api.ipify.org");
                response.EnsureSuccessStatusCode(); // Check for HTTP errors

                localIP = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get local IP address", ex);
            }
            return localIP;
        }
    }
}
