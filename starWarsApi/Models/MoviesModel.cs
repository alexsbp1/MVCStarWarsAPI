using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace starWarsApi.Models
{
	public class MoviesModel
	{
        public class Results
        {
            public string title { get; set; }
            public int episode_id { get; set; }
            public string opening_crawl { get; set; }
            public string director { get; set; }
            public string producer { get; set; }
            public string release_date { get; set; }
            public IList<string> characters { get; set; }
            public IList<string> planets { get; set; }
            public IList<string> starships { get; set; }
            public IList<string> vehicles { get; set; }
            public IList<string> species { get; set; }
            public string created { get; set; }
            public string edited { get; set; }
            public string url { get; set; }

        }
        public class Application
        {
            public int count { get; set; }
            public IList<Results> results { get; set; }

        }
    }
}