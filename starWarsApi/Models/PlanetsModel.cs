using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace starWarsApi.Models
{
	public class PlanetsModel
	{
        public class Results
        {
            public string name { get; set; }
            public string rotation_period { get; set; }
            public string orbital_period { get; set; }
            public string diameter { get; set; }
            public string climate { get; set; }
            public string gravity { get; set; }
            public string terrain { get; set; }
            public string surface_water { get; set; }
            public string population { get; set; }
            public IList<string> residents { get; set; }
            public IList<string> films { get; set; }
            public string created { get; set; }
            public string edited { get; set; }
            public string url { get; set; }

        }
        public class Application
        {
            public int count { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public IList<Results> results { get; set; }

        }
    }
}