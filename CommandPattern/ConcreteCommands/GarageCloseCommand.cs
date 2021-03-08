using CommandPattern.Command;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands
{
    public class GarageCloseCommand : ICommand
    {
        private readonly Garage garage;

        public GarageCloseCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.Close();
        }

        public void Undo()
        {
            garage.Open();
        }
    }
}
