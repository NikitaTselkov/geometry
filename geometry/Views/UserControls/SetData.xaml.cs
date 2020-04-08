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

            DataContext = this;


        }

        public int _IsPressed { get; set; }


        public bool IsPressed
        {
            get { return (bool)GetValue(IsPressedProperty); }
            set { SetValue(IsPressedProperty, value); }
        }

        public static readonly DependencyProperty IsPressedProperty =
            DependencyProperty.Register("IsPressed", typeof(bool), typeof(SetData), new PropertyMetadata(false, new PropertyChangedCallback(CurrentNumberChanged)));


        private static void CurrentNumberChanged(DependencyObject depObj,
           DependencyPropertyChangedEventArgs args)
        {

            SetData s = (SetData)depObj;
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


        public double ValueNum
        {
            get { return (double)GetValue(ValueNumProperty); }
            set { SetValue(ValueNumProperty, value); }
        }

        public static readonly DependencyProperty ValueNumProperty =
            DependencyProperty.Register("ValueNum", typeof(double), typeof(SetData), new PropertyMetadata(0.0));



        public string Straight
        {
            get { return (string)GetValue(StraightProperty); }
            set { SetValue(StraightProperty, value); }
        }

        public static readonly DependencyProperty StraightProperty =
            DependencyProperty.Register("Straight", typeof(string), typeof(SetData), new PropertyMetadata(string.Empty));


    }
}
