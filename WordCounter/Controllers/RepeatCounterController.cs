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


    [HttpPost("/words/result")]
    public ActionResult Result(string word, string sentence)
    {
    RepeatCounter newCount = new RepeatCounter(word, sentence);
    return View(newCount);
    }
  }

}
