﻿using POSS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.ControlUtil;
using CommonsHelper;
using POSS.Entity;
namespace POSS
{
    public partial class FormQueryLs : BaseDockQuery
    {
        List<DanBanQueryInfo> banbanlist =new List<DanBanQueryInfo>();

        public FormQueryLs()
        {
            InitializeComponent();
            this.winGridView1.GridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
            this.winGridView1.GridView1.CustomDrawCell += GridView1_CustomDrawCell;
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("YuBeiLingQian", "c2","预备金:"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("JiaoKuanMoney", "c2","交款金:"));
            this.winGridView1.SumItem.Add(Guid.NewGuid(), new WHC.Pager.WinControl.FooterItem("Feiyong", "c2","费用:"));
        }

        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.FieldName == "Is_Jk" && e.CellValue.ToString() != "1")
            {
                e.Appearance.BackColor = Color.Red;
            }
            else if(e.Column.FieldName == "Is_Jk" && e.CellValue.ToString() == "1")
            {
                e.Appearance.BackColor =  Color.GreenYellow;
            }
        }

        private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Is_Jk" && e.Value != null)
            {
                if (e.Value.ToString() == "1")
                {
                    e.DisplayText = "已交班";
                    
                }
                else
                {
                    e.DisplayText = "未交班";
                }
            }
        }

        private void SetDisplayColumn()
        {
            this.winGridView1.DisplayColumns = "DanBan_Date,O_name,DangBan_DateTime,YuBeiLingQian,JiaoKuanMoney,Is_Jk,Station_name,Feiyong,Beizhu";
        }
        private void AddColumnAlias()
        {
            winGridView1.AddColumnAlias("DanBan_Date", "当班日期");
            winGridView1.AddColumnAlias("O_name", "员工名称");
            winGridView1.AddColumnAlias("DangBan_DateTime", "上班日期");
            winGridView1.AddColumnAlias("YuBeiLingQian", "预备金额");
            winGridView1.AddColumnAlias("JiaoKuanMoney", "交款金额");
            winGridView1.AddColumnAlias("Is_Jk", "是否交款");
            winGridView1.AddColumnAlias("Station_name", "站点名称");
            winGridView1.AddColumnAlias("Feiyong", "费用");
            winGridView1.AddColumnAlias("Beizhu", "备注");

        }
        private void AddGridViewReadOnly()
        {
            this.winGridView1.ReadOnlyList.Add("DanBan_Date");
            this.winGridView1.ReadOnlyList.Add("O_name");
            this.winGridView1.ReadOnlyList.Add("DangBan_DateTime");
            this.winGridView1.ReadOnlyList.Add("YuBeiLingQian");
            this.winGridView1.ReadOnlyList.Add("JiaoKuanMoney");
            this.winGridView1.ReadOnlyList.Add("Is_Jk");
            this.winGridView1.ReadOnlyList.Add("Station_name");
            this.winGridView1.ReadOnlyList.Add("Feiyong");
            this.winGridView1.ReadOnlyList.Add("Beizhu");
        }

        private void SetDisplayFormat()
        {

            winGridView1.GridView1.Columns["YuBeiLingQian"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["YuBeiLingQian"].DisplayFormat.FormatString = "c2";
            //winGridView1.GridView1.Columns["CH_output_Price_ls"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            //winGridView1.GridView1.Columns["CH_output_Price_ls"].DisplayFormat.FormatString = "c2";
            winGridView1.GridView1.Columns["JiaoKuanMoney"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["JiaoKuanMoney"].DisplayFormat.FormatString = "c2";
            winGridView1.GridView1.Columns["Feiyong"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            winGridView1.GridView1.Columns["Feiyong"].DisplayFormat.FormatString = "c2";
            

        }
        public void SetDripDownitem()
        {

            this.c_oper.Properties.DisplayMember = "显示值";
            this.c_oper.Properties.ValueMember = "项目值";
            c_oper.Properties.DataSource = BLLFactory<Users>.Instance.GetUsers();

           
        }
        private void SetDataSource()
        {
            
            this.winGridView1.DataSource = banbanlist;
            SetDisplayFormat();


        }

        private void FormQueryLs_Load(object sender, EventArgs e)
        {
            SetDisplayColumn();
            AddGridViewReadOnly();
            AddColumnAlias();
            SetDripDownitem();
            SetDataSource();
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            
            string where = string.Empty;
            List<string> wheres = new List<string>();
            if (!string.IsNullOrEmpty(c_oper.Text.ToString()))
            {
                wheres.Add(" o_id = '" + c_oper.EditValue.ToString().Trim() + "'");
            }
            if (!string.IsNullOrEmpty(c_datetime.StartDate.ToString()))
            {
                wheres.Add(" DangBan_DateTime between  '" + c_datetime.StartDate.ToString().Trim() + "' and '" + c_datetime.EndDate.ToString().Trim() + "'");
            }
            if (wheres.Count > 0)
            {
                string wh = string.Join(" and ", wheres.ToArray());
                //strSql.Append(" where " + wh);
                where = wh.ToString();
            }

            banbanlist.Clear();
            banbanlist.AddRange(BLLFactory<DangBan>.Instance.GetDanBanInfo(where));
            this.winGridView1.GridView1.RefreshData();
            // SetDisplayFormat();
        }
    }
}
