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
using Lad3.Models;
using Lad3.Pages;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lad3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(App.NameContact)) 
            {
                valuename.Text = App.NameContact;
            }

            if (!string.IsNullOrEmpty(App.MailContact))
            {
                valuemail.Text = App.MailContact;
            }

            if (!string.IsNullOrEmpty(App.PhoneContact))
            {
                valuephone.Text = App.PhoneContact;
            }

        }
    }
}
