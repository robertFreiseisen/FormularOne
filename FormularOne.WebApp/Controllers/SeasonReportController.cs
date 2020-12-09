using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FormularOne.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeasonReportController : ControllerBase
    {
        [HttpGet("DriverResults")]
        public IEnumerable<Contracts.Report.Season.IDriverResultReport> GetDriverResults()
        {
            return Report.SeasonReports.GetDriverResultReports();
        }

        [HttpGet("TeamResults")]
        public IEnumerable<Contracts.Report.Season.ITeamResultReport> GetTeamResultReports()
        {
            return Report.SeasonReports.GetTeamResultReports();
        }
    }
}
