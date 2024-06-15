using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace UserInterface.Custom_Controls
{
    /// <summary>
    /// Interaction logic for QualificationCustomControl.xaml
    /// </summary>
    public partial class QualificationCustomControl : UserControl
    {
        public QualificationCustomControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event EventHandler QualificationDelete;

        public Brush CustomBackground
        {
            get { return (Brush)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomBackgroundProperty =
            DependencyProperty.Register("CustomBackground", typeof(Brush), typeof(QualificationCustomControl), new PropertyMetadata(new SolidColorBrush(Colors.AliceBlue)));

        private void OnDeleteLabelClicked(object sender, MouseButtonEventArgs e)
        {
            QualificationDelete?.Invoke(this, EventArgs.Empty);
        }
    }

    public class QualificationControlWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return val - (val / 16) - 20;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return val + (val / 15);
            }

            return 0;
        }
    }
}
