/// <summary>
/// 单据状态
/// </summary>
public enum BillState
{ 
    /// <summary>
    /// 未知状态
    /// </summary>
    UnKnow=0,

    /// <summary>
    /// 可修改状态
    /// </summary>
    Modifying=1,

    /// <summary>
    /// 已保存状态,但不可修改
    /// </summary>
    Saved=2,

    /// <summary>
    /// 已审核状态
    /// </summary>
    Verifyed=3,

    /// <summary>
    /// 已出,入库状态
    /// </summary>
    StockArreared=4,

    /// <summary>
    /// 已承收,付状态
    /// </summary>
    MoneyArreared=5,

    /// <summary>
    /// 已作废状态
    /// </summary>
    Destroyed=6,

    /// <summary>
    /// 已财务审核状态
    /// </summary>
    FaniceVerifyed=7,

    /// <summary>
    /// 已还原状态
    /// </summary>
    Restoreed=8,
    /// <summary>
    /// 应用
    /// </summary>
    Avoided=9,
    

}