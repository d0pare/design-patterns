using RemoteControlWithUndo.Commands;
using RemoteControlWithUndo.Receivers;

namespace RemoteControlWithUndo.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        private int _level;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _level = _light.GetLevel();
            _light.On();
        }

        public void Undo() => _light.Dim(_level);
    }
}