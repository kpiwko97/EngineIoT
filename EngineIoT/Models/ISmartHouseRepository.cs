using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineIoT.Models
{
    public interface ISmartHouseRepository
    {
        void AddTemperature(decimal temperature);
    }
}
