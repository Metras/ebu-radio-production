﻿#pragma checksum "..\..\..\..\UI\PicFrame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B5AF6BE352C144DEE224FB3DE4F64AC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Playout.UI;
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
using WpfCap;


namespace Playout.UI {
    
    
    /// <summary>
    /// PicFrame
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class PicFrame : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stack;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image displayOA;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image display1;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image display2;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfCap.CapPlayer player;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\UI\PicFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox webcamText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Playout;component/ui/picframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\PicFrame.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.displayOA = ((System.Windows.Controls.Image)(target));
            
            #line 63 "..\..\..\..\UI\PicFrame.xaml"
            this.displayOA.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseRightButtonUp);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\..\UI\PicFrame.xaml"
            this.displayOA.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.display1 = ((System.Windows.Controls.Image)(target));
            
            #line 65 "..\..\..\..\UI\PicFrame.xaml"
            this.display1.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseRightButtonUp);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\UI\PicFrame.xaml"
            this.display1.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.display2 = ((System.Windows.Controls.Image)(target));
            
            #line 66 "..\..\..\..\UI\PicFrame.xaml"
            this.display2.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseRightButtonUp);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\UI\PicFrame.xaml"
            this.display2.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.display_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.player = ((WpfCap.CapPlayer)(target));
            return;
            case 6:
            
            #line 77 "..\..\..\..\UI\PicFrame.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.webcamText = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

