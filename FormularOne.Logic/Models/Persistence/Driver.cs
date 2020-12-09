using CsvMapper.Logic.Attributes;

namespace FormularOne.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Driver.csv")]
    internal class Driver : IdentityObject, Contracts.Persistence.IDriver
    {
        [DataPropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]
        public int TeamId { get; set; }
    }
}
