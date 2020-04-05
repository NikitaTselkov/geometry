using geometry.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry.ViewModels
{
    public class ViewModelBase : Navigation.NavigateViewModel
    {
        public SimpleCommand SimpleCommand { get; set; }

        public PageNavigate PageNavigate { get; set; }

        public GoToSetV GoToSetV { get; set; } 




        public void GoToSetValue()
        {
            NavigateSetData("Views/SetDataValue.xaml");
        }

        public void GoToCount()
        {
            Navigate("Views/Count.xaml");
        }

        public void GoToFigures()
        {
            Navigate("Views/SelectShape.xaml");
        }

    }
}
