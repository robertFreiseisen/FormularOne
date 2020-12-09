using System;
using System.Collections.Generic;
using System.Text;

namespace FormularOne.Contracts.Report.Season
{
    public interface IDriverResultReport
    {
        public string Driver { get; set; }
        public int Points { get; set; }
    }
}
