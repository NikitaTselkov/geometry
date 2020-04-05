using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry.Navigation
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ViewModels.MainViewModel>();

            SimpleIoc.Default.Register<ViewModels.MainCount>();

        }

        public ViewModels.MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ViewModels.MainViewModel>();
            }
        }

        public ViewModels.MainCount Count
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ViewModels.MainCount>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
