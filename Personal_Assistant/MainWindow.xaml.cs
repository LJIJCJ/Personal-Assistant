using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BlurryControls.DialogFactory;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.Net;
using System.IO;

namespace Personal_Assistant
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public static int second1 = int.Parse(DateTime.Now.ToString("ss"));
        public static bool flag1 = true, flag2 = true;
        private DispatcherTimer ShowTimer;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            refreshtime();
            ShowTimer = new System.Windows.Threading.DispatcherTimer();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();

        }
        public void refreshtime()
        {
            this.date.Content = DateTime.Now.ToString("r").Substring(0, 16);
            this.time.Content = DateTime.Now.ToString("hh:mm:ss");
        }
        public void ShowCurTimer(object sender, EventArgs e)
        {
            refreshtime();
            if (flag2)
            {
                if (int.Parse(DateTime.Now.ToString("ss")) - second1 >= 3)
                {
                    this.Content = new one();
                    flag2 = false;
                }
                else
                {
                    if (second1 - int.Parse(DateTime.Now.ToString("ss")) >= 3) {
                        this.Content = new one();
                        flag2 = false;
                    }
                }
            }
        }
        private void MetroWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.F11)
            {
                if (flag1)
                {
                    this.WindowState = WindowState.Maximized;
                    System.Windows.Forms.Cursor.Hide();
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    flag1 = false;
                }
                else
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    System.Windows.Forms.Cursor.Show();
                    flag1 = true;
                }

            }
            if (e.Key == Key.Escape)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
