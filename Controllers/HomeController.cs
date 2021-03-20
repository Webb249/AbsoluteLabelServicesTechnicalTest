using AbsoluteLabelServicesTechnicalTest.Models;
using IndexPageUI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbsoluteLabelServicesTechnicalTest.Controllers
{
    public class HomeController : Controller 
    {
        static ISearchType searchType = new ItunesSearch();
        static IWebReader webReader = new WebReader();
        Index IndexModelData = new Index(searchType, webReader);

        public IActionResult Index()
        {
            return View(IndexModelData);
        }

        // Run when submit button pressed
        [HttpPost]
        public async Task<IActionResult> Index(string searchphrase, string entity)
        {
            IndexModelData.SearchPhrase = searchphrase;
            IndexModelData.Entity = entity;

            await IndexModelData.RunGetSearchResults();

            return View(IndexModelData);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
