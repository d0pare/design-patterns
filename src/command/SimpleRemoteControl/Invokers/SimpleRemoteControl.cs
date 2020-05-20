using SimpleRemoteControl.Commands;

namespace SimpleRemoteControl.Invokers
{
    //This is our invoker
    public class SimpleRemoteControl
    {
        private ICommand _slot;

        public void SetCommand(ICommand command) => _slot = command;

        public void ButtonWasPressed() => _slot.Execute();
    }
}