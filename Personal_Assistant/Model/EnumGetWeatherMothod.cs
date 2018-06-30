using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SweetWeather
{
    public enum EnumGetWeatherMothod
    {
        /// <summary>
        /// 实时天气信息
        /// </summary>
        RealTime=0,
        /// <summary>
        /// 今日天气信息
        /// </summary>
        Today=1,
        /// <summary>
        /// 多日天气信息
        /// </summary>
        MoreDay=2,
        /// <summary>
        /// 所有
        /// </summary>
        All=3
    }
}
