namespace RemoteControlWithUndo.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}