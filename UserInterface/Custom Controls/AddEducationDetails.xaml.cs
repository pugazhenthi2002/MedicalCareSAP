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

namespace UserInterface.Custom_Controls
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


        public double CustomBorderRadius
        {
            get { return (double)GetValue(CustomBorderRadiusProperty); }
            set { SetValue(CustomBorderRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomBorderRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomBorderRadiusProperty =
            DependencyProperty.Register("CustomBorderRadius", typeof(double), typeof(AddEducationDetails), new PropertyMetadata());



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
            Height = AddQualificationHeight + Padding.Bottom + Padding.Top;
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
            Thickness margin = new Thickness(5);
            QualificationControl control = new QualificationControl()
            {
                Margin = margin,
                Opacity = 0,
                Width = this.Width - Padding.Left - Padding.Right - margin.Left - margin.Right,
                CustomBackground = background,
                CustomForeground = foreground,
                FontFamily = fontFamily,
                FontSize = this.FontSize,
                CustomBorderRadius = this.CustomBorderRadius,
                Height = this.ChildQualificationHeight,
            };
            control.QualificationDelete += OnDeleteQualification;
            Height = Height + control.Height;

            if (myStackPanel.Children.Count - 1 > 0)
                myStackPanel.Children.Insert(1, control);
            else
                myStackPanel.Children.Add(control);

            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(1000)
            };

            control.BeginAnimation(OpacityProperty, animation);
        }

        private void OnDeleteQualification(object sender, EventArgs e)
        {
            QualificationControl control = (sender as QualificationControl);
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(1000)
            };
            control.BeginAnimation(OpacityProperty, animation);
            Height = Height - control.Height - 10;
            myStackPanel.Children.Remove(control);
        }
    }
}
