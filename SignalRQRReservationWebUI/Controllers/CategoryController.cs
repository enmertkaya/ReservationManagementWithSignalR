using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SignalRQRReservationWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public CategoryController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()

		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7018/api/Category");
			if (responseMessage.IsSuccessStatusCode)
			{

				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<Dtos.CategoryDtos.ResultCategoryDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
