using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 查询信息实体类
    /// </summary>
    [Serializable]
    public class SearchInfo
    {
        #region 无中文描述构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public SearchInfo() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        public SearchInfo(string fieldName, object fieldValue, SqlOperator sqlOperator)
            : this(fieldName, fieldValue, sqlOperator, true)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public SearchInfo(string fieldName, object fieldValue, SqlOperator sqlOperator, bool excludeIfEmpty, string groupName)
        {
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.sqlOperator = sqlOperator;
            this.excludeIfEmpty = excludeIfEmpty;
            this.groupName = groupName;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        public SearchInfo(string fieldName, object fieldValue, SqlOperator sqlOperator, bool excludeIfEmpty)
            : this(fieldName, fieldValue, sqlOperator, excludeIfEmpty, null)
        { }
        

        #endregion

        #region 有字段中文说明构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段中文描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue, SqlOperator sqlOperator)
            : this(fieldName, fieldDescribe, fieldValue, sqlOperator,true)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段值描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue, SqlOperator sqlOperator, bool excludeIfEmpty)
            : this(fieldName, fieldDescribe, fieldValue, sqlOperator, excludeIfEmpty, null)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段值描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue, SqlOperator sqlOperator, bool excludeIfEmpty, string groupName)
        {
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.sqlOperator = sqlOperator;
            this.excludeIfEmpty = excludeIfEmpty;
            this.groupName = groupName;
            this.fieldDescribe = fieldDescribe;
        }
        
        #endregion

        #region 有字段中文说明构造函数且有字段值中文描述

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段中文描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="fieldValueDescribe">字段值中文描述</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue,string fieldValueDescribe, SqlOperator sqlOperator)
            : this(fieldName, fieldDescribe, fieldValue, fieldValueDescribe, sqlOperator,true)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段中文描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="fieldValueDescribe">字段值中文描述</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue, string fieldValueDescribe, SqlOperator sqlOperator, bool excludeIfEmpty)
            : this(fieldName, fieldDescribe, fieldValue, fieldValueDescribe, sqlOperator, excludeIfEmpty, null)
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段描述</param>
        /// <param name="fieldValue">字段的值</param>
        /// <param name="fieldValueDescribe">字段值中文描述</param>
        /// <param name="sqlOperator">字段的Sql操作符号</param>
        /// <param name="excludeIfEmpty">如果字段为空或者Null则不作为查询条件</param>
        /// <param name="groupName">分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件</param>
        public SearchInfo(string fieldName, string fieldDescribe, object fieldValue,string fieldValueDescribe, SqlOperator sqlOperator, bool excludeIfEmpty, string groupName)
        {
            this.fieldName = fieldName;
            this.fieldValue = fieldValue;
            this.sqlOperator = sqlOperator;
            this.excludeIfEmpty = excludeIfEmpty;
            this.groupName = groupName;
            this.fieldDescribe = fieldDescribe;
            this.fieldValueDescribe = fieldValueDescribe;
        }

        #endregion

        #region 字段属性
        private string fieldName;
        private object fieldValue;
        private SqlOperator sqlOperator;
        private bool excludeIfEmpty = true;
        private string groupName;
        private string fieldDescribe = string.Empty;
        private string fieldValueDescribe = string.Empty;

        /// <summary>
        /// 分组的名称，如需构造一个括号内的条件 ( Test = "AA1" OR Test = "AA2"), 定义一个组名集中条件
        /// </summary>
        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }


        /// <summary>
        /// 字段名称
        /// </summary>
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        /// <summary>
        /// 字段中文描述
        /// </summary>
        public string FieldDescribe
        {
            get { return fieldDescribe; }
            set { fieldDescribe = value; }
        }

        /// <summary>
        /// 字段的值
        /// </summary>
        public object FieldValue
        {
            get { return fieldValue; }
            set { fieldValue = value; }
        }

        
        /// <summary>
        /// 字段值中文描述
        /// </summary>
        public string FieldValueDEscribe
        {
            get { return fieldValueDescribe; }
            set { fieldValueDescribe = value; }
        }

        /// <summary>
        /// 字段的Sql操作符号
        /// </summary>
        public SqlOperator SqlOperator
        {
            get { return sqlOperator; }
            set { sqlOperator = value; }
        }

        /// <summary>
        /// 如果字段为空或者Null则不作为查询条件
        /// </summary>
        public bool ExcludeIfEmpty
        {
            get { return excludeIfEmpty; }
            set { excludeIfEmpty = value; }
        } 

        #endregion
    }

    /// <summary>
    /// Sql的查询符号
    /// </summary>
    public enum SqlOperator
    {
        /// <summary>
        /// Like 模糊查询
        /// </summary>
        [Description("包含模糊查询,如:Like '%ABC%'")]
        Like,

        /// <summary>
        /// Not LiKE 模糊查询
        /// </summary>
        [Description("不包含模糊查询,如:Not Like '%ABC%'")]
        NotLike,

        /// <summary>
        /// Like 开始匹配模糊查询，如Like 'ABC%'
        /// </summary>
        [Description("左包含模糊查询,如:Like 'ABC%'")]
        LikeStartAt,

        /// <summary>
        /// ＝ 等于号 
        /// </summary>
        [Description("等于查询,如:abc='123'")]
        Equal,

        /// <summary>
        /// ＜＞ (≠) 不等于号
        /// </summary>
        [Description("不等于查询,如:abc<>'123'")]
        NotEqual,

        /// <summary>
        /// ＞ 大于号
        /// </summary>
        [Description("大于查询,如:abc>100")]
        MoreThan,

        /// <summary>
        /// ＜ 小于号 
        /// </summary>
        [Description("小于查询,如:abc<100")]
        LessThan,

        /// <summary>
        /// ≥大于或等于号 
        /// </summary>
        [Description("大于或等于号查询,如:abc>=100")]
        MoreThanOrEqual,

        /// <summary>
        /// ≤ 小于或等于号
        /// </summary>
        [Description("小于或等于号查询,如:abc<=100")]
        LessThanOrEqual,

        /*       
        /// <summary>
        /// 在某个值的中间，拆成两个符号 >= 和 <=
        /// </summary>
        Between,
        */

        /// <summary>
        /// 在某个字符串值中
        /// </summary>
        [Description("在某个结果集中,In查询,如:abc in ('1','2','3')")]
        In,

        /// <summary>
        /// Like 结尾匹配模糊查询，如Like '%ABC'
        /// </summary>
        [Description("右包含查询,如:Like '%ABC'")]
        LikeEndAt

    }
}
