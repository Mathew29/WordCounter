using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/counter")]
    public ActionResult Index()
    {
      List<Counter> allCounters = Counter.GetAll();
      return View(allCounters);
    }

    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/counter")]
     public ActionResult Create(string newKeyWord, string newSentence)
    {
      Counter newCounter = new Counter(newKeyWord, newSentence);
      return View("Show", newCounter);
    }

    [HttpGet("counter/{id}")]
    public ActionResult Show(int id)
    {
      Counter count = Counter.Find(id);
      return View(count);
    }

    [HttpPost("/counter/delete")]
    public ActionResult DeleteAll()
    {
      Counter.ClearAll();
      return View();
    }
  }
}
