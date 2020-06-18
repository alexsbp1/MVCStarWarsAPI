using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace starWarsApi.Models
{
	public class CharactersModel
	{
        public class Results
        {
            public string name { get; set; }
            public string height { get; set; }
            public string mass { get; set; }
            public string hair_color { get; set; }
            public string skin_color { get; set; }
            public string eye_color { get; set; }
            public string birth_year { get; set; }
            public string gender { get; set; }
            public string homeworld { get; set; }
            public IList<string> films { get; set; }
            public IList<string> species { get; set; }
            public IList<string> vehicles { get; set; }
            public IList<string> starships { get; set; }
            public string created { get; set; }
            public string edited { get; set; }
            public string url { get; set; }

            //public IList<string> searchName { get; set; }

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