﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace geometry.ViewModels.Commands
{
    public class PageNavigate : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public PageNavigate(ViewModelBase viewModel)
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
            this.ViewModel.GoToCube();
        }
    }
}
