using FormularOne.Logic.Models.Persistence;
using System.Collections.Generic;

namespace FormularOne.Logic
{
    public class Factory
    {
        public static IEnumerable<Contracts.Persistence.IDriver> GetAllDrivers()
        {

            return CsvMapper.Logic.CsvHelper.Read<Driver>();
        }
        
        public static IEnumerable<Contracts.Persistence.IDriverResult> GetAllDriverResults()
        {
            return CsvMapper.Logic.CsvHelper.Read<DriverResult>();
        }

        public static IEnumerable<Contracts.Persistence.IRace> GetAllRaces()
        {
            return CsvMapper.Logic.CsvHelper.Read<Race>();
        }

        public static IEnumerable<Contracts.Persistence.ITeam> GetAllTeams()
        {
            return CsvMapper.Logic.CsvHelper.Read<Team>();
        }
    }
}
