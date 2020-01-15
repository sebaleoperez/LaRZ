using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace LaRZ.Helpers
{
    class WebDataHelper
    {
        private const string imageGetLink = "http://www.larz.com.ar/ventaprogramaapp.php";
        private const string nameGetLink = "http://www.larz.com.ar/nombreprogramaapp.php";

        public async static Task<string> GetProgramLink()
        {
            string imageUrl = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(imageGetLink);
                imageUrl = await response.Content.ReadAsStringAsync();
            }

            return imageUrl;
        }

        public async static Task<string> GetProgramName()
        {
            string name = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(nameGetLink);
                name = await response.Content.ReadAsStringAsync();
            }

            return WebUtility.HtmlDecode(name.Trim());
        }
    }
}
