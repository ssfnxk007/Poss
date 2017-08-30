/// <summary>
/// 价格类别
/// </summary>
public enum PriceClass
{
    /// <summary>
    /// 定价
    /// </summary>
    OutPutPrice = 0,
    /// <summary>
    /// 零售价
    /// </summary>
    RetailPrice = 1,
    /// <summary>
    /// 批发价
    /// </summary>
    WholesalePrice = 2,
    /// <summary>
    /// 会员价
    /// </summary>
    MemberPrice = 3,
    /// <summary>
    /// 定价,但为零时不处理
    /// </summary>
    OutPutPriceIgnoreZero = 4

}