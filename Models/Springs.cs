using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Springs.Models
{
    public class Springs
    {
        public int Id { get; set; }

        public int Model { get; set; }
        public string Color { get; set; }

        public string Material { get; set; }

        //[DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        //public int Model { get; set; }
        public decimal Price { get; set; }

        public string IndustryName { get; set; }

        //public string Material { get; set; }
    }
}
