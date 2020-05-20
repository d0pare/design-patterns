using Party.Receivers;

namespace Party.Commands
{
    public class HottubOnCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.On();
            _hottub.SetTemperature(104);
            _hottub.Circulate();
        }

        public void Undo() => _hottub.Off();
    }
}