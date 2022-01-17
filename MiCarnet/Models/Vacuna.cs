using System;
using System.Collections.Generic;

namespace MiCarnet.Models
{
    public class Vacuna
    {

        public class Datavacuna
        {
            public string nomvacuna { get; set; }
            public int dosisaplicada { get; set; }
            public string fechavacuna { get; set; }
        }

        public class Datapersona
        {
            public string fechanacimiento { get; set; }
            public string nombres { get; set; }
            public string idencrypt { get; set; }
        }

        public class Data
        {
            public bool status { get; set; }
            public string message { get; set; }
            public List<Datavacuna> datavacuna { get; set; }
            public List<Datapersona> datapersona { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
        }


    }
}
