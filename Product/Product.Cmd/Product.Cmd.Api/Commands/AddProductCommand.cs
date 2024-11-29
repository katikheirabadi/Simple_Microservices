using CQRS.Core.Commands;

namespace Product.Cmd.Api.Commands
{
    public class AddProductCommand : BaseCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
