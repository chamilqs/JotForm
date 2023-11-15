using JotformWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace JotformWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // Reemplaza la URL de la API y la clave de la API con tus propios valores
                var apiKey = "e62e435c907db1206be507454c7dea1b";
                var formId = 233176380006854;

                var client = new JotForm.APIClient(apiKey);
                var user = client.getFormSubmissons(formId);

                // Pasa los datos a la vista si es necesario
                ViewData["ApiData"] = user;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al llamar a la API de JotForm: {ex.Message}");
                ViewData["ApiData"] = "Error al obtener datos de la API.";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
