using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Interfaces;

namespace WPFApp.Services
{
    class DateTimeService : IDateTime
    {
        public DateTime? GetCurentTime()
        {
            return DateTime.Now;
        }
    }
}
