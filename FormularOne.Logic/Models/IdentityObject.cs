using CsvMapper.Logic.Attributes;

namespace FormularOne.Logic.Models
{
    class IdentityObject : FormularOne.Contracts.IIdentifiable
    {
        [DataPropertyInfo(OrderPosition = 0)]
        public int Id { get; set; }
    }
}
