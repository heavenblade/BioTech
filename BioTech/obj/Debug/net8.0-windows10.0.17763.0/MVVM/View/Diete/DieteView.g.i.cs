﻿#pragma checksum "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210D425124A94C099E457FB64EB212BD0806B332"
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


namespace BioTech.MVVM.View.Diete {
    
    
    /// <summary>
    /// DieteView
    /// </summary>
    public partial class DieteView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaDiete;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CategoriaFilter;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGuarda;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ricerca;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BioTech;V1.0.0.0;component/mvvm/view/diete/dieteview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListaDiete = ((System.Windows.Controls.ListView)(target));
            
            #line 26 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            this.ListaDiete.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedDieta);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CategoriaFilter = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 30 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.BuildListaDiete);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.BuildListaDiete);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.BuildListaDiete);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.BuildListaDiete);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonGuarda = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            this.ButtonGuarda.Click += new System.Windows.RoutedEventHandler(this.GuardaDieta_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 40 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 41 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RinominaDieta_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Ricerca = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            this.Ricerca.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ricerca_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 43 "..\..\..\..\..\..\MVVM\View\Diete\DieteView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonReset_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

