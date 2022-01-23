using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CarPark.User.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
          
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var say_Hello_value1 = _localizer["Say_Hello"];

            var cultureInfo = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            var say_Hello_value = _localizer["Say_Hello"];
            
            var customer = new Customer
            {
                Id = 1,
                NameSurname = "şahinÇetin",
                Age = 29
            };

            #region mongodb Kodları

            //var settings = MongoClientSettings.FromConnectionString("mongodb+srv://shnctn:shnctn05@carpark.vzj81.mongodb.net/CarParkDB?retryWrites=true&w=majority");
            //var client = new MongoClient(settings);
            //var database = client.GetDatabase("CarParkDB");
            //var collection = database.GetCollection<Test>("Test");
            //var test = new Test()
            //{
            //    _Id = ObjectId.GenerateNewId(),
            //    NameSurname = "Şahin Çetin",
            //    Age = 29,
            //    AddressList = new List<Address>()
            //    {
            //        new Address
            //        {
            //            Title = "ev adresim",
            //            Desciription = "Eren Sok. Başakşehir",
            //        },
            //        new Address
            //        {
            //            Title = "iş adresim",
            //            Desciription = " batamsdfvm a neabase f"
            //        }

            //    }
            //};
            //collection.InsertOne(test); 
            #endregion

            _logger.LogError("customerda hata oluştu {@customer}",customer);

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
