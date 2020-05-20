using SimpleRemoteControl.Receivers;

namespace SimpleRemoteControl.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.Off();
    }
}