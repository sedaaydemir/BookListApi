using BookListApi.WebUi.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookListApi.WebUi.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoriesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategoryList()
        {
            var client =_httpClientFactory.CreateClient();
            var responseMEssage = await client.GetAsync("https://localhost:7275/api/Category");
            if (responseMEssage.IsSuccessStatusCode)
            {
                var jsonData= await responseMEssage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
