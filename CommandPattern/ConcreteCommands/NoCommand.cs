using CommandPattern.Command;
using Common.Interfaces;

namespace CommandPattern.ConcreteCommands
{
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}
