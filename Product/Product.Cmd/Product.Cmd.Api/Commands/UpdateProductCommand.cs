using CQRS.Core.Commands;

namespace Product.Cmd.Api.Commands
{
    public class UpdateProductCommand : BaseCommand
    {
        public string Description { get; set; }

    }
}
