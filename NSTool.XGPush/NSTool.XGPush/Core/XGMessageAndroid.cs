using Newtonsoft.Json;
using NSTool.XGPush.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSTool.XGPush.Core
{
    /// <summary>
    /// 推送消息格式定义 Android
    /// </summary>
    [Serializable]
    public class XGMessageAndroid:XGMessage
    {
        private string title;

        /// <summary>
        /// 标题，必填
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string content;

        /// <summary>
        /// 内容，必填
        /// </summary>
        [JsonProperty("content")]
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private SerializableDictionary<string, string> custom_content;

        /// <summary>
        /// 用户自定义的key-value，选填
        /// </summary>
        [JsonProperty("custom_content")]
        public SerializableDictionary<string, string> Custom_content
        {
            get { return custom_content; }
            set { custom_content = value; }
        }
    }
}
