using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ContextMenuDemo
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

        private void ListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            ListView listView = (ListView)sender;
            allContactsMenuFlyout.ShowAt(listView, e.GetPosition(listView));
            var a = ((FrameworkElement)e.OriginalSource).DataContext;
            Debug.WriteLine(a);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Remove clicked");
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Goal");

            try
            {
                this.Frame.Navigate(typeof(BlankPage1));  // gives error
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.ToString() + "  " + ex.Source + "  "+ex.StackTrace);
            }
            }
    }
    

}
