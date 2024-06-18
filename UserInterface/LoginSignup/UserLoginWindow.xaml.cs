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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface.LoginSignUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginSignUp : Window
    {
        public LoginSignUp()
        {
            InitializeComponent();
        }

        private async void OnDontHaveAccountClicked(object sender, MouseButtonEventArgs e)
        {
            Thickness destinationMargin = new Thickness(ActualWidth / 2, 0, -ActualWidth / 2, 0);
            ThicknessAnimation animation1 = new ThicknessAnimation()
            {
                From = signInTemplateImage.Margin,
                To = destinationMargin,
                Duration = TimeSpan.FromMilliseconds(500)
            };

            await AwaitAnimationManager.AnimateAsync(signInTemplateImage, animation1, MarginProperty);

            DoubleAnimation animation2 = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(700)
            };

            createAccountGrid.BeginAnimation(OpacityProperty, animation2);

            animation2.From = 1;    animation2.To = 0;

            signInGrid.BeginAnimation(OpacityProperty, animation2);
        }

        private async void OnAlreadyHaveAccountClicked(object sender, MouseButtonEventArgs e)
        {
            Thickness destinationMargin = new Thickness(0, 0, 0, 0);
            ThicknessAnimation animation1 = new ThicknessAnimation()
            {
                From = signInTemplateImage.Margin,
                To = destinationMargin,
                Duration = TimeSpan.FromMilliseconds(500)
            };

            await AwaitAnimationManager.AnimateAsync(signInTemplateImage, animation1, MarginProperty);

            DoubleAnimation animation2 = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(700)
            };

            signInGrid.BeginAnimation(OpacityProperty, animation2);

            animation2.From = 1; animation2.To = 0;

            createAccountGrid.BeginAnimation(OpacityProperty, animation2);
        }
    }
}
