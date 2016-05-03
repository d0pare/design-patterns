using System;

namespace HomeTheater
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly Screen _screen;
        private readonly TheaterLights _theaterLights;
        private readonly PopcornPopper _popcornPopper;

        public HomeTheaterFacade(Amplifier amplifier,
                                 Tuner tuner,
                                 DvdPlayer dvdPlayer,
                                 CdPlayer cdPlayer,
                                 Projector projector,
                                 Screen screen,
                                 TheaterLights theaterLights,
                                 PopcornPopper popcornPopper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _screen = screen;
            _theaterLights = theaterLights;
            _popcornPopper = popcornPopper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popcornPopper.Off();
            _theaterLights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }

        public void ListenToCd(string cdTitle)
        {
            Console.WriteLine("Get ready for an audiopile experience...");
            _theaterLights.On();
            _amplifier.On();
            _amplifier.SetVolume(5);
            _amplifier.SetCd(_cdPlayer);
            _amplifier.SetStereoSound();
            _cdPlayer.On();
            _cdPlayer.Play(cdTitle);
        }

        public void EndCd()
        {
            Console.WriteLine("Shutting down CD...");
            _amplifier.Off();
            _amplifier.SetCd(_cdPlayer);
            _cdPlayer.Eject();
            _cdPlayer.Off();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            _tuner.On();
            _tuner.SetFrequency(frequency);
            _amplifier.On();
            _amplifier.SetVolume(5);
            _amplifier.SetTuner(_tuner);
        }

        public void EndRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            _tuner.Off();
            _amplifier.Off();
        }
    }
}