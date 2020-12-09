using CsvMapper.Logic.Attributes;

namespace FormularOne.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Race.csv")]
    internal class Race : IdentityObject, Contracts.Persistence.IRace
    {
        [DataPropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
    }
}
