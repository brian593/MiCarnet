using System;
using SQLite;

namespace MiCarnet.Models
{
    public class CarnetModel
    {
        [PrimaryKey]
        public string id { get; set; }
        public string name { get; set; }
        public string path { get; set; }

        public string first { get; set; }
        public string second { get; set; }
        public string third { get; set; }


        public CarnetModel()
        {
        }
    }
}
