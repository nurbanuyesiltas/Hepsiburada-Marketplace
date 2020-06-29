using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hepsiburada_Marketplace.Models
{
    public partial class AttributesModel
    {
        [JsonProperty("baseAttributes")]
        public Attribute[] BaseAttributes { get; set; }

        [JsonProperty("attributes")]
        public Attribute[] Attributes { get; set; }

        [JsonProperty("variantAttributes")]
        public Attribute[] VariantAttributes { get; set; }
    }

    public partial class Attribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("multiValue")]
        public bool MultiValue { get; set; }
        public enum TypeEnum { Enum, Integer, String };
    }
}