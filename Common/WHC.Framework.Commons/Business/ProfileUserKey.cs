using System.ComponentModel;
/// <summary>
/// 系统配置UserKey
/// </summary>
public enum ProfileUserKey
{
    /// <summary>
    /// 未知
    /// </summary>
    [Description("未知")]
    None,

    #region 进货相关
    /// <summary>
    /// 商品到货折扣方式
    /// </summary>
    [Description("商品到货折扣方式")]
    ProductInDiscountValue, 

    /// <summary>
    /// 零折扣允许入库
    /// </summary>
    [Description("零折扣允许入库")]
    ZeroDiscountAllowIn,

    #endregion

    #region 要货相关
    /// <summary>
    /// 要货查询天数
    /// </summary>
    [Description("要货查询天数")]
    YHDays, 
    #endregion

    #region 销售订单
    /// <summary>
    /// 销售订单启用包销代销
    /// </summary>
    OrderBxDx ,

    /// <summary>
    /// 批销发货允许生成调剂单
    /// </summary>
    AllowPxToTj,
    #endregion

    #region 储值卡参数
    /// <summary>
    /// 储值卡默认有效天数
    /// </summary>
    [Description("储值卡默认有效天数")]
    PrepaidDefaultValidDays,
    #endregion

    #region 订单拣货参数
    
    /// <summary>
    /// 订单转批销时自动审核
    /// </summary>
    [Description("订单转批销时自动审核")]
    SdToPxAutoVerify,


    /// <summary>
    /// 订单转调剂时自动审核
    /// </summary>
    [Description("订单转调剂时自动审核")]
    SdToTjAutoVerify,


    /// <summary>
    /// 订单留库时自动审核
    /// </summary>
    [Description("订单留库时自动审核")]
    SdToLkAutoVerify,
    #endregion

    #region 本地价格控制
    /// <summary>
    /// 启用商品的本地价格,当选择本项时,系统会自动将当前数据库中的销售价格与销售折扣(包含零售/会员/批销)更新到配送出库单的明细表中,用户可以手工任意修改本价格与折扣,并且数据传到分店后本品种的销售价格与折扣将以配送出库单上的设置为准,这种设置可以实现品种在不同的分店有不同的价格,不建议选择
    /// </summary>
    [Description("当选择本项时,系统会自动将当前数据库中的销售价格与销售折扣(包含零售/会员/批销)更新到配送出库单的明细表中,用户可以手工任意修改本价格与折扣,并且数据传到分店后本品种的销售价格与折扣将以配送出库单上的设置为准,这种设置可以实现品种在不同的分店有不同的价格,不建议选择")]
    EnableLocalPrice ,
    #endregion

    #region 零售参数
    /// <summary>
    /// 零售输入会员时隐藏输入内容
    /// </summary>
    HideInputCardID,


    /// <summary>
    /// 零售会员检索内容
    /// </summary>
    MemberRetriveType,

    /// <summary>
    /// 会员积分比例
    /// </summary>
    MemberIntegralRate,

    /// <summary>
    /// 会员零售时，隐藏会员的详细信息，如：张三显示为：*三  
    /// </summary>
    HideMemberDetailInfo,

    #endregion

    #region 读者查询
    /// <summary>
    /// 读者卖场示意图
    /// </summary>
    SketchMapFilePath,
    /// <summary>
    /// 读者卖场消防示意图
    /// </summary>
    FireFightMapPath,

    /// <summary>
    /// 广告切换时间
    /// </summary>
    ScrollTimerInterval,
    #endregion

    #region 发票类型 
    /// <summary>
    /// 默认发票类型  默认为收据
    /// </summary>
    [Description("默认发票类型")]
    InvoicesType, 
    #endregion

    #region 调剂入库
    /// <summary>
    /// 默认发票类型  默认为收据
    /// </summary>
    [Description("启用调剂入库后自动冻结库存")]
    TJRK_AUTOHANDOUT,
    #endregion

    #region 调剂出库
    /// <summary>
    /// 调剂出库价决定调入方成本价格
    /// </summary>
    [Description("调剂出库价决定调入方成本价格")]
    tjck_discount,
    /// <summary>
    ///  启用调剂单双向账务
    /// </summary>
    [Description(" 启用调剂单双向账务")]
    tj_doublearrear,
    #endregion





}
