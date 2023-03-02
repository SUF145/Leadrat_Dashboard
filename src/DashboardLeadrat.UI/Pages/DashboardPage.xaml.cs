using System;
using System.Collections.Generic;
using DashboardLeadrat.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace DashboardLeadrat.UI.Pages
{    
    public partial class DashboardPage : MvxContentPage<DashboardViewModel>
    {    
        public DashboardPage ()
        {
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(false);
            InitializeComponent();
        }
        
    }
}

