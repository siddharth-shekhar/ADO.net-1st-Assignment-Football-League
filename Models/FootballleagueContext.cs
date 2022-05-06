using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace football.Models
{
    public class FootBallLeagueContext : DbContext
    {
        public DbSet<FootBallLeague> FootBallLeagues { get; set; }
    }
}