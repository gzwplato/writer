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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace writer
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void onchange(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            
        }

        private void md_TextChanged(object sender, TextChangedEventArgs e)
        {
            string md_text = md.Text;
            string clear_text = md_text;
            //replace md tags
            clear_text = clear_text.Replace("#", "");
            clear_text = clear_text.Replace(">", "");
            count.Text = clear_text.Count()+"";
            string html = md_text;
            web.NavigateToString(html);

        }
    }
}
