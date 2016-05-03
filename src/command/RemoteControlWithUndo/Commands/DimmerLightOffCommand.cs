using RemoteControlWithUndo.Commands;
using RemoteControlWithUndo.Receivers;

namespace RemoteControlWithUndo.Commands
{
    public class DimmerLightOffCommand : ICommand
    {
        private readonly Light _light;
        private int _prevLevel;

        public DimmerLightOffCommand(Light light)
        {
            _light = light;
            _prevLevel = 100;
        }

        public void Execute()
        {
            _prevLevel = _light.GetLevel();
            _light.Off();
        }

        public void Undo() => _light.Dim(_prevLevel);
    }
}