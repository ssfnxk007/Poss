﻿using CommonsHelper;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;

namespace POSS
{
    public partial class OperatorsFrom : BaseDock
    {
        public OperatorsFrom()
        {
            InitializeComponent();
        }

        private void OperatorsFrom_Load(object sender, EventArgs e)
        {
            InitDropDown();
            //this.cb_isword.Enabled = false;
            ////this.cb_oper.Enabled = false;
            //this.cb_sl.Enabled = false;
            //this.cb_stand.Enabled = false;
            //this.cb_station.Enabled = false;
            //this.cb_stock.Enabled = false;
            //this.cb_zk.Enabled = false;
            //this.cb_zl.Enabled = false;
            //this.tb_pass.Enabled = false;
        }



        /// <summary>
        /// 下拉框加载事件
        /// </summary>
        public void InitDropDown()
        {
            cb_oper.DisplayMember = "O_name";
            cb_oper.ValueMember = "O_id";
            cb_oper.DataSource = UserHelper.GetO_id();//员工

            cb_station.DisplayMember = "Station_name";
            cb_station.ValueMember = "Station_id";
            cb_station.DataSource = UserHelper.Get_Station_id();//站点

            cb_stock.DisplayMember = "S_name";
            cb_stock.ValueMember = "S_ID";
            cb_stock.DataSource = UserHelper.Get_Stock();//库房

            cb_stand.DisplayMember = "Stand_name";
            cb_stand.ValueMember = "Stand_id";
            cb_stand.DataSource = UserHelper.Get_Stand();//零售台号


            cb_isword.DisplayMember = "项目值";
            cb_isword.ValueMember = "显示值";
            cb_isword.DataSource = UserHelper.Get_y_n();//是或否

            cb_zk.DisplayMember = "项目值";
            cb_zk.ValueMember = "显示值";
            cb_zk.DataSource = UserHelper.Get_y_n();//是或否

            cb_sl.DisplayMember = "项目值";
            cb_sl.ValueMember = "显示值";
            cb_sl.DataSource = UserHelper.Get_y_n();//是或否

            cb_zl.DisplayMember = "项目值";
            cb_zl.ValueMember = "显示值";
            cb_zl.DataSource = UserHelper.Get_y_n();//是或否
        }

        public bool SAVEUSER()
        {
            bool restult = false;
            if (cb_oper.SelectedIndex == 0 || cb_station.SelectedIndex == 0 || cb_stand.SelectedIndex == 0)//保存检查
            {
                MessagboxUit.ShowTips("不能为空");
                restult = false;
            }
            else
            {
                UsersInfo u = new UsersInfo();
                u.O_id = this.cb_oper.SelectedValue.ToString();
                u.Is_word = this.cb_isword.SelectedValue.ToString();
                u.O_name = this.cb_oper.Text.ToString();
                u.Station_id = this.cb_station.SelectedValue.ToString();
                u.Stock_id = this.cb_stock.SelectedValue.ToString();
                u.Yh_stand_id = this.cb_stand.SelectedValue.ToString();
                u.Passwd = this.tb_pass.Text.ToString();
                u.Is_sl = this.cb_sl.SelectedValue.ToString();
                u.Is_zk = this.cb_zk.SelectedValue.ToString();
                u.Is_zl = this.cb_zl.SelectedValue.ToString();
                if (UserHelper.SaveUsers(u))
                {
                    MessagboxUit.ShowTips("保存成功！");
                    restult = true;
                }
                else
                {
                    MessagboxUit.ShowError("保存失败！");
                    restult = false;
                }

            }
            return restult;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SAVEUSER();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void cb_oper_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersInfo k = BLLFactory<Users>.Instance.FindByID(this.cb_oper.SelectedValue.ToString().Trim());
            if (k == null) return;
            //this.cb_isword.Enabled = true;
            ////this.cb_oper.Enabled = true;
            //this.cb_sl.Enabled = true;
            //this.cb_stand.Enabled = true;
            //this.cb_station.Enabled = true;
            //this.cb_stock.Enabled = true;
            //this.cb_zk.Enabled = true;
            //this.cb_zl.Enabled = true;
            //this.tb_pass.Enabled = true;


            this.cb_oper.SelectedValue = k.O_id;
            this.cb_sl.SelectedValue = k.Is_sl;
            this.cb_stand.SelectedValue = k.Yh_stand_id;
            this.cb_station.SelectedValue = k.Station_id;
            this.cb_stock.SelectedValue = k.Stock_id;
            this.cb_zk.SelectedValue = k.Is_zk;
            this.cb_zl.SelectedValue = k.Is_zl;
            this.cb_isword.SelectedValue = k.Is_word;
            this.tb_pass.Text = k.Passwd;
        }
    }
}
