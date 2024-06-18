﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace UserInterface.Custom_Animation
{
    class GridLengthAnimation : AnimationTimeline
    {
        public override Type TargetPropertyType => typeof(GridLength);

        public GridLength From
        {
            get { return (GridLength)GetValue(FromProperty); }
            set { SetValue(FromProperty, value); }
        }

        // Using a DependencyProperty as the backing store for From.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FromProperty =
            DependencyProperty.Register("From", typeof(GridLength), typeof(GridLengthAnimation), new PropertyMetadata(new GridLength(0)));


        public GridLength To
        {
            get { return (GridLength)GetValue(ToProperty); }
            set { SetValue(ToProperty, value); }
        }

        // Using a DependencyProperty as the backing store for To.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register("To", typeof(GridLength), typeof(GridLengthAnimation), new PropertyMetadata(new GridLength(0)));



        public GridUnitType CustomGridUnitType
        {
            get { return (GridUnitType)GetValue(CustomGridUnitTypeProperty); }
            set { SetValue(CustomGridUnitTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomGridUnitType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomGridUnitTypeProperty =
            DependencyProperty.Register("CustomGridUnitType", typeof(GridUnitType), typeof(GridLengthAnimation), new PropertyMetadata(GridUnitType.Pixel));



        public override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
        {
            double fromVal = From.Value;
            double toVal = To.Value;

            if (fromVal > toVal)
            {
                return new GridLength((1 - animationClock.CurrentProgress.Value) * (fromVal - toVal) + toVal, CustomGridUnitType);
            }
            else
            {
                return new GridLength(animationClock.CurrentProgress.Value * (toVal - fromVal) + fromVal, CustomGridUnitType);
            }
        }

        protected override Freezable CreateInstanceCore()
        {
            return new GridLengthAnimation();
        }

    }
}
