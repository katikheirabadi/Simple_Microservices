using CQRS.Core.Events;

namespace Product.Cmd.Api.Events
{
    public class DeletedProductEvent : BaseEvent
    {
        public DeletedProductEvent() : base(nameof(DeletedProductEvent))
        {
        }
        public Guid ProductId { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}
