using System;
using System.Collections.Generic;
using System.Text;
using CsvMapper.Logic.Attributes;

namespace FormularOne.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Team.csv")]
    internal class Team : IdentityObject, Contracts.Persistence.ITeam
    {
        [DataPropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
    }
}
