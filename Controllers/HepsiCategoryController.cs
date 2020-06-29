using Hepsiburada_Marketplace.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Hepsiburada_Marketplace.Controllers
{
    [Route("api/HepsiCategory")]
    public class HepsiCategoryController : BaseController
    {
        //[HttpGet]
        //[Route("GetAllCategory/{page}/{size}")]
        [HttpGet, Route("GetAllCategory/{page}/{size}")]
        public async Task<ResponseModel<CategoryModel[]>> GetAllCategory(int page, int size)
        {
            client.BaseAddress = new Uri("/product/api/categories/get-all-categories");

            var response = client.GetAsync($"/product/api/categories/get-all-categories?page={page}&size={size}").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<CategoryModel[]>>(responseStr);
                if (responseModel.Success)
                {
                    return responseModel;
                }
            }

            var responseMessage = new ResponseModel<CategoryModel[]>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;
        }

        [HttpGet]
        [Route("GetCategoryAttributes/{categoryId}")]
        public async Task<ResponseModel<AttributesModel>> GetCategoryAttributes(int categoryId)
        {

            client.BaseAddress = new Uri("/product/api/categories/{categoryId}/attributes");

            var response = client.GetAsync($"/product/api/categories/{categoryId}/attributes").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<AttributesModel>>(responseStr);
                if (responseModel.Success)
                {
                    return responseModel;
                }
            }

            var responseMessage = new ResponseModel<AttributesModel>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;
        }
        [HttpGet]
        [Route("GetAttributeValue/{categoryId}/{attributeId}")]
        public async Task<ResponseModel<ValueModel[]>> GetAttributeValue(int categoryId, int attributeId)
        {
            client.BaseAddress = new Uri("/product/api/categories/{categoryId}/attribute/{attributeId}");

            var response = client.GetAsync($"/product/api/categories/{categoryId}/attribute/{attributeId}").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseStr = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<ResponseModel<ValueModel[]>>(responseStr);
                if (responseModel.Success)
                {
                    return responseModel;
                }
            }

            var responseMessage = new ResponseModel<ValueModel[]>();
            responseMessage.Message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            responseMessage.Code = (long)HttpStatusCode.BadRequest;
            return responseMessage;
        }
    }
}
