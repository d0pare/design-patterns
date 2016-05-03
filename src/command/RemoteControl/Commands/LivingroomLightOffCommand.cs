using RemoteControl.Commands;
using RemoteControl.Receivers;

namespace RemoteControl.Commands
{
    public class LivingroomLightOffCommand : ICommand
    {
        private readonly Light _light;

        public LivingroomLightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.Off();
    }
}