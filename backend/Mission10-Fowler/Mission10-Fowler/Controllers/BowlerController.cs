using Microsoft.AspNetCore.Mvc;
using Mission10_Fowler.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Fowler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlerController : ControllerBase
    {
        private readonly BowlingLeagueContext _bowlerContext;

        public BowlerController(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        // GET
        [HttpGet(Name = "GetBowler")]
        public IEnumerable<object> Get()
        {
            var bowlerList = _bowlerContext.Bowlers
                .Where(b => b.TeamId == 1 || b.TeamId == 2)
                .Include(b => b.Team) 
                .Select(b => new 
                {
                    b.BowlerId,
                    b.BowlerLastName,
                    b.BowlerFirstName,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber,
                    b.TeamId,
                    Team = b.Team.TeamName 
                }).ToList();
            
            return bowlerList;
        }
    }
}