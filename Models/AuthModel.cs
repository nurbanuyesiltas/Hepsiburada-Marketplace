using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Hepsiburada_Marketplace.Models
{
    public partial class AuthModel
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("authenticationType")]
        public string AuthenticationType { get; set; }
    }
}