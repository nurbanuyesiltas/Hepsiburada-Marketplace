using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Hepsiburada_Marketplace.Models
{
    public partial class CategoryModel
    {
        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentCategoryId")]
        public long ParentCategoryId { get; set; }

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        [JsonProperty("leaf")]
        public bool Leaf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }
    }

}

