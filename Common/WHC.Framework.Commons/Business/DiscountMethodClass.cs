using System.ComponentModel;
/// <summary>
/// 折扣类别
/// </summary>
public enum DiscountMethodClass
{ 
    /// <summary>
    /// 未知
    /// </summary>
    [Description("未知")]
    None=0,

    /// <summary>
    /// 进货折扣策略
    /// </summary>
    [Description("进货折扣策略")]
    JHDiscountMehtod =2,

    /// <summary>
    /// 销售折扣策略
    /// </summary>
    [Description("销售折扣策略")]
    XSDiscountMehtod=1,

    /// <summary>
    /// 零售折扣策略
    /// </summary>
    [Description("零售折扣策略")]
    LSDiscountMehtod=3,

    /// <summary>
    /// 网购折扣策略
    /// </summary>
    [Description("网购折扣策略")]
    WGDiscountMehtod=4,
}