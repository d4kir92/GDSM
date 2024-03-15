using System.Net.Http;
using System.Threading.Tasks;

namespace GModDedicatedServer
{
    class HTTP
    {
        public static async Task<string> Get(string URI)
        {
            using HttpClient client = new();
            // Add a user agent header
            client.DefaultRequestHeaders.Add("User-Agent", "Googlebot/2.1 (+http://www.googlebot.com/bot.html)");

            // Send the GET request asynchronously
            HttpResponseMessage response = await client.GetAsync(URI);

            // Check for successful response
            if (response.IsSuccessStatusCode)
            {
                // Read the response content as a string asynchronously
                string responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            else
            {
                // Handle unsuccessful response
                throw new HttpRequestException($"Error getting data: {response.StatusCode}");
            }
        }
    }
}
