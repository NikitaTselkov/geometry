using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace geometry.Views.UserControls
{
    /// <summary>
    /// Логика взаимодействия для SetData.xaml
    /// </summary>
    public partial class SetData : UserControl
    {
        public SetData()
        {
            InitializeComponent();

            NavigationSetup();
        }

        void NavigationSetup()
        {
            Messenger.Default.Register<Navigation.NavigateArgsSetData>(this, (x) =>
            {
                FrameSetData.Navigate(new Uri(x.Url, UriKind.Relative));
            });
        }

    }
}
