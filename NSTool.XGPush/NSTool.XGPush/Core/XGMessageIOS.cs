using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSTool.XGPush.Core
{
    /// <summary>
    /// 推送消息格式定义 IOS
    /// 如须扩展字段，请从此类派生
    /// </summary>
    public class XGMessageIOS:XGMessage
    {
        public APS aps { get; set; }
    }

    public class APS
    {
        public APSAlert alert { get; set; }
    }

    public class APSAlert
    {
        public string body{get;set;}

        public string title{get;set;}
    }
}
