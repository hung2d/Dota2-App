﻿#pragma checksum "c:\users\doanduyhung\documents\visual studio 2013\Projects\Dota2 App\Dota2 App\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A329EE77ABC90E2AA73FC2D79633059"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Dota2_App {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle topbanner;
        
        internal System.Windows.Shapes.Rectangle botbanner;
        
        internal System.Windows.Controls.Image avatar_image;
        
        internal System.Windows.Controls.TextBlock channelname_textblock;
        
        internal Microsoft.Phone.Controls.LongListSelector gridlist_gridview;
        
        internal System.Windows.Controls.TextBlock banner_textblock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Dota2%20App;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.topbanner = ((System.Windows.Shapes.Rectangle)(this.FindName("topbanner")));
            this.botbanner = ((System.Windows.Shapes.Rectangle)(this.FindName("botbanner")));
            this.avatar_image = ((System.Windows.Controls.Image)(this.FindName("avatar_image")));
            this.channelname_textblock = ((System.Windows.Controls.TextBlock)(this.FindName("channelname_textblock")));
            this.gridlist_gridview = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("gridlist_gridview")));
            this.banner_textblock = ((System.Windows.Controls.TextBlock)(this.FindName("banner_textblock")));
        }
    }
}

