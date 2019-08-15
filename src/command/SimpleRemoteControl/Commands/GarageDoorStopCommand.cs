using SimpleRemoteControl.Receivers;

namespace SimpleRemoteControl.Commands
{
    public class GarageDoorStopCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorStopCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute() => _garageDoor.Stop();
    }
}
