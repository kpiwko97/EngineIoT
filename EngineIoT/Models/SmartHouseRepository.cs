using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace EngineIoT.Models
{
    public class SmartHouseRepository:ISmartHouseRepository
    {
        private readonly SmartHouseContext _context;

        public SmartHouseRepository(SmartHouseContext context)
        {
            _context = context;
        }

        public void AddTemperature(decimal temperature)
        {
            _context.EspWroom.Add(new EspWroom {Temperature = temperature});
            _context.SaveChanges();
        }
        
    }
}
