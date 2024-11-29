using CQRS.Core.Events;

namespace Product.Cmd.Api.Events
{
    public class UpdatedProductEvent : BaseEvent
    {
        public UpdatedProductEvent() : base(nameof(UpdatedProductEvent))
        {
        }
        public string Description { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
