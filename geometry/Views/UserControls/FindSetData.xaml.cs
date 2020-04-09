using Caliburn.Micro;
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
    /// Логика взаимодействия для FindSetData.xaml
    /// </summary>
    public partial class FindSetData : UserControl
    {
        //public BindableCollection

        public FindSetData()
        {
            InitializeComponent();

            DataContext = this;

        }

        public int _IsPressed { get; set; }


        public bool IsPressedFind
        {
            get { return (bool)GetValue(IsPressedProperty); }
            set { SetValue(IsPressedProperty, value); }
        }

        public static readonly DependencyProperty IsPressedProperty =
            DependencyProperty.Register("IsPressedFind", typeof(bool), typeof(FindSetData), new PropertyMetadata(false, new PropertyChangedCallback(CurrentNumberChanged)));


        private static void CurrentNumberChanged(DependencyObject depObj,
           DependencyPropertyChangedEventArgs args)
        {

            FindSetData s = (FindSetData)depObj;
            int ISP = s._IsPressed;
            Visibility V = s.Visibility;

            if ((bool)args.NewValue == true)
            {
                ISP += 1;
                s._IsPressed = ISP;

                if (ISP % 2 == 0)
                {
                    V = Visibility.Collapsed;
                }
                else
                {
                    V = Visibility.Visible;
                }

                s.Visibility = V;
            }
        }



    }
}
