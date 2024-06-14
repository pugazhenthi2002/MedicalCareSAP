using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Theme
{
    public enum Theme
    {
        Winter,
        Summer
    }

    static class ThemeManager
    {
        public static Theme CurrentTheme { get; set; }

        public static void ChangeTheme()
        {
            CurrentTheme = CurrentTheme == Theme.Summer ? Theme.Winter : Theme.Summer;
        }
    }
}
