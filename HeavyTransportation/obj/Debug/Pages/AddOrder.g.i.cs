﻿#pragma checksum "..\..\..\Pages\AddOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B3565D2A39DBBE8387F09F3A9A9BF6F613AAEB4C3DC81BD5F9A8AD80D7B5107"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HeavyTransportation.Pages;
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


namespace HeavyTransportation.Pages {
    
    
    /// <summary>
    /// AddOrder
    /// </summary>
    public partial class AddOrder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_CustomerName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_DeparturePoint;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_DestinationPoint;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_DistanceKM;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_Weight;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmd_Driver;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmd_Trailer;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_AddOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/HeavyTransportation;component/pages/addorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddOrder.xaml"
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
            this.Txb_CustomerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Txb_DeparturePoint = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Txb_DestinationPoint = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Txb_DistanceKM = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Txb_Weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Cmd_Driver = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Cmd_Trailer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Btn_AddOrder = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
