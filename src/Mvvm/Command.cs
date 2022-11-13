using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm
{
    internal class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        internal required Action ExecuteAction { get; init; }
        internal required Func<bool> CanExecuteFunc { get; init; }

        public bool CanExecute(object? parameter) => CanExecuteFunc.Invoke();
        public void Execute(object? parameter) => ExecuteAction.Invoke();
        internal void InvokeCanExecuteChanged(object sender) => CanExecuteChanged?.Invoke(sender, new EventArgs());
    }
}
