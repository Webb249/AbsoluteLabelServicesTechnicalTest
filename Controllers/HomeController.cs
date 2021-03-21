using AbsoluteLabelServicesTechnicalTest.Models;
using AbsoluteLabelServicesTechnicalTest.Services;
using IndexPageUI;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AbsoluteLabelServicesTechnicalTest.Controllers
{
    public class HomeController : Controller 
    {        
        private readonly HomeModel indexModelData = new HomeModel();
        
        public IActionResult Index()
        {
            return View(indexModelData);
        }

        // Run when submit button pressed
        [HttpPost]
        public async Task<IActionResult> Index(string searchphrase, string entity)
        {
            // Left hardcoded, but with ability to add new api's easily
            IApi api = new ItunesApi();

            indexModelData.ResultsList = await api.GetSearchResultsAsync(searchphrase, entity);

            return View(indexModelData);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
