using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class RepeatCounterController : Controller
  {
    [HttpGet("words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/words/create")]
    public ActionResult Create()
    {
      RepeatCounter newCount = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
      int result = newCount.CountWords();
      newCount.SetCount(result);
      return View("Index", newCount);
    }
  }

}
