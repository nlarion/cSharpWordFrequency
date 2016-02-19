using Nancy;
using System.Collections.Generic;
using System;
using System.Web;
using System.Linq;

namespace WordFrequency
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      Post["/results"] = _ => {
        int returnInt = RepeatCounter.CountRepeats(Request.Form["sentence"], Request.Form["userWord"]);
        return View["results.cshtml", returnInt];
      };
    }
  }
}
