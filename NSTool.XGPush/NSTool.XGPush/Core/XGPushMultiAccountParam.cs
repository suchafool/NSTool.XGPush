using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSTool.XGPush.Core
{

    /// <summary>
    /// Push消息（包括通知和透传消息）给多个账户
    /// created by suchafool, 2015-8-4
    /// </summary>
    public class XGPushMultiAccountParam : XGPushParamBase
    {

        public List<string> Account_list
        {
            get;
            set;
        }
    }
}
