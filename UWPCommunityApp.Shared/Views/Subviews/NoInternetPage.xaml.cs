﻿using Microsoft.Toolkit.Uwp.Connectivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCommunityApp.Views.Subviews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NoInternetPage : Page
    {
        public NoInternetPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Keep checking for an internet connection and
            // return to previous page if reconnected
            while (true)
            {
                if (NetworkHelper.Instance.ConnectionInformation.IsInternetAvailable)
                {
                    await Launcher.LaunchUriAsync(new Uri("uwpcommunity://"));
                    return;
                }
            }
        }
    }
}
