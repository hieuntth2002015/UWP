using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lad3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Pages.Home));
            TitleTextBlock.Text = "Home";
            HomeS.IsSelected = true;

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeS.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Home));
                TitleTextBlock.Text = "Home";
            }
            if (ContactS.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Contact));
                TitleTextBlock.Text = "Contact";
            }
            if (CustomerS.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Customer));
                TitleTextBlock.Text = "Customer";
            }
            if (MailS.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Mail));
                TitleTextBlock.Text = "Mail";
            }

        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Pages.Home));
            TitleTextBlock.Text = "Home";
            HomeS.IsSelected = true;
        }
    }
}
