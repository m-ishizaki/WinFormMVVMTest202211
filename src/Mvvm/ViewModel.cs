using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        bool SetProperty<T>(ref T prop, T value, [CallerMemberName] string? name = null)
        {
            if (object.Equals(prop, value)) return false;
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            ((Command)Command).InvokeCanExecuteChanged(this);
            return true;
        }

        public int? Num1 { get => _num1; set { if (SetProperty(ref _num1, value)) Add(); } } int? _num1;
        public int? Num2 { get => _num2; set { if (SetProperty(ref _num2, value)) Add(); } } int? _num2;
        public int? Num3 { get => _num3; set => SetProperty(ref _num3, value); } int? _num3;
        public ICommand Command { get; init; }

        void Add() => Num3 = Num1 + Num2;

        public ViewModel() => (Command) = (new Command { ExecuteAction = () => (Num1, Num2) = (0, 0), CanExecuteFunc = () => (Num1, Num2) != (0, 0) });
    }
}
