using Common.Interfaces;
using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier amplifier;
        private readonly BlueRayPlayer blueRay;
        private readonly Projector projector;
        private readonly TheaterLights lights;
        private readonly Screen screen;
        private readonly PopcornPopper popper;
        private readonly IView view;
        
        public HomeTheaterFacade(Amplifier amplifier, BlueRayPlayer blueRay, Projector projector,
            TheaterLights lights, Screen screen , PopcornPopper popper, IView view)
        {
            this.amplifier = amplifier;
            this.blueRay = blueRay;
            this.projector = projector; 
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
            this.view = view;
        }

        public void WatchMovie(string movie)
        {
            view.DisplayMessage("Getting ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projector.On();
            amplifier.On();
            amplifier.SetSource(blueRay);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);
            blueRay.On();
            blueRay.Play(movie);
        }

        public void EndMovie()
        {
            view.DisplayMessage("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amplifier.Off();
            blueRay.Stop();
            blueRay.Eject();
            blueRay.Off();
        }
    }
}
