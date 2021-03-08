using CommandPattern.Command;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands
{
    public class LightsOffCommand : ICommand
    {
        private readonly Light light;

        public LightsOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
