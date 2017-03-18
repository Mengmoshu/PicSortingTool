using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PicSortingTool {
    class Command : ICommand {
        // Constructor(s)
        public Command(Action<Object> doThis) {
            ExecCommand = doThis;
        }

        // Interface Handlers
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) { return true; }

        public void Execute(object parameter) {
            if(ExecCommand != null) {
                ExecCommand(parameter);
            }
        }

        // Fields
        Action<object> ExecCommand;
    }
}
