﻿#pragma checksum "..\..\..\CreateProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DA55B507CB5575EA1B618429457547A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyCuteClientApp.CuteService;
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


namespace MyCuteClientApp {
    
    
    /// <summary>
    /// CreateProfile
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CreateProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CPScreen;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid createProfile;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEnterStudentName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockEnterStudentName;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStudentPassword;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockStudentPassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid studentDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn studentIdColumn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn studentNameColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn studentPasswordColumn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtstudentNumber;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\CreateProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockStudentNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/MyCuteClientApp;component/createprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreateProfile.xaml"
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
            
            #line 4 "..\..\..\CreateProfile.xaml"
            ((MyCuteClientApp.CreateProfile)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CPScreen = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.createProfile = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.txtEnterStudentName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBlockEnterStudentName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtStudentPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtBlockStudentPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\CreateProfile.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.studentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.studentIdColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.studentNameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.studentPasswordColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.txtstudentNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.textBlockStudentNumber = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
