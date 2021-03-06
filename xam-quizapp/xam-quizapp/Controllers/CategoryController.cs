using Newtonsoft.Json.Linq;
using quizapp.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
// its shows different category....
namespace quizapp.Controllers
{
    public class CategoryController : ICategoryController
    {
        private static string _categoryUrl;
        private IHttpClientFactory _requestClient;
        public CategoryController(IHttpClientFactory client)
        {
            _categoryUrl = "https://opentdb.com/api_category.php";
            _requestClient = client;
        }
        //its shows list of quiz category....
        public async Task<List<QuizCategory>> GetQuizCategories()
        {
            var catList = new List<QuizCategory>();
            var categoryJson = await GetCategoryJson();
            if(categoryJson != null)
            {
                var categories = categoryJson.GetValue("trivia_categories") as JArray;
                foreach(var item in categories)
                {
                    catList.Add(item.ToObject<QuizCategory>());
                }
            }
            return catList;
        }

        private async Task<JObject> GetCategoryJson()
        {
            JObject response = null;
            try
            {
                using (var client = _requestClient.CreateClient())
                {
                    var json = await client.GetStringAsync(_categoryUrl);
                    response = JObject.Parse(json);
                }
            }
            catch(HttpRequestException ex)
            {
                var errorMessage = ex.InnerException;
            }
            
            return response;
        }
    }
}
