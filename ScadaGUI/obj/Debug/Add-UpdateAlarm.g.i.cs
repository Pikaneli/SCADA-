﻿#pragma checksum "..\..\Add-UpdateAlarm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2186591840990A2A863A28413F197DAD4CB23F5A3F9B82607679EB2442467BD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ScadaGUI;
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


namespace ScadaGUI {
    
    
    /// <summary>
    /// Add_UpdateAlarm
    /// </summary>
    public partial class Add_UpdateAlarm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScadaGUI.Add_UpdateAlarm AUAlarm;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAlarm;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idTxt;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mesTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HL;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox limTxt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tagIDC;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Add-UpdateAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ScadaGUI;component/add-updatealarm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Add-UpdateAlarm.xaml"
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
            this.AUAlarm = ((ScadaGUI.Add_UpdateAlarm)(target));
            return;
            case 2:
            this.AddAlarm = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Add-UpdateAlarm.xaml"
            this.AddAlarm.Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.idTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.mesTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.HL = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.limTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tagIDC = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Add-UpdateAlarm.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

