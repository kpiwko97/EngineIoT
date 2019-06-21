using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngineIoT.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace EngineIoT.Controllers
{
    public class HomeController:Controller
    {
        private readonly SmartHouseContext _context;
        private readonly ISmartHouseRepository _repository;

        public HomeController(SmartHouseContext context, ISmartHouseRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        //{
        //    "ConnectionStrings": {
        //        "EngineIoTConnectionString": "Server=192.168.1.103;Database=SmartHouse;User ID=SA;Password=Kamciolo*1"
        //    }
        //}



        public ViewResult Index() => View("Index", _context.EspWroom.ToList());

        [HttpPost]
        public IActionResult Json([FromBody] JObject jsonObject)
        {
            var temperature  = jsonObject.GetValue("Temperature").ToString();
            _repository.AddTemperature(Convert.ToDecimal(temperature));
          
            return RedirectToAction(nameof(Index));
        }

    }
}
