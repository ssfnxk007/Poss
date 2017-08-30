using System.ComponentModel;

namespace WHC.Framework.Commons
{
    public enum RetailClass
    {
        /// <summary>
        /// 未知
        /// </summary>
        [Description("未知")]
        UnKnow,

        /// <summary>
        /// 在线零售
        /// </summary>
         [Description("在线方式")]
        OnLine,

        /// <summary>
        /// 离线零售
        /// </summary>
         [Description("离线方式")]
        OffLine
    }
}
