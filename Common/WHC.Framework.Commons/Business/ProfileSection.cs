using System.ComponentModel;
/// <summary>
/// 系统配置Section
/// </summary>
public enum ProfileSection
{
    /// <summary>
    /// 未知
    /// </summary>
    [Description("未知")]
    None,

    /// <summary>
    /// 常规参数配置
    /// </summary>
    [Description("常规参数配置")]
    ParmConfig,

    /// <summary>
    /// 其它参数配置
    /// </summary>
    [Description("其它参数配置")]
    OtherParm,


    /// <summary>
    /// 储值卡参数
    /// </summary>
    [Description("储值卡参数")]
    PrepaidCardParm,
    /// <summary>
    /// 读者参数
    /// </summary>
    [Description("读者参数配置")]
    ReadParm
}
