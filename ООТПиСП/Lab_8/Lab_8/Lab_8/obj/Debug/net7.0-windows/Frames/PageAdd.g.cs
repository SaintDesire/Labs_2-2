﻿#pragma checksum "..\..\..\..\Frames\PageAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E57655467C6E2D0F5D0F67FF2FA73D2E4E56037B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_8.Frames;
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


namespace Lab_8.Frames {
    
    
    /// <summary>
    /// PageAdd
    /// </summary>
    public partial class PageAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox typeInput;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputModel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputCountSeat;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inputYearOfIssue;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputCapacity;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker InputDate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextWithInf;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Frames\PageAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgField;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab_8;component/frames/pageadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Frames\PageAdd.xaml"
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
            
            #line 11 "..\..\..\..\Frames\PageAdd.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Refresh);
            
            #line default
            #line hidden
            return;
            case 2:
            this.typeInput = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\..\..\Frames\PageAdd.xaml"
            this.typeInput.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChangeType);
            
            #line default
            #line hidden
            return;
            case 3:
            this.inputModel = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\Frames\PageAdd.xaml"
            this.inputModel.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeModel);
            
            #line default
            #line hidden
            return;
            case 4:
            this.inputCountSeat = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\..\Frames\PageAdd.xaml"
            this.inputCountSeat.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeCountSeat);
            
            #line default
            #line hidden
            return;
            case 5:
            this.inputYearOfIssue = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Frames\PageAdd.xaml"
            this.inputYearOfIssue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeYearOfIssue);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InputCapacity = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Frames\PageAdd.xaml"
            this.InputCapacity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangeCapacity);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InputDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 37 "..\..\..\..\Frames\PageAdd.xaml"
            this.InputDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ChangeDate);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\..\..\Frames\PageAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickChooseImage);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 40 "..\..\..\..\Frames\PageAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickAddCrewMember);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TextWithInf = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 42 "..\..\..\..\Frames\PageAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.imgField = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

