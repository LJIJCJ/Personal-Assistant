using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweetWeather
{
    public class TodayWeather
    {
        //{"weatherinfo":{"city":"北京","cityid":"101010100","temp1":"3℃","temp2":"-6℃","weather":"晴","img1":"d0.gif","img2":"n0.gif","ptime":"11:00"}}
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 城市ID
        /// </summary>
        public string cityid { get; set; }
        /// <summary>
        /// 最高温度
        /// </summary>
        public string temp1 { get; set; }
        /// <summary>
        /// 最低温度
        /// </summary>
        public string temp2 { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        public string weather { get; set; }
        /// <summary>
        /// 天气图片1
        /// </summary>
        public string img1 { get; set; }
        /// <summary>
        /// 天气图片2
        /// </summary>
        public string img2 { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public string ptime { get; set; }
    }
}
