﻿#pragma checksum "..\..\..\..\Windows\WindowCrewMember.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185D3EDBD33C33AAAE9C0CB0D3C7429CC7E537A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_8.Windows;
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


namespace Lab_8.Windows {
    
    
    /// <summary>
    /// WindowCrewMember
    /// </summary>
    public partial class WindowCrewMember : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Windows\WindowCrewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Windows\WindowCrewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PositionInput;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\WindowCrewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputAge;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\WindowCrewMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputExp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab_8;component/windows/windowcrewmember.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\WindowCrewMember.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.InputName = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\..\Windows\WindowCrewMember.xaml"
            this.InputName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeName);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PositionInput = ((System.Windows.Controls.ListBox)(target));
            
            #line 20 "..\..\..\..\Windows\WindowCrewMember.xaml"
            this.PositionInput.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChangedPosition);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InputAge = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\Windows\WindowCrewMember.xaml"
            this.InputAge.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeAge);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inputExp = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\Windows\WindowCrewMember.xaml"
            this.inputExp.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeExp);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\..\..\Windows\WindowCrewMember.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

