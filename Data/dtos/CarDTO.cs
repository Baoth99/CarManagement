using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.dtos
{
    public class CarDTO
    {
        public string carID { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string origin { get; set; }
        public string color { get; set; }
        public float price { get; set; }
        public bool status { get; set; }
        public string imageName { get; set; }
        public bool sale { get; set; }
    }
}
