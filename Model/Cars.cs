using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPIClient.Model
{
    class Cars
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public DateTime NextCheck { get; set; }
        public int Power { get; set; }
        public int Mileage { get; set; }
    }
}
