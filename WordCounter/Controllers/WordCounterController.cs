using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index(string newKeyWord, string newSentence)
    {
      Words myWords = new Words(newKeyWord, newSentence);
      return View(myWords);
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
