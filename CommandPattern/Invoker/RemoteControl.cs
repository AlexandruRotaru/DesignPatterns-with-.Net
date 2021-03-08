using CommandPattern.Command;
using CommandPattern.ConcreteCommands;
using Common.Interfaces;

namespace CommandPattern.Invoker
{
    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;
        private readonly int numberOfCommands = 7;
        private readonly IView view;

        public RemoteControl(IView view)
        {
            this.view = view;            

            onCommands = new ICommand[numberOfCommands];
            offCommands = new ICommand[numberOfCommands];

            ICommand noCommand = new NoCommand();
            undoCommand = noCommand;

            for (int i = 00; i < numberOfCommands; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoPusshed()
        {
            undoCommand.Undo();
        }

        public void DisplayButtons()
        {
            view.DisplayMessage("--------- Remote Control ----------");
            view.DisplayMessage(string.Empty);

            for (int i = 00; i < numberOfCommands; i++)
            {
                view.DisplayMessage($"[slot {i + 1}] {onCommands[i].GetType().Name}  {offCommands[i].GetType().Name}");
            }
        }
    }
}
