﻿#pragma checksum "..\..\StudentAdded.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F37C7226F8E0F37F14C0D7F5E2B43B6963A7C50"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstProject;
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


namespace FirstProject {
    
    
    /// <summary>
    /// Edit
    /// </summary>
    public partial class Edit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoyad;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBolum;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCinsiyet;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOgrenciNo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKaydet;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablo2;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbIndex;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\StudentAdded.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblErrorMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstProject;component/studentadded.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentAdded.xaml"
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
            this.txtSoyad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmbBolum = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cmbCinsiyet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtAd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtOgrenciNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnKaydet = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\StudentAdded.xaml"
            this.btnKaydet.Click += new System.Windows.RoutedEventHandler(this.btnKaydet_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tablo2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.cmbIndex = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\StudentAdded.xaml"
            this.cmbIndex.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbIndex_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblErrorMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

