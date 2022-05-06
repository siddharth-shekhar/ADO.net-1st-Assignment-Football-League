using football.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace football.Controllers
{
    public class FootballLeagueController : Controller
{
    // GET: FootBallLeague
    public ActionResult Index()
    {
        FootBallLeagueContext league = new FootBallLeagueContext();
        List<FootBallLeague> ll = league.FootBallLeagues.ToList();
        return View(ll);
    }
}
}