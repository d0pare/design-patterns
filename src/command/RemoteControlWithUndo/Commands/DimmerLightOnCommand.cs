using RemoteControlWithUndo.Commands;
using RemoteControlWithUndo.Receivers;

namespace RemoteControlWithUndo.Commands
{
    public class DimmerLightOnCommand : ICommand
    {
        private readonly Light _light;
        private int _prevLevel;

        public DimmerLightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _prevLevel = _light.GetLevel();
            _light.Dim(75);
        }

        public void Undo() => _light.Dim(_prevLevel);
    }
}