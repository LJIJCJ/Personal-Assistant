using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO.Compression;
using System.Xml.Serialization;
using System.IO;

namespace Personal_Assistant
{
    /// <summary>
    /// one.xaml 的交互逻辑
    /// </summary>
    public partial class one : Page
    {    
        private DispatcherTimer ShowTimer;
        public one()
        {
            InitializeComponent();
            refreshtime();
            ShowTimer = new System.Windows.Threading.DispatcherTimer();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();
            crawler();
            
        }
        public void refreshtime()
        {
            this.date.Content = DateTime.Now.ToString("r").Substring(0, 16);
            this.time.Content = DateTime.Now.ToString("hh:mm:ss");
        }
        public void ShowCurTimer(object sender, EventArgs e)
        {
            refreshtime();
        }
        public void crawler()
        {
            string url = "http://wthrcdn.etouch.cn/WeatherApi?citykey=101270101";
            string html = getHtml2(url);
            resp tempInfo = XmlDeSeralizer<resp>(html);

            RealTem.Text = tempInfo.wendu;

            WeatherType.Text = tempInfo.forecast[0].day.type;
            HigTem.Text = tempInfo.forecast[0].high;
            LowTem.Text = tempInfo.forecast[0].low;
            ShiDu.Text = tempInfo.shidu;
            ShuShidu.Text="天气"+tempInfo.zhishus[1].value;
            Sport.Text = tempInfo.zhishus[8].value+"运动";

            /*
            tblRealTime.Text = "数据更新于"+tempInfo.updatetime;
           /*
            tblWD.Text = tempInfo.fengxiang;
            tblWS.Text = tempInfo.fengli;
            tblSD.Text = tempInfo.shidu;
            /*
            tblCY.Text = tempInfo.zhishus[2].value;
            tblFS.Text = tempInfo.zhishus[6].value;
            tblxc.Text = tempInfo.zhishus[7].value;
            tblLY.Text = tempInfo.zhishus[5].value;
            tblSS.Text = tempInfo.zhishus[1].value;
            tblCL.Text = tempInfo.zhishus[0].value;
            tblLS.Text = tempInfo.zhishus[4].value;
            tblGM.Text = tempInfo.zhishus[3].value;
            */
        }
        private static string getHtml2(string url)
        {
            StringBuilder s = new StringBuilder(102400);
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url);
            wr.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";
            HttpWebResponse response = (HttpWebResponse)wr.GetResponse(); head(response);
            GZipStream g = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
            byte[] d = new byte[20480];
            int l = g.Read(d, 0, 20480);
            while (l > 0)
            {
                s.Append(Encoding.UTF8.GetString(d, 0, l));
                l = g.Read(d, 0, 20480);
            }
            //返回json信息
            return s.ToString();
        }
        private static void head(HttpWebResponse r)
        {
            string[] keys = r.Headers.AllKeys; for (int i = 0; i < keys.Length; ++i)
            {
                //Console.WriteLine(keys[i] + "   " + r.Headers[keys[i]]);
            }
        }
        public static T XmlDeSeralizer<T>(string xmlStr) where T : class, new()
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xmlStr))
            {
                return xs.Deserialize(reader) as T;
            }
        }

        private void Refresh(object sender,EventArgs e)
        {
            crawler();
        }

        void Minimized(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Minimized;
        }
        void Normal(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Normal;
        }
        void Maximized(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Maximized;
        }
        void Close(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).Close();
        }
    }
}
