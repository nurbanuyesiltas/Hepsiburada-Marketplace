using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Hepsiburada_Marketplace.Controllers
{
    public class BaseController : ApiController
    {
        public HttpClient client;
        HepsiAuthController _controller;
        public BaseController()
        {
            _controller = new HepsiAuthController();
            client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _controller.GetToken().GetAwaiter().GetResult());
        }
    }
}
