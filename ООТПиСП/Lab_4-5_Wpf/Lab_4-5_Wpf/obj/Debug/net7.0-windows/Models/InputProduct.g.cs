﻿#pragma checksum "..\..\..\..\Models\InputProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85280763AA9D700B777E4914CE5536587F610FD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_4_5_Wpf.Commands;
using Lab_4_5_Wpf.Models;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace Lab_4_5_Wpf.Models {
    
    
    /// <summary>
    /// InputProduct
    /// </summary>
    public partial class InputProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title_TextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description_TextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddOrChangeButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Type_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Price_Slider;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProductImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Lab_4-5_Wpf;component/models/inputproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Models\InputProduct.xaml"
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
            
            #line 14 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ChangeProductInDataGrid);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddProduct_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Title_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Description_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddOrChangeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            
            #line 43 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Type_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\..\Models\InputProduct.xaml"
            this.Type_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Type_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Price_Slider = ((System.Windows.Controls.Slider)(target));
            return;
            case 9:
            this.ProductImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

