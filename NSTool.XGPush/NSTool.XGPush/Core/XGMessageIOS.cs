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

    /// <summary>
    /// ios 消息 aps, 
    /// 如需badge、sound 字段，可从此类派生
    /// </summary>
    public class APS
    {
        public APSAlert alert { get; set; }
    }

    /// <summary>
    /// ios消息 alert
    /// 如需 更多字段，请从此类派生，对于loc-key之类有“-”符号的属性，还应实现自定义的序列化方法
    /// </summary>
    public class APSAlert
    {
        public string body{get;set;}
    }
}
