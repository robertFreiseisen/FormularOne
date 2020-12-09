namespace FormularOne.Contracts.Persistence
{
    public interface IDriverResult
    {
        public int DriverId { get; set; }
        public int Place { get; set; }
        public int RaceId { get; set; }
        public char Wheel { get; set; }
        public int Rounds { get; set; }
        public string Time { get; set; }
        public int Points { get; set; }
        public int StartNumber { get; set; }
        public string Residue { get; set; }
    }
}
