﻿#pragma checksum "..\..\..\..\uis\cashier_dashbord.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4D7926AFBE6B1C8BBDD2F84C851B8C0239A135C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SaleSync.uis;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SaleSync.uis {
    
    
    /// <summary>
    /// admin_dashbord
    /// </summary>
    public partial class admin_dashbord : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\uis\cashier_dashbord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Datagrid;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\uis\cashier_dashbord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemcode_text;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\uis\cashier_dashbord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ICode_txt;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\uis\cashier_dashbord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock quantity_text;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\uis\cashier_dashbord.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity_txt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SaleSync;component/uis/cashier_dashbord.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\uis\cashier_dashbord.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 30 "..\..\..\..\uis\cashier_dashbord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cashier_my_profile_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.itemcode_text = ((System.Windows.Controls.TextBlock)(target));
            
            #line 70 "..\..\..\..\uis\cashier_dashbord.xaml"
            this.itemcode_text.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.itemcode_text_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ICode_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\uis\cashier_dashbord.xaml"
            this.ICode_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ICode_txt_textchanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.quantity_text = ((System.Windows.Controls.TextBlock)(target));
            
            #line 88 "..\..\..\..\uis\cashier_dashbord.xaml"
            this.quantity_text.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.quantity_text_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.quantity_txt = ((System.Windows.Controls.TextBox)(target));
            
            #line 89 "..\..\..\..\uis\cashier_dashbord.xaml"
            this.quantity_txt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.quantity_txt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 102 "..\..\..\..\uis\cashier_dashbord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.enter_click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 103 "..\..\..\..\uis\cashier_dashbord.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.sell_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

