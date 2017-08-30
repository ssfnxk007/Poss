using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 扩展函数封装
    /// </summary>
    public static class ExtensionMethod
    {
        #region 日期操作

        /// <summary>
        /// 获取时间的显示内容，如果小于默认时间（1900-1-1），则为空
        /// </summary>
        /// <param name="dateTime">时间对象</param>
        /// <param name="formatString">默认格式为yyyy-MM-dd</param>
        /// <returns></returns>
        public static string GetDateTimeString(this DateTime dateTime, string formatString = "yyyy-MM-dd")
        {
            string result = "";
            if (dateTime > Convert.ToDateTime("1900-1-1"))
            {
                result = dateTime.ToString(formatString);
            }
            return result;
        }

        /// <summary>
        /// 添加开始日期和结束日期的查询操作
        /// </summary>
        /// <param name="condition">SearchCondition对象</param>
        /// <param name="fieldName">字段名称</param>
        /// <param name="startCtrl">开始日期控件</param>
        /// <param name="endCtrl">结束日期控件</param>
        /// <returns></returns>
        public static SearchCondition AddDateCondition(this SearchCondition condition, string fieldName, DateTimePicker startCtrl, DateTimePicker endCtrl)
        {
            if (startCtrl.Text.Length > 0)
            {
                condition.AddCondition(fieldName, startCtrl.Value, SqlOperator.MoreThanOrEqual);
            }
            if (endCtrl.Text.Length > 0)
            {
                condition.AddCondition(fieldName, endCtrl.Value.AddDays(1), SqlOperator.LessThan);
            }
            return condition;
        }

        /// <summary>
        /// 添加开始日期和结束日期的查询操作
        /// </summary>
        /// <param name="condition">SearchCondition对象</param>
        /// <param name="fieldName">字段名称</param>
        /// <param name="fieldDescribe">字段中文描述</param>
        /// <param name="startCtrl">开始日期控件</param>
        /// <param name="endCtrl">结束日期控件</param>
        /// <returns></returns>
        public static SearchCondition AddDateCondition(this SearchCondition condition, string fieldName, string fieldDescribe, DateTimePicker startCtrl, DateTimePicker endCtrl)
        {
            if (startCtrl.Text.Length > 0)
            {
                condition.AddCondition(fieldName,fieldDescribe, startCtrl.Value, SqlOperator.MoreThanOrEqual);
            }
            if (endCtrl.Text.Length > 0)
            {
                condition.AddCondition(fieldName,fieldDescribe, endCtrl.Value.AddDays(1), SqlOperator.LessThan);
            }
            return condition;
        } 
        #endregion

        #region ComboBoxEdit控件

        /// <summary>
        /// 获取下拉列表的值
        /// </summary>
        /// <param name="combo">下拉列表</param>
        /// <returns></returns>
        public static string GetComboBoxValue(this ComboBox combo)
        {
            CListItem item = combo.SelectedItem as CListItem;
            if (item != null)
            {
                return item.Value;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 设置下拉列表选中指定的值
        /// </summary>
        /// <param name="combo">下拉列表</param>
        /// <param name="value">指定的CListItem中的值</param>
        public static void SetComboBoxItem(this ComboBox combo, string value)
        {
            for (int i = 0; i < combo.Items.Count; i++)
            {
                CListItem item = combo.Items[i] as CListItem;
                if (item != null && item.Value == value)
                {
                    combo.SelectedIndex = i;
                }
            }
        }

        /// <summary>
        /// 绑定下拉列表控件为指定的数据字典列表
        /// </summary>
        /// <param name="combo">下拉列表控件</param>
        /// <param name="dictTypeName">数据字典类型名称</param>
        public static void BindDictItems(this ComboBox combo, Dictionary<string, string> dict)
        {
            combo.Items.Clear();
            foreach (string key in dict.Keys)
            {
                combo.Items.Add(new CListItem(key, dict[key]));
            }
        }

        #endregion



    }
}
