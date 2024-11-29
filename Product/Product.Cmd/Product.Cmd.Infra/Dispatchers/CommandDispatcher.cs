using CQRS.Core.Commands;
using CQRS.Core.Infrastructuore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Cmd.Infra.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        // hold all command handling methods delegate
        // type : type of command handler == command type
        // Func<BaseCommand, Task> : the metod of commmand handler
        private readonly Dictionary<Type, Func<BaseCommand, Task>> _handlers = new();

        public void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand
        {
            if(_handlers.ContainsKey(typeof(T)))
            {
                throw new IndexOutOfRangeException("You can not register the same command handler twice!!!!!");
            }
            _handlers.Add(typeof(T), x => handler((T)x));
        }

        public async Task SendAsync(BaseCommand command)
        {
            if (_handlers.TryGetValue(command.GetType(), out Func<BaseCommand, Task> handler)) await handler(command);
            else throw new ArgumentException(nameof(handler), "No command handler was registerd!!!!");
        }
    }
}
