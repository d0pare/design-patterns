using System.Text;
using RemoteControlWithUndo.Commands;

namespace RemoteControlWithUndo.Invokers
{
    //
    // This is the invoker
    //
    public class RemoteControlWithUndo
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;
        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = new NoCommand();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed() => _undoCommand.Undo();

        public override string ToString()
        {
            var stringBuilder= new StringBuilder();
            stringBuilder.Append("\n------ Remote Control -------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + _onCommands[i].GetType().Name + "    " + _offCommands[i].GetType().Name + "\n");
            }

            stringBuilder.Append("[undo] " + _undoCommand.GetType().Name + "\n");

            return stringBuilder.ToString();
        }
    }
}