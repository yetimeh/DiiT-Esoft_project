﻿#pragma checksum "..\..\..\..\uis\SignUp_window.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E00D6708AC8EE4DCD42CDA21D6466297F54A1A8F"
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
using esoftprojecttest;


namespace esoftprojecttest {
    
    
    /// <summary>
    /// SignUp_window
    /// </summary>
    public partial class SignUp_window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image proPic;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock firstname;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FName;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lastname;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LName;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NIC;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ncard;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock locationtext;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox locationpin;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock phone_number;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\uis\SignUp_window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pnumber;
        
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
            System.Uri resourceLocater = new System.Uri("/SaleSync;component/uis/signup_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\uis\SignUp_window.xaml"
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
            this.proPic = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.firstname = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\..\..\uis\SignUp_window.xaml"
            this.firstname.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.firstname_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FName = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\..\uis\SignUp_window.xaml"
            this.FName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lastname = ((System.Windows.Controls.TextBlock)(target));
            
            #line 72 "..\..\..\..\uis\SignUp_window.xaml"
            this.lastname.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.lastname_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LName = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\uis\SignUp_window.xaml"
            this.LName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NIC = ((System.Windows.Controls.TextBlock)(target));
            
            #line 90 "..\..\..\..\uis\SignUp_window.xaml"
            this.NIC.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NIC_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Ncard = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\..\uis\SignUp_window.xaml"
            this.Ncard.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ncard_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.locationtext = ((System.Windows.Controls.TextBlock)(target));
            
            #line 108 "..\..\..\..\uis\SignUp_window.xaml"
            this.locationtext.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.locationtext_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.locationpin = ((System.Windows.Controls.TextBox)(target));
            
            #line 109 "..\..\..\..\uis\SignUp_window.xaml"
            this.locationpin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.locationpin_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.phone_number = ((System.Windows.Controls.TextBlock)(target));
            
            #line 129 "..\..\..\..\uis\SignUp_window.xaml"
            this.phone_number.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.phone_number_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Pnumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 130 "..\..\..\..\uis\SignUp_window.xaml"
            this.Pnumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Pnumber_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

