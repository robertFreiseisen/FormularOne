namespace FormularOne.Report.Season
{
    internal class TeamResultReport : Contracts.Report.Season.ITeamResultReport
    { 
        public string Team { get; set; }
        public int Points { get; set; }
    }
}
