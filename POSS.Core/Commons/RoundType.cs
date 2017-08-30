using System.ComponentModel;
/// <summary>
/// 人民币四舍五入方式
/// </summary>
public enum RoundType
{
    /// <summary>
    /// 不处理
    /// </summary>
    [Description("不处理")]
    None=0,

    /// <summary>
    /// 四舍五入到拾元
    /// </summary>
    [Description("四舍五入到拾元")]
    RoundToShiYuan=1,

    /// <summary>
    /// 四舍五入到元
    /// </summary>
    [Description("四舍五入到元")]
    RoundToYuan=2,

    /// <summary>
    /// 四舍五入到角
    /// </summary>
    [Description("四舍五入到角")]
    RoundToJiao=3,

    /// <summary>
    /// 向上取整到拾元
    /// </summary>
    [Description("向上取整到拾元")]
    MaxToShiYuan=4,

    /// <summary>
    /// 向上取整到元
    /// </summary>
    [Description("向上取整到元")]
    MaxToYuan=5,

    /// <summary>
    /// 向上取整到角
    /// </summary>
    [Description("向上取整到角")]
    MaxToJiao=6,

    /// <summary>
    /// 向下取整到拾元
    /// </summary>
    [Description("向下取整到拾元")]
    MinToShiYuan=7,

    /// <summary>
    /// 向下取整到元
    /// </summary>
    [Description("向下取整到元")]
    MinToYuan = 8,

    /// <summary>
    /// 向下取整到角
    ///</summary>
    [Description("向下取整到角")]
    MinToJiao=9,

    /// <summary>
    /// 银行家舍入法到拾元
    /// </summary>
    [Description("银行家舍入法到拾元")]
    BRMToShiYuan=10,

    /// <summary>
    /// 银行家舍入法到元
    /// </summary>
    [Description("银行家舍入法到元")]
    BRMToYuan=11,

    /// <summary>
    /// 银行家舍入法到角
    /// </summary>
    [Description("银行家舍入法到角")]
    BRMToJiao=12


}
