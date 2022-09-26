using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Uwp_Discord.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Uwp_Discord
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            dataContext.ScreenHeight = this.ActualHeight;
            dataContext.ScreenWidth = this.ActualWidth;
        }


        //public void NotifyUser(string strMessage, NotifyType type)
        //{
        //    // If called from the UI thread, then update immediately.
        //    // Otherwise, schedule a task on the UI thread to perform the update.
        //    if (Dispatcher.HasThreadAccess)
        //    {
        //        UpdateStatus(strMessage, type);
        //    }
        //    else
        //    {
        //        var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => UpdateStatus(strMessage, type));
        //    }
        //}

        //private void UpdateStatus(string strMessage, NotifyType type)
        //{
        //    switch (type)
        //    {
        //        case NotifyType.StatusMessage:
        //            StatusBorder.Background = new SolidColorBrush(Windows.UI.Colors.Green);
        //            break;
        //        case NotifyType.ErrorMessage:
        //            StatusBorder.Background = new SolidColorBrush(Windows.UI.Colors.Red);
        //            break;
        //    }

        //    StatusBlock.Text = strMessage;

        //    // Collapse the StatusBlock if it has no text to conserve real estate.
        //    StatusBorder.Visibility = (StatusBlock.Text != String.Empty) ? Visibility.Visible : Visibility.Collapsed;
        //    if (StatusBlock.Text != String.Empty)
        //    {
        //        StatusBorder.Visibility = Visibility.Visible;
        //        StatusPanel.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        StatusBorder.Visibility = Visibility.Collapsed;
        //        StatusPanel.Visibility = Visibility.Collapsed;
        //    }

        //    // Raise an event if necessary to enable a screen reader to announce the status update.
        //    var peer = FrameworkElementAutomationPeer.FromElement(StatusBlock);
        //    if (peer != null)
        //    {
        //        peer.RaiseAutomationEvent(AutomationEvents.LiveRegionChanged);
        //    }
        //}
    }
}
