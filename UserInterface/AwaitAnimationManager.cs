using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace UserInterface
{
    static class AwaitAnimationManager
    {
        public static Task AnimateAsync(UIElement element, AnimationTimeline animation, DependencyProperty property)
        {
            var tcs = new TaskCompletionSource<bool>();

            if (animation == null)
                tcs.SetException(new ArgumentNullException(nameof(animation)));

            animation.Completed += (s, e) => tcs.SetResult(true);

            element.BeginAnimation(property, animation);

            return tcs.Task;
        }
    }
}
