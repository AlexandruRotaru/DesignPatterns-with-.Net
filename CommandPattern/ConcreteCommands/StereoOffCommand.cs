using CommandPattern.Command;
using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.ConcreteCommands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}
