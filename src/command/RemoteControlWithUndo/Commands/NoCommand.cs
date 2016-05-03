using RemoteControlWithUndo.Commands;

namespace RemoteControlWithUndo.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() {}
        public void Undo() {}
    }
}