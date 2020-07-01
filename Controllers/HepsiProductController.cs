using Hepsiburada_Marketplace.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace Hepsiburada_Marketplace.Controllers
{
    public class HepsiProductController : BaseController
    {

        //tekrar bakılacak
        public async Task<ResponseModel<TrackingData[]>> ProductImport([System.Web.Http.FromBody] ProductImportModel productImportModel)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("/product/api/products/import", productImportModel)?.GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<TrackingData[]>>(responseStr);
                return responseModel;

            }
            var responseMessage = new ResponseModel<TrackingData[]>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;

        }
        [HttpGet, Route("GetAllCategory/{page}/{size}")]
        public async Task<ResponseModel<ProductStatusModel[]>> GetProductStatus(int page, int size, string trackingId)
        {
       
            var response = client.GetAsync($"/product/api/products/status/{trackingId}?page={page}&size={size}").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<ProductStatusModel[]>>(responseStr);
                if (responseModel.Success)
                {
                    return responseModel;
                }
            }

            var responseMessage = new ResponseModel<ProductStatusModel[]>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;
        }
        public async Task<ResponseModel<TrackingIdHistoryModel[]>> GetTrackingIdHistory(int page, int size, int version, string sort)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync($"/product/api/products/trackingId-history?version={version}&page={page}&size={size}&sort={sort}").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<TrackingIdHistoryModel[]>>(responseStr);
                if (responseModel.Success)
                {
                    return responseModel;
                }
            }
            var responseMessage = new ResponseModel<TrackingIdHistoryModel[]>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;
        }
    }
}
