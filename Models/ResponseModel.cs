using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hepsiburada_Marketplace.Models
{
    public class ResponseModel<T>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}