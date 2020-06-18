using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace starWarsApi.Controllers
{
    public class CharacterController : Controller
    {
		//If CharacterList gets cached, 'Next' and 'Previous' links doesnt work
		public ActionResult CharacterList(string link)
		{
			Models.CharactersModel.Application objJson;

			if (link == null)
			{
				var webClient = new WebClient();
				var json = webClient.DownloadString(@"https://swapi.dev/api/people/");
				objJson = JsonConvert.DeserializeObject<Models.CharactersModel.Application>(json);

				return View(objJson);
			}
			else
			{
				var webClient = new WebClient();
				var json = webClient.DownloadString(link);
				objJson = JsonConvert.DeserializeObject<Models.CharactersModel.Application>(json);

				return View(objJson);
			}

		}

		[OutputCache(Duration = 600, VaryByParam = "link")]
		public ActionResult SelectedCharacter(string link)
		{
			var webClient = new WebClient();
			var json = webClient.DownloadString(link);
			Models.CharactersModel.Results objJson = JsonConvert.DeserializeObject<Models.CharactersModel.Results>(json);

			return View(objJson);
		}

		public ActionResult CharacterSearch(string searchName)
		{
			int characterPages = 9;
			List<Tuple<string, string>> searchList = new List<Tuple<string, string>>(); 
			var webClient = new WebClient();

			if (!searchName.IsNullOrWhiteSpace())
			{
				for (int i = 1; i <= characterPages; i++)
				{
					var json = webClient.DownloadString(@"https://swapi.dev/api/people/?page=" + i.ToString());
					Models.CharactersModel.Application objJson = JsonConvert.DeserializeObject<Models.CharactersModel.Application>(json);

					foreach (var item in objJson.results)
					{
						string name = item.name;
						if (name.ToLower().Contains(searchName.ToLower()))
						{
							searchList.Add(new Tuple<string, string>(name, item.url.ToString()));
						}
					}
				}
			}
			else
				return Redirect(Request.UrlReferrer.ToString()); 
			
			return View(searchList);
		}


	}
}