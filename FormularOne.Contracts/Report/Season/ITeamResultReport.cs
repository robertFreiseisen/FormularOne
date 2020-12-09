using System;
using System.Collections.Generic;
using System.Text;

namespace FormularOne.Contracts.Report.Season
{
    public interface ITeamResultReport
    {
        public string Team { get; set; }
        public int Points { get; set; }
    }
}
