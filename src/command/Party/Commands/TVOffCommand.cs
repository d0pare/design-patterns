using Party.Receivers;

namespace Party.Commands
{
    public class TVOffCommand : ICommand
    {
        private readonly TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute() => _tv.Off();

        public void Undo() => _tv.On();
    }
}