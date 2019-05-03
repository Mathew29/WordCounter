using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index()
    {
      List<Words> allWords = Words.GetAll();
      return View();
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult New()
    {
      return View();
    }
    //
    [HttpPost("/wordcounters")]
    public ActionResult Create(string keyWord, string userSentence)
    {
      Words myWord = new Words(keyWord, userSentence);
      return RedirectToAction("Index");
    }
    //
    [HttpGet("/wordcounters/{id}")]
    public ActionResult Show(int id)
    {
      Words word = Words.Find(id);
      return View(word);
    }
    //
    // [HttpGet("/wordcounters/delete")]
    // public ActionResult DeleteAll()
    // {
    //   WordCounter.ClearAll();
    //   return View();
    // }

  }
}
