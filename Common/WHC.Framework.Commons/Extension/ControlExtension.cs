using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
namespace WHC.Framework.Commons
{
    /// <summary>
    /// 控件扩展
    /// </summary>
    public static class ControlExtension
    {
        /// <summary>
        /// LookUpEdit数据绑定
        /// </summary>
        /// <param name="lookupedit">LookUpEdit控件</param>
        /// <param name="displayMember">显示成员</param>
        /// <param name="valueMember">数据成员</param>
        /// <param name="dt">需要绑定的DataTable</param>
        public static void BindData(this DevExpress.XtraEditors.LookUpEdit lookupedit, string displayMember, string valueMember, DataTable dt)
        {
            lookupedit.Properties.DisplayMember = displayMember;
            lookupedit.Properties.ValueMember = valueMember;
            lookupedit.Properties.DataSource = dt;

        }

       


    }
}
