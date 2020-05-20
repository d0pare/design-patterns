using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class LivingroomLightOnCommand : ICommand
    {
        private readonly Light _light;

        public LivingroomLightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.On();
    }
}