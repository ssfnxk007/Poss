
namespace WHC.Framework.Commons
{
    /// <summary>
    /// 历史折扣方法
    /// </summary>
    public enum HistoryDiscountMethod
    { 
        /// <summary>
        /// 最大折扣
        /// </summary>
        MAX=0,

        /// <summary>
        /// 最小折扣
        /// </summary>
        MIN=1,

        /// <summary>
        /// 第一次折扣
        /// </summary>
        TOP=2,


        /// <summary>
        /// 最后一次折扣
        /// </summary>
        REC=3,

        /// <summary>
        /// 统一折扣(绝对折扣)
        /// </summary>
        TY=4,
        
    }
}
