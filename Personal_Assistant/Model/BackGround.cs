using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace SweetWeather.Model
{
    public class BackGround : NotificationObject, IDataErrorInfo
    {
        /// <summary>
        /// 路径
        /// </summary>
        private string path;
        public string Path
        {
            get { return path; }
            set
            {
                path = value;
                this.RaisePropertyChanged("Path");
            }
        }

        /// <summary>
        /// 默认主题
        /// </summary>
        private string themes;
        public string Themes
        {
            get { return themes; }
            set
            {
                themes = value;
                this.RaisePropertyChanged("Themes");
            }
        }

        /// <summary>
        /// 当前城市
        /// </summary>
        private City currentCity;
        public City CurrentCity
        {
            get { return currentCity; }
            set
            {
                currentCity = value;
                this.RaisePropertyChanged("CurrentCity");
            }
        }



        /// <summary>
        /// 自动刷新时间
        /// </summary>
        private string refreshMin;
        public string RefreshMin
        {
            get { return refreshMin; }
            set
            {
                refreshMin = value;
                this.RaisePropertyChanged("RefreshMin");
            }
        }

        /// <summary>
        /// 上次刷新时间
        /// </summary>
        private DateTime lastUpdateTime;
        public DateTime LastUpdateTime
        {
            get { return lastUpdateTime; }
            set { lastUpdateTime = value; this.RaisePropertyChanged("LastUpdateTime"); }
        }


        /// <summary>
        /// 是否自启动
        /// </summary>
        private bool isAutoOpen;
        public bool IsAutoOpen
        {
            get { return isAutoOpen; }
            set
            {
                isAutoOpen = value;
                this.RaisePropertyChanged("IsAutoOpen");
            }
        }

        public string Error
        {
            get { return null; }
        }
        public List<string> ErrorList = new List<string>();
        public string this[string columnName]
        {
            get
            {
                if (columnName == "RefreshMin")
                {
                    var refresh = 0;
                    if (!int.TryParse(RefreshMin, out refresh) || (refresh <= 0 || refresh > 9999))
                    {
                        if (!ErrorList.Contains("RefreshMin"))
                            ErrorList.Add("RefreshMin");
                        return "请输入正确的分钟";
                    }
                    else
                    {
                        if (ErrorList.Contains("RefreshMin"))
                            ErrorList.Remove("RefreshMin");
                        return null;
                    }
                }
                else
                    return null;
            }
        }
    }
}
