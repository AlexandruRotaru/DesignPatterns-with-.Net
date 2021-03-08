using CommandPattern.Command;
using CommandPattern.Receivers;

namespace CommandPattern.ConcreteCommands
{
    public class StereoWithCDCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
