using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class StereoOnWithDVDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithDVDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetDVD();
            _stereo.SetVolume(15);
        }
    }
}
