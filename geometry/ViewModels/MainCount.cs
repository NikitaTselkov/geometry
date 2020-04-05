using geometry.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry.ViewModels
{
    public class MainCount : ViewModelBase
    {

        public MainCount()
        {
            this.GoToSetV = new GoToSetV(this);
        }

    }
}
