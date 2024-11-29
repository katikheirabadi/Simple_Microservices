using CQRS.Core.Events;

namespace Product.Cmd.Api.Events
{
    public class AddedProductEvent : BaseEvent
    {
        public AddedProductEvent() : base(nameof(AddedProductEvent))
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddDate { get; set; }
    }
}
