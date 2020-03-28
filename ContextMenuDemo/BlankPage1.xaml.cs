using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ContextMenuDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        string content = "";
        private ObservableCollection<Model> list = new ObservableCollection<Model>();
        public BlankPage1()
        {
            this.InitializeComponent();

           

            list.Add(new Model { Name = "Video Title1" });
            list.Add(new Model { Name = "Video Title2" });
            list.Add(new Model { Name = "Video Title3" });

        }


        private void ListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            ListView listView = (ListView)sender;
            allContactsMenuFlyout.ShowAt(listView, e.GetPosition(listView));
            Model listObj = (Model)((FrameworkElement)e.OriginalSource).DataContext;
            content = listObj.Name;
            Debug.WriteLine($"{listObj.Name}");
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
           
            Debug.WriteLine("Remove clicked");
            foreach (var item in list.ToList())
            {
                if (item.Name == content)
                {
                    list.Remove(item);
                }
            }
            content = "";
            Debug.WriteLine(list.ToString());
        }
    
    }
    public class Model
    {
       
        public string Name { get; set; }
       
    }

}
