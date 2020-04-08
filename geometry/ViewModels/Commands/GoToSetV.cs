using System;
using System.Windows.Input;

namespace geometry.ViewModels.Commands
{
    public class GoToSetV : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public GoToSetV(ViewModelBase viewModel)
        {
            this.ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.GoToSetValue();
        }
    }
}
