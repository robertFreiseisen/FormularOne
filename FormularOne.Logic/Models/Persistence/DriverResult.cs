using CsvMapper.Logic.Attributes;

namespace FormularOne.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/DriverResult.csv")]
    internal class DriverResult : Contracts.Persistence.IDriverResult
    {
        [DataPropertyInfo(OrderPosition = 1)]
        public int DriverId { get; set; }
        [DataPropertyInfo(OrderPosition = 2)]
        public int RaceId { get; set; }
        [DataPropertyInfo(OrderPosition = 3)]
        public char Wheel { get; set; }
        [DataPropertyInfo(OrderPosition = 6)]
        public int Rounds { get; set; }
        [DataPropertyInfo(OrderPosition = 4)]
        public string Time { get; set; }
        [DataPropertyInfo(OrderPosition = 7)]
        public int Points { get; set; }
        public int StartNumber { get; set; }
        [DataPropertyInfo(OrderPosition = 5)]
        public string Residue { get; set; }
        [DataPropertyInfo(OrderPosition = 0)]
        public int Place { get; set; }
    }
}
