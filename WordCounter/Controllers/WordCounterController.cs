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
      return View();
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}
