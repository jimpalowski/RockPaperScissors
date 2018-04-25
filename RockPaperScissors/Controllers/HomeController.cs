using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using RockPaperScissor.Models;

namespace RockPaperScissorController
{
  public class HomeController : Controller
  {

      [HttpGet("/")]
      public ActionResult Index()
      {
      return View("Index");
      }
      [HttpGet("player1")]
      public ActionResult Player1()
      {
        return View("player1");
      }
      [HttpPost("/p1Rock")]
      public ActionResult Player1Rock()
      {
        string p1choice = "rock";
        return View("player2", p1choice);
      }
      [HttpPost("/p1Paper")]
      public ActionResult Player1Paper()
      {
        string p1choice = "paper";
        return View("player2", p1choice);
      }
      [HttpPost("/p1Scissors")]
      public ActionResult Player1Scissor()
      {
        string p1choice = "scissors";
        return View("player2", p1choice);
      }
      [HttpPost("/p2Rock")]
      public ActionResult Player2Rock()
      {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "rock";
        Game game = new Game(p1choice, p2choice);
        return View("result", game.Play());
      }
      [HttpPost("/p2Paper")]
      public ActionResult Player2Paper()
      {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "paper";
        Game game = new Game(p1choice, p2choice);
        return View("result", game.Play());
      }
      [HttpPost("/p2Scissors")]
      public ActionResult Player2Scissor()
      {
        string p1choice = Request.Form["p1choice"];
        string p2choice = "scissors";
        Game game = new Game(p1choice, p2choice);
        return View("result", game.Play());
      }
    }
  }

  
