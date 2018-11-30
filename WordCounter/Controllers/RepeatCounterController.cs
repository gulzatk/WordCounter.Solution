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
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      return RedirectToAction("Index");
    }
  }

}
