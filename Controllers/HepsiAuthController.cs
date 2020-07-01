using Hepsiburada_Marketplace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Hepsiburada_Marketplace.Controllers
{
    public class HepsiAuthController : ApiController
    {
        public async Task<string> GetToken()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://mpop.hepsiburada.com");


            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var payload = "{ \"AuthenticationType\" = \"INTEGRATOR\", \"Username\" = \"xyz\", \"Password\" = \"xyz\" }";

            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = httpClient.PostAsync("/api/authenticate", content)?.GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                return await response.Content?.ReadAsStringAsync();

            }

            return null;

        }
    }
}
