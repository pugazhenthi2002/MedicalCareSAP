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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DS;
using UserInterface.Theme;

namespace UserInterface.User_Controls
{
    /// <summary>
    /// Interaction logic for AddEducationDetails.xaml
    /// </summary>
    public partial class AddEducationDetails : UserControl
    {
        public AddEducationDetails()
        {
            InitializeComponent();

            DataContext = this;
            Loaded += AddEducationDetails_Loaded;
        }

        #region


        public Brush CustomBackground
        {
            get { return (Brush)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomBackgroundProperty =
            DependencyProperty.Register("CustomBackground", typeof(Brush), typeof(AddEducationDetails), new PropertyMetadata(new SolidColorBrush(Colors.White)));


        public double ChildQualificationHeight
        {
            get { return (double)GetValue(ChildQualificationHeightProperty); }
            set { SetValue(ChildQualificationHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildQualificationHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChildQualificationHeightProperty =
            DependencyProperty.Register("ChildQualificationHeight", typeof(double), typeof(AddEducationDetails), new PropertyMetadata(100.0));


        public double AddQualificationHeight
        {
            get { return (double)GetValue(AddQualificationHeightProperty); }
            set { SetValue(AddQualificationHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChildQualificationHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddQualificationHeightProperty =
            DependencyProperty.Register("AddQualificationHeight", typeof(double), typeof(AddEducationDetails), new PropertyMetadata(50.0));



        #endregion

        private void AddEducationDetails_Loaded(object sender, RoutedEventArgs e)
        {
            Height = AddQualificationHeight + (Padding.Top + Padding.Bottom);
        }

        private void OnAddEducation(object sender, MouseButtonEventArgs e)
        {
            var themeResourceDictionary = new ResourceDictionary();
            var fontResourceDictionary = new ResourceDictionary();

            fontResourceDictionary.Source = new Uri("Theme/Font.xaml", UriKind.Relative);

            if (ThemeManager.CurrentTheme == Theme.Theme.Summer)
            {
                themeResourceDictionary.Source = new Uri("Theme/Summer.xaml", UriKind.Relative);
            }
            else
            {
                themeResourceDictionary.Source = new Uri("Theme/Winter.xaml", UriKind.Relative);
            }

            FontFamily fontFamily = new FontFamily("Arial");
            if (fontResourceDictionary.Contains("ApplicationFont"))
            {
                fontFamily = (FontFamily)fontResourceDictionary["ApplicationFont"];
            }

            Brush background = new SolidColorBrush(Colors.White), foreground = new SolidColorBrush(Colors.Black);

            if (themeResourceDictionary.Contains("PrimaryI"))
            {
                foreground = (Brush)themeResourceDictionary["PrimaryI"];
            }
            if (themeResourceDictionary.Contains("SecondaryII"))
            {
                background = (Brush)themeResourceDictionary["SecondaryII"];
            }
            Thickness margin = new Thickness(15);
            QualificationCustomControl control = new QualificationCustomControl()
            {
                Margin = margin,
                Opacity = 0,
                Width = this.Width - Padding.Left - Padding.Right - 30,
                CustomBackground = background,
                Foreground = foreground,
                FontFamily = fontFamily,
                FontSize = this.FontSize,
                Height = this.ChildQualificationHeight,
            };
            control.QualificationDelete += OnDeleteQualification;
            Height = Height + control.Height + 30;
            var a = Padding;
            if (myStackPanel.Children.Count - 1 > 0)
                myStackPanel.Children.Insert(1, control);
            else
                myStackPanel.Children.Add(control);

            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(1200)
            };

            control.BeginAnimation(OpacityProperty, animation);
        }

        private async void OnDeleteQualification(object sender, EventArgs e)
        {
            QualificationCustomControl control = (sender as QualificationCustomControl);
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(800)
            };
            await AwaitAnimationManager.AnimateAsync(control, animation, OpacityProperty);
            Height = Height - control.Height - 30;
            myStackPanel.Children.Remove(control);
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


}
