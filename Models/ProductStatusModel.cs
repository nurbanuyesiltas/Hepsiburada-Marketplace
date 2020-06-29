using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hepsiburada_Marketplace.Models
{
    public partial class ProductStatusModel
    {
        [JsonProperty("itemOrderID")]
        public long ItemOrderId { get; set; }

        [JsonProperty("merchant")]
        public Guid Merchant { get; set; }

        [JsonProperty("merchantSku")]
        public string MerchantSku { get; set; }

        [JsonProperty("productStatus")]
        public string ProductStatus { get; set; }

        [JsonProperty("taskDetails")]
        public object[] TaskDetails { get; set; }

        [JsonProperty("validationResults")]
        public ValidationResult[] ValidationResults { get; set; }

        [JsonProperty("importStatus")]
        public string ImportStatus { get; set; }

        [JsonProperty("importMessages")]
        public object[] ImportMessages { get; set; }
    }
    public partial class ValidationResult
    {
        [JsonProperty("attributeName")]
        public string AttributeName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

}