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
      return View();
    }

    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/counter")]
     public ActionResult Create(string keyWord, string userSentence)
    {
      Counter newCounter = new Counter(keyWord, userSentence);
      return RedirectToAction("Index", newCounter);
    }

    [HttpGet("counter/{id}")]
    public ActionResult Show(int id)
    {
      Counter count = Counter.Find(id);
      return View(count);
    }

    // [HttpPost("/counter/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Counter.Clear();
    //   return View();
    // }
  }
}
