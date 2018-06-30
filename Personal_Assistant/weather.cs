using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Assistant
{
    public class resp
    {
        public string city { get; set; }
        public string updatetime { get; set; }
        public string wendu { get; set; }
        public string fengli { get; set; }
        public string shidu { get; set; }
        public string fengxiang { get; set; }
        public string sunrise { get; set; }
        public string sunset_1 { get; set; }
        public environment environment { get; set; }

        public alarm alarm { get; set; }
        public List<weather> forecast { set; get; }
        public List<zhishu> zhishus { get; set; }
    }
    public class environment
    {
        public string aqi { get; set; }
        public string pm25 { get; set; }
        public string suggest { get; set; }
        public string quality { get; set; }
        public string MajorPollutants { get; set; }
        public string time { get; set; }
    }
    public class alarm
    {
        public string cityName { get; set; }
        public string alarmType { get; set; }
        public string alarmDegree { get; set; }
        public string alarmText { get; set; }
        public string alarm_details { get; set; }
        public string standard { get; set; }
        public string suggest { get; set; }
    }
    public class weather
    {
        public string date { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public climate day { get; set; }
        public climate night { get; set; }
    }
    public class climate
    {
        public string type { get; set; }
        public string fengxiang { get; set; }
        public string fengli { get; set; }
    }
    public class zhishu
    {
        public string name { get; set; }
        public string value { get; set; }
        public string datail { get; set; }
    }
}