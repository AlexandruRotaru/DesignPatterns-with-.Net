using Common.Interfaces;
using System;

namespace Common
{
    public class View : IView
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }
}
