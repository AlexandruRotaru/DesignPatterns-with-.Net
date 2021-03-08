using CommandPattern.Command;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands
{
    public class GarageOpenCommand : ICommand
    {
        private readonly Garage garage;

        public GarageOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.Open();
        }
        public void Undo()
        {
            garage.Close();
        }
    }
}
