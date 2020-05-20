namespace Party.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}