

/// <summary>
/// 零售批号提交状态
/// </summary>
public enum PhCommitStatus
{ 
    /// <summary>
    /// 未知状态(错误的状态)
    /// </summary>
    UnKnown =0,

    /// <summary>
    /// 挂起
    /// </summary>
    Suspend =1,

    /// <summary>
    /// 运行
    /// </summary>
    Running =2,

    /// <summary>
    /// 过帐
    /// </summary>
    Verifyed =3,

    /// <summary>
    /// 作废
    /// </summary>
    Destroyed =4

    
}