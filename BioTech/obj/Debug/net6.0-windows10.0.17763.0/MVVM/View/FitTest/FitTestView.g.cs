﻿#pragma checksum "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AA112692488EB53AA7F05D6A90D114130AE301A"
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


namespace BioTech.MVVM.View.FitTest {
    
    
    /// <summary>
    /// FitTestView
    /// </summary>
    public partial class FitTestView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaFitTest;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCopia;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGuarda;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonModifica;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BioTech;component/mvvm/view/fittest/fittestview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
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
            this.ListaFitTest = ((System.Windows.Controls.ListView)(target));
            
            #line 23 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            this.ListaFitTest.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFitTest);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 36 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NuovoFitTest_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonCopia = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            this.ButtonCopia.Click += new System.Windows.RoutedEventHandler(this.CopiaFitTest_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonGuarda = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            this.ButtonGuarda.Click += new System.Windows.RoutedEventHandler(this.GuardaFitTest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonModifica = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            this.ButtonModifica.Click += new System.Windows.RoutedEventHandler(this.ModificaFitTest_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ricerca = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            this.Ricerca.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ricerca_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 41 "..\..\..\..\..\..\MVVM\View\FitTest\FitTestView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

