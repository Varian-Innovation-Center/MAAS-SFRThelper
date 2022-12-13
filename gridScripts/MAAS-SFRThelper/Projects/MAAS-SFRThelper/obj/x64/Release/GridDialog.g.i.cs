﻿#pragma checksum "..\..\..\GridDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42635804DC63C0B6CBAE5E2B21711EA17BDBFD5870387068885C911EFBBAC9F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GridBlockCreator;
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


namespace GridBlockCreator {
    
    
    /// <summary>
    /// GridDialog
    /// </summary>
    public partial class GridDialog : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TargetList;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Radius;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XSpacing;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YSpacing;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XOffset;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YOffset;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox XTilt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\GridDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YTilt;
        
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
            System.Uri resourceLocater = new System.Uri("/MAAS-SFRThelper.esapi;component/griddialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GridDialog.xaml"
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
            this.TargetList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\GridDialog.xaml"
            this.TargetList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TargetList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Radius = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.XSpacing = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.YSpacing = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.XOffset = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.YOffset = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.XTilt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.YTilt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 75 "..\..\..\GridDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateGrid);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 76 "..\..\..\GridDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateGridAndInverse);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 77 "..\..\..\GridDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

