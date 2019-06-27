using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Football.Models;
using Microsoft.EntityFrameworkCore;

namespace Football.Controllers
{
    public class HomeController : Controller
    {
        private readonly PremierLeagueDbContext _dbContext;

        public HomeController(PremierLeagueDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult AllTeams()
        {
            var allTeams = _dbContext.Teams
                .Include(x => x.Trainer)
                .Include(x => x.Players)
                .ToList();

            return View(allTeams);
        }

    


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
