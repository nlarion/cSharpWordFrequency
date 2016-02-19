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

        RepeatCounter repeatCounter = new RepeatCounter(Request.Form["sentence"], Request.Form["userWord"]);
        return View["results.cshtml", repeatCounter.CountRepeats()];
      };
    }
  }
}