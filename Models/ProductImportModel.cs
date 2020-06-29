using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hepsiburada_Marketplace.Models
{
    public partial class ProductImportModel
    {
        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("merchant")]
        public string merchant { get; set; }

        [JsonProperty("attributes")]
        public ProductAttribute attributes { get; set; }
    }
    public partial class ProductAttribute
    {
        [JsonProperty("merchantSku")]
        public string merchantSku { get; set; }
        [JsonProperty("VaryantGroupID")]
        public string VaryantGroupID { get; set; }
        [JsonProperty("Barcode")]
        public long Barcode { get; set; }
        [JsonProperty("UrunAdi")]
        public string UrunAdi { get; set; }
        [JsonProperty("UrunAciklamasi")]
        public string UrunAciklamasi { get; set; }
        [JsonProperty("Marka")]
        public string Marka { get; set; }
        [JsonProperty("GarantiSuresi")]
        public byte GarantiSuresi { get; set; }
        [JsonProperty("kg")]
        public double kg { get; set; }
        [JsonProperty("tax_vat_rate")]
        public int tax_vat_rate { get; set; }
        [JsonProperty("Image1")]
        public string Image1 { get; set; }
        [JsonProperty("Image2")]
        public string Image2 { get; set; }
        [JsonProperty("Image3")]
        public string Image3 { get; set; }
        [JsonProperty("Image4")]
        public string Image4 { get; set; }
        [JsonProperty("Image5")]
        public string Image5 { get; set; }
        [JsonProperty("renk_variant_property")]
        public string renk_variant_property { get; set; }
        [JsonProperty("ebatlar_variant_property")]
        public string ebatlar_variant_property { get; set; }
    }
    public partial class TrackingData
    {
        [JsonProperty("trackingId")]
        public Guid TrackingId { get; set; }
    }
}