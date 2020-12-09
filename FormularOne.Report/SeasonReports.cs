using System.Collections.Generic;
using FormularOne.Contracts.Persistence;
using System.Linq;
using FormularOne.Report.Season;

namespace FormularOne.Report
{
    public class SeasonReports
    {
        public static IEnumerable<Contracts.Report.Season.IDriverResultReport> GetDriverResultReports()
        {
            IEnumerable<IDriver> drivers = FormularOne.Logic.Factory.GetAllDrivers();
            IEnumerable<IDriverResult> results = Logic.Factory.GetAllDriverResults();

            var driverResults = (from d in drivers
                                 join r in results on d.Id equals r.DriverId into list
                                 orderby list.Sum(s => s.Points) descending
                                 select new DriverResultReport
                                 {
                                     Driver = d.Name,
                                     Points = list.Sum(s => s.Points)

                                 }).Take(3);

            return driverResults;
        }

        public static IEnumerable<Contracts.Report.Season.ITeamResultReport> GetTeamResultReports()
        {
            IEnumerable<IDriver> drivers = Logic.Factory.GetAllDrivers();
            IEnumerable<ITeam> teams = Logic.Factory.GetAllTeams();
            IEnumerable<IDriverResult> results = Logic.Factory.GetAllDriverResults();

            var teamResults = (from d in drivers
                               join r in results on d.Id equals r.DriverId
                               group r by d.TeamId into teamGroup
                               orderby teamGroup.Sum(s => s.Points) descending
                               select new TeamResultReport
                               {
                                   Team = teams.ToList().Find(t => teamGroup.Key == t.Id).Name,
                                   Points = teamGroup.Sum(s => s.Points)

                               }).Take(3);

            return teamResults;
        }
    }
}
