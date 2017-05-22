using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Windows.BussinessLogic
{
    class Server
    {
        const string APP_PATH = "http://localhost:50488/api";

        public static TransferProduct GetAllData(string EAN13)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/default/GetProductWithQR?EAN13={EAN13}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<TransferProduct>(result);
            }
        }

        public static List<ProductType> GetAllTypes()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"{APP_PATH}/default/GetAllTypes/").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<ProductType>>(result);
            }
        }


        public static string AddProduct(Product product)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/default/AddProduct", product).Result;
                return response.StatusCode.ToString();
            }
        }

        public static string AddType(ProductType type)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync($"{APP_PATH}/default/AddType", type).Result;
                return response.StatusCode.ToString();
            }
        }
    }
}
