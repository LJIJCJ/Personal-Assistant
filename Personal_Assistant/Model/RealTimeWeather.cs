using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweetWeather
{
    /// <summary>
    /// 实时天气
    /// </summary>
    public class RealTimeWeather
    {
        //{"weatherinfo":{"city":"北京","cityid":"101010100","temp":"1","WD":"西北风","WS":"4级","SD":"14%","WSE":"4","time":"14:00","isRadar":"1","Radar":"JC_RADAR_AZ9010_JB"}}
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 城市ID
        /// </summary>
        public string cityid { get; set; }
        /// <summary>
        /// 当前气温
        /// </summary>
        public string temp { get; set; }
        /// <summary>
        /// 风向-西北风
        /// </summary>
        public string WD { get; set; }
        /// <summary>
        /// 风力-3级
        /// </summary>
        public string WS { get; set; }
        /// <summary>
        /// 湿度
        /// </summary>
        public string SD { get; set; }
        /// <summary>
        /// 风级-3
        /// </summary>
        public string WSE { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public string time { get; set; }
        /// <summary>
        /// 是否雷达
        /// </summary>
        public string isRadar { get; set; }
        /// <summary>
        /// 雷达
        /// </summary>
        public string Radar { get; set; }
        /// <summary>
        /// 温度边距
        /// </summary>
        public string tempmargin { get; set; }
        /// <summary>
        /// 摄氏度字体大小
        /// </summary>
        public string celsiusFontSize { get; set; }

        /// <summary>
        /// 摄氏度字体大小
        /// </summary>
        public string celsiusTextFontSize { get; set; }

    }
}
