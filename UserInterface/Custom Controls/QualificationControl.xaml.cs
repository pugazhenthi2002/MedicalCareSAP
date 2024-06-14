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
    /// Interaction logic for Qualification.xaml
    /// </summary>
    public partial class QualificationControl : UserControl
    {
        public QualificationControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event EventHandler QualificationDelete;

        #region

        public double CustomBorderRadius
        {
            get { return (double)GetValue(CustomBorderRadiusProperty); }
            set { SetValue(CustomBorderRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBorderRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomBorderRadiusProperty =
            DependencyProperty.Register("CustomBorderRadius", typeof(double), typeof(QualificationControl), new PropertyMetadata());

        public Brush CustomBackground
        {
            get { return (Brush)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomBackgroundProperty =
            DependencyProperty.Register("CustomBackground", typeof(Brush), typeof(QualificationControl), new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        public Brush CustomForeground
        {
            get { return (Brush)GetValue(CustomForegroundProperty); }
            set { SetValue(CustomForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomForegroundProperty =
            DependencyProperty.Register("CustomForeground", typeof(Brush), typeof(QualificationControl), new PropertyMetadata(new SolidColorBrush(Colors.White)));

        #endregion

        private void OnDeleteLabelClicked(object sender, MouseButtonEventArgs e)
        {
            QualificationDelete?.Invoke(this, EventArgs.Empty);
        }
    }

    public class BorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter != null && parameter is QualificationControl control1)
            {
                int widthOffset = (int)(control1.Margin.Right + control1.Padding.Right + control1.Margin.Left + control1.Padding.Left);
                int heightOffset = (int)(control1.Margin.Top + control1.Padding.Top + control1.Margin.Bottom + control1.Padding.Bottom);
                return new Rect(0, 0, control1.Width, control1.Height);
            }

            if (parameter != null && parameter is AddEducationDetails control2)
            {
                return new Rect(0, 0, control2.Width - (control2.Padding.Left + control2.Padding.Right), control2.AddQualificationHeight - (control2.Padding.Top + control2.Padding.Bottom));
            }

            return new Rect(0, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is Rect rec)
            {
                return rec.Height;
            }

            return 0;
        }
    }

    public class QualificationWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return val - (val / 16) - 5;
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

    public class HeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return (val - 40) / 2;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return (val * 2 + 40);
            }

            return 0;
        }
    }

    public class AnimatedWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return (val - 100 - (val / 16)) / 3;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double val)
            {
                return (val * 3 + 90);
            }

            return 0;
        }
    }
}
