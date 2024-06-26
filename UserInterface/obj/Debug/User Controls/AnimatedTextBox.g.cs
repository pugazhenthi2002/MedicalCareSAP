﻿#pragma checksum "..\..\..\User Controls\AnimatedTextBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D393B7BEC50EF19A928CC1F4359DDF8D0067713C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using UserInterface.User_Controls;


namespace UserInterface.User_Controls {
    
    
    /// <summary>
    /// AnimatedTextBox
    /// </summary>
    public partial class AnimatedTextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UserInterface.User_Controls.AnimatedTextBox animatedTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mainTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle roundedRectangle;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label placeHolder;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas viewPassCanvas;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label viewPassLabel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\User Controls\AnimatedTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line viewPassLabelLine;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/user%20controls/animatedtextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User Controls\AnimatedTextBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.animatedTextBox = ((UserInterface.User_Controls.AnimatedTextBox)(target));
            return;
            case 2:
            this.mainTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.mainTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.MainTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.mainTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.MainTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.mainTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.MainTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.mainTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.mainTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.mainTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.MainTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.roundedRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.placeHolder = ((System.Windows.Controls.Label)(target));
            
            #line 42 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.placeHolder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PlaceHolder_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.viewPassCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.viewPassLabel = ((System.Windows.Controls.Label)(target));
            
            #line 51 "..\..\..\User Controls\AnimatedTextBox.xaml"
            this.viewPassLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ViewPassLabelClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.viewPassLabelLine = ((System.Windows.Shapes.Line)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

