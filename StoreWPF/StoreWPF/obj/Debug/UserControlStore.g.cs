﻿#pragma checksum "..\..\UserControlStore.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D9857E196A7FD8D602D8A9B52404DB4B75C183C9D301A23265B99A6F94B8FCD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StoreWPF;
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


namespace StoreWPF {
    
    
    /// <summary>
    /// UserControlStore
    /// </summary>
    public partial class UserControlStore : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageProduct;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label productName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label productDescription;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label productPrice;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBuy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDelete;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPlusProduct;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonMinusProduct;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\UserControlStore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label amountAddProduct;
        
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
            System.Uri resourceLocater = new System.Uri("/StoreWPF;component/usercontrolstore.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlStore.xaml"
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
            this.imageProduct = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.productName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.productDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.productPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.buttonBuy = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\UserControlStore.xaml"
            this.buttonBuy.Click += new System.Windows.RoutedEventHandler(this.buttonBuy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\UserControlStore.xaml"
            this.buttonDelete.Click += new System.Windows.RoutedEventHandler(this.buttonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonPlusProduct = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\UserControlStore.xaml"
            this.buttonPlusProduct.Click += new System.Windows.RoutedEventHandler(this.buttonPlusProduct_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonMinusProduct = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.amountAddProduct = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

