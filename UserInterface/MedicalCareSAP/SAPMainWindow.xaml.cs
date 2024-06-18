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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserInterface.Custom_Animation;

namespace UserInterface.MedicalCareSAP
{
    /// <summary>
    /// Interaction logic for SAPMainWindow.xaml
    /// </summary>
    public partial class SAPMainWindow : Window
    {
        public SAPMainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridLengthAnimation animation = new GridLengthAnimation
            {
                From = new GridLength(250, GridUnitType.Pixel),
                To = new GridLength(500, GridUnitType.Pixel),
                CustomGridUnitType = GridUnitType.Pixel,
                Duration = new Duration(TimeSpan.FromSeconds(20))
            };

            column1.BeginAnimation(ColumnDefinition.WidthProperty, animation);
        }
    }
}
