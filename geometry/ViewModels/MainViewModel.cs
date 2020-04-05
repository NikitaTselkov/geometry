using GalaSoft.MvvmLight;
using geometry.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            this.PageNavigate = new PageNavigate(this);

            this.SimpleCommand = new SimpleCommand(this);
        }

    }
}
