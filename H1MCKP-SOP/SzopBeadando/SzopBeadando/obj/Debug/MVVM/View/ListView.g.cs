﻿#pragma checksum "..\..\..\..\MVVM\View\ListView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B3A17FC9C64A2560664E84A73CD982BC5ABDC9FD3A1BA34370E4BE447F9663F"
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
using SzopBeadando.MVVM.View;
using SzopBeadando.Theme;


namespace SzopBeadando.MVVM.View {
    
    
    /// <summary>
    /// ListView
    /// </summary>
    public partial class ListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 2 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SzopBeadando.MVVM.View.ListView listView;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BrandInputBox;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoffeinInputBox;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelInputBox;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceInputBox;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\MVVM\View\ListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/SzopBeadando;component/mvvm/view/listview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\ListView.xaml"
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
            this.listView = ((SzopBeadando.MVVM.View.ListView)(target));
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.BrandInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CoffeinInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ModelInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PriceInputBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.insertBtn = ((System.Windows.Controls.Button)(target));
            
            #line 262 "..\..\..\..\MVVM\View\ListView.xaml"
            this.insertBtn.Click += new System.Windows.RoutedEventHandler(this.insert_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 70 "..\..\..\..\MVVM\View\ListView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 83 "..\..\..\..\MVVM\View\ListView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.update_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

