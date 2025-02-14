using System;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace ClockGoblinBug
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogHyperlinkClick(object sender, RoutedEventArgs e)
        {
            string loggerName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                         "Log", DateTime.Now.ToString("yyyy-MM-dd") + ".log");
            if (File.Exists(loggerName))
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select, " + loggerName);
            }
        }
        private void IssuesHyperlinkClick(object sender, RoutedEventArgs e)
        {
            //https://github.com/Planshit/ClockGoblin/issues/new
            Process.Start(new ProcessStartInfo(""));
        }
        private void EmailHyperlinkClick(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("*邮箱地址*");
            MessageBox.Show("邮箱已复制");
        }
        private void Restart(object sender, RoutedEventArgs e)
        {
            string taiPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "ClockGoblin.exe");
            if (File.Exists(taiPath))
            {
                Process.Start(taiPath);
            }
            else
            {
                MessageBox.Show("ClockGoblin.exe 似乎已被删除", "重启失败提示", MessageBoxButton.OK, MessageBoxImage.Error);
                //https://github.com/Planshit/ClockGoblin
                Process.Start(new ProcessStartInfo(""));
            }
            Close();
        }
    }
}
