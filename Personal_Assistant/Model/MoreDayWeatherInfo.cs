using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SweetWeather.Model;
using Newtonsoft.Json.Linq;

namespace SweetWeather
{

    public class MoreDayWeatherInfoAll
    {
        //        {"status":1,"detail":"\u6570\u636e\u83b7\u53d6\u6210\u529f","data":[[
        //{"date":"2014-01-01","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"1","wind":"\u897f\u98ce3-4\u7ea7","weather_name":"\u6674","weather_pic":"styles\/images\/icon2\/day\/1.png","humidity":"","tem_min":"1","tem_max":"13","sunrise":"07:17","sunset":"17:12","pm":"63","air":"\u826f",
        //"day_night":[
        //    {"date":"2014-01-01","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"1","wind":"\u897f\u98ce3-4\u7ea7","weather_name":"\u6674","weather_pic":"styles\/images\/icon2\/day\/1.png","humidity":"","tem":"13"},
        //    {"date":"2014-01-01","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"1","wind":"\u5317\u98ce3-4\u7ea7","weather_name":"\u6674","weather_pic":"styles\/images\/icon2\/night\/1.png","humidity":"","tem":"1"}
        //        ]
        //},
        //{"date":"2014-01-02","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"2","wind":"\u4e1c\u5357\u98ce3-4\u7ea7","weather_name":"\u591a\u4e91","weather_pic":"styles\/images\/icon2\/day\/2.png","humidity":"","tem_min":"1","tem_max":"13","sunrise":"07:17","sunset":"17:12","pm":"","air":"",
        //"day_night":[
        //    {"date":"2014-01-02","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"2","wind":"\u4e1c\u5357\u98ce3-4\u7ea7","weather_name":"\u591a\u4e91","weather_pic":"styles\/images\/icon2\/day\/2.png","humidity":"","tem":"13"},
        //    {"date":"2014-01-02","dis_id":"1119","dis_name":"\u5f90\u5dde\u5e02","url":"http:\/\/www.tianqiyubao.com\/local.php?dis_id=1119","weather":"2","wind":"\u5357\u98ce3-4\u7ea7","weather_name":"\u591a\u4e91","weather_pic":"styles\/images\/icon2\/night\/2.png","humidity":"","tem":"1"}
        //            ]2Trying、

        //}
        //]]
        //}
        public string status { get; set; }
        public string detail { get; set; }
        public List<List<MoreDayWeatherInfoFullDay>> data { get; set; }
    }

    /// <summary>
    /// 全天天气
    /// </summary>

    public class MoreDayWeatherInfoFullDay
    {
        //"tem_min":"1","tem_max":"13","sunrise":"07:17","sunset":"17:12","pm":"63","air":"\u826f",
        public string date { get; set; }
        public string dis_id { get; set; }
        public string dis_name { get; set; }
        public string url { get; set; }
        public string weather { get; set; }
        public string wind { get; set; }
        public string weather_name { get; set; }
        public string weather_pic { get; set; }
        public string humidity { get; set; }
        public string tem_min { get; set; }
        public string tem_max { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string pm { get; set; }
        public string air { get; set; }
    }
}
