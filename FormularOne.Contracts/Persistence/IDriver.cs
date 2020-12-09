namespace FormularOne.Contracts.Persistence
{
    public interface IDriver : IIdentifiable
    {
        public string Name { get; set; }
        public int TeamId { get; set; }
    }
}
