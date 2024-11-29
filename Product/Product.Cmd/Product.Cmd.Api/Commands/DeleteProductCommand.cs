using CQRS.Core.Commands;

namespace Product.Cmd.Api.Commands
{
    public class DeleteProductCommand : BaseCommand
    {
        public Guid ProductId { get; set; }
    }
}
