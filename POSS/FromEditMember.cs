using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
namespace POSS
{
   public class FromEditMember:BaseEditForm
    {


        private CordInputFrom formm_poss = null;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtM_age = new DevExpress.XtraEditors.TextEdit();
            this.txtM_name = new DevExpress.XtraEditors.TextEdit();
            this.txtM_adress = new DevExpress.XtraEditors.TextEdit();
            this.txtM_tel = new DevExpress.XtraEditors.TextEdit();
            this.txtM_birthday = new DevExpress.XtraEditors.DateEdit();
            this.txtM_ic = new DevExpress.XtraEditors.TextEdit();
            this.txtM_email = new DevExpress.XtraEditors.TextEdit();
            this.txtMemo = new DevExpress.XtraEditors.TextEdit();
            this.txtM_password = new DevExpress.XtraEditors.TextEdit();
            this.txtM_help_input = new DevExpress.XtraEditors.TextEdit();
            this.txtM_corporation = new DevExpress.XtraEditors.TextEdit();
            this.txtM_zip = new DevExpress.XtraEditors.TextEdit();
            this.txtCard_id = new DevExpress.XtraEditors.TextEdit();
            this.txtJoin_date = new DevExpress.XtraEditors.DateEdit();
            this.txtEnd_date = new DevExpress.XtraEditors.DateEdit();
            this.txtM_id = new DevExpress.XtraEditors.TextEdit();
            this.txtM_address_song = new DevExpress.XtraEditors.TextEdit();
            this.txtM_station = new DevExpress.XtraEditors.TextEdit();
            this.txtM_zip_song = new DevExpress.XtraEditors.TextEdit();
            this.txtM_department_song = new DevExpress.XtraEditors.TextEdit();
            this.txtM_name_accept = new DevExpress.XtraEditors.TextEdit();
            this.txtM_introduce = new DevExpress.XtraEditors.TextEdit();
            this.txtM_mobile = new DevExpress.XtraEditors.TextEdit();
            this.txtM_fax = new DevExpress.XtraEditors.TextEdit();
            this.txtSum_date = new DevExpress.XtraEditors.DateEdit();
            this.txtStation_id = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.txtM_type = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_zy = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_sex = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_send_letter = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLs_flag = new DevExpress.XtraEditors.LookUpEdit();
            this.txtJy_flag = new DevExpress.XtraEditors.LookUpEdit();
            this.txtYg_flag = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_mobile_type = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_join_type = new DevExpress.XtraEditors.LookUpEdit();
            this.txtO_id_charge = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFocus_flag = new DevExpress.XtraEditors.LookUpEdit();
            this.txtStation_id_yg = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem42 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem44 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem68 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem43 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem41 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem61 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem45 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem46 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem63 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem64 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem66 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtM_degree = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_national = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_zw = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_native = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_income = new DevExpress.XtraEditors.LookUpEdit();
            this.txtActive_flag = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_arears = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_province = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtM_city = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtInput_date = new DevExpress.XtraEditors.TextEdit();
            this.txtLast_mod_date = new DevExpress.XtraEditors.TextEdit();
            this.txtM_period = new DevExpress.XtraEditors.LookUpEdit();
            this.txtO_id_input = new DevExpress.XtraEditors.LookUpEdit();
            this.txtO_id_modify = new DevExpress.XtraEditors.LookUpEdit();
            this.txtM_ziye = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem51 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem52 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem48 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem49 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem47 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem50 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnFeedback = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ask = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_ic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_help_input.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_corporation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJoin_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJoin_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_address_song.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_station.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zip_song.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_department_song.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name_accept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_introduce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_mobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_sex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_send_letter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLs_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJy_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYg_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_mobile_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_join_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_charge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFocus_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id_yg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_degree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_national.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_native.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_income.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_arears.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_province.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_city.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast_mod_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_period.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_input.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_modify.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_ziye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 438);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 438);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 440);
            this.btnAdd.Visible = false;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Location = new System.Drawing.Point(1, 429);
            // 
            // picPrint
            // 
            this.picPrint.Location = new System.Drawing.Point(205, 436);
            this.picPrint.Visible = false;
            // 
            // dataViewNavigator1
            // 
            this.dataViewNavigator1.Location = new System.Drawing.Point(7, 438);
            this.dataViewNavigator1.Size = new System.Drawing.Size(192, 25);
            this.dataViewNavigator1.Visible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.txtM_age);
            this.layoutControl1.Controls.Add(this.txtM_name);
            this.layoutControl1.Controls.Add(this.txtM_adress);
            this.layoutControl1.Controls.Add(this.txtM_tel);
            this.layoutControl1.Controls.Add(this.txtM_birthday);
            this.layoutControl1.Controls.Add(this.txtM_ic);
            this.layoutControl1.Controls.Add(this.txtM_email);
            this.layoutControl1.Controls.Add(this.txtMemo);
            this.layoutControl1.Controls.Add(this.txtM_password);
            this.layoutControl1.Controls.Add(this.txtM_help_input);
            this.layoutControl1.Controls.Add(this.txtM_corporation);
            this.layoutControl1.Controls.Add(this.txtM_zip);
            this.layoutControl1.Controls.Add(this.txtCard_id);
            this.layoutControl1.Controls.Add(this.txtJoin_date);
            this.layoutControl1.Controls.Add(this.txtEnd_date);
            this.layoutControl1.Controls.Add(this.txtM_id);
            this.layoutControl1.Controls.Add(this.txtM_address_song);
            this.layoutControl1.Controls.Add(this.txtM_station);
            this.layoutControl1.Controls.Add(this.txtM_zip_song);
            this.layoutControl1.Controls.Add(this.txtM_department_song);
            this.layoutControl1.Controls.Add(this.txtM_name_accept);
            this.layoutControl1.Controls.Add(this.txtM_introduce);
            this.layoutControl1.Controls.Add(this.txtM_mobile);
            this.layoutControl1.Controls.Add(this.txtM_fax);
            this.layoutControl1.Controls.Add(this.txtSum_date);
            this.layoutControl1.Controls.Add(this.txtStation_id);
            this.layoutControl1.Controls.Add(this.txtM_type);
            this.layoutControl1.Controls.Add(this.txtM_zy);
            this.layoutControl1.Controls.Add(this.txtM_sex);
            this.layoutControl1.Controls.Add(this.txtM_send_letter);
            this.layoutControl1.Controls.Add(this.txtLs_flag);
            this.layoutControl1.Controls.Add(this.txtJy_flag);
            this.layoutControl1.Controls.Add(this.txtYg_flag);
            this.layoutControl1.Controls.Add(this.txtM_mobile_type);
            this.layoutControl1.Controls.Add(this.txtM_join_type);
            this.layoutControl1.Controls.Add(this.txtO_id_charge);
            this.layoutControl1.Controls.Add(this.txtFocus_flag);
            this.layoutControl1.Controls.Add(this.txtStation_id_yg);
            this.layoutControl1.Location = new System.Drawing.Point(3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(622, 397);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtM_age
            // 
            this.txtM_age.Location = new System.Drawing.Point(473, 60);
            this.txtM_age.Name = "txtM_age";
            this.txtM_age.Size = new System.Drawing.Size(137, 20);
            this.txtM_age.StyleController = this.layoutControl1;
            this.txtM_age.TabIndex = 73;
            // 
            // txtM_name
            // 
            this.txtM_name.Location = new System.Drawing.Point(273, 12);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Size = new System.Drawing.Size(135, 20);
            this.txtM_name.StyleController = this.layoutControl1;
            this.txtM_name.TabIndex = 1;
            // 
            // txtM_adress
            // 
            this.txtM_adress.Location = new System.Drawing.Point(73, 181);
            this.txtM_adress.Name = "txtM_adress";
            this.txtM_adress.Size = new System.Drawing.Size(335, 20);
            this.txtM_adress.StyleController = this.layoutControl1;
            this.txtM_adress.TabIndex = 2;
            // 
            // txtM_tel
            // 
            this.txtM_tel.Location = new System.Drawing.Point(73, 253);
            this.txtM_tel.Name = "txtM_tel";
            this.txtM_tel.Size = new System.Drawing.Size(135, 20);
            this.txtM_tel.StyleController = this.layoutControl1;
            this.txtM_tel.TabIndex = 3;
            // 
            // txtM_birthday
            // 
            this.txtM_birthday.EditValue = null;
            this.txtM_birthday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtM_birthday.Location = new System.Drawing.Point(273, 108);
            this.txtM_birthday.Name = "txtM_birthday";
            this.txtM_birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtM_birthday.Size = new System.Drawing.Size(135, 20);
            this.txtM_birthday.StyleController = this.layoutControl1;
            this.txtM_birthday.TabIndex = 8;
            // 
            // txtM_ic
            // 
            this.txtM_ic.Location = new System.Drawing.Point(473, 108);
            this.txtM_ic.Name = "txtM_ic";
            this.txtM_ic.Size = new System.Drawing.Size(135, 20);
            this.txtM_ic.StyleController = this.layoutControl1;
            this.txtM_ic.TabIndex = 9;
            // 
            // txtM_email
            // 
            this.txtM_email.Location = new System.Drawing.Point(73, 301);
            this.txtM_email.Name = "txtM_email";
            this.txtM_email.Size = new System.Drawing.Size(335, 20);
            this.txtM_email.StyleController = this.layoutControl1;
            this.txtM_email.TabIndex = 10;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(73, 349);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(335, 20);
            this.txtMemo.StyleController = this.layoutControl1;
            this.txtMemo.TabIndex = 11;
            // 
            // txtM_password
            // 
            this.txtM_password.Location = new System.Drawing.Point(473, 84);
            this.txtM_password.Name = "txtM_password";
            this.txtM_password.Properties.MaxLength = 12;
            this.txtM_password.Properties.PasswordChar = '*';
            this.txtM_password.Size = new System.Drawing.Size(135, 20);
            this.txtM_password.StyleController = this.layoutControl1;
            this.txtM_password.TabIndex = 12;
            // 
            // txtM_help_input
            // 
            this.txtM_help_input.Location = new System.Drawing.Point(473, 253);
            this.txtM_help_input.Name = "txtM_help_input";
            this.txtM_help_input.Size = new System.Drawing.Size(135, 20);
            this.txtM_help_input.StyleController = this.layoutControl1;
            this.txtM_help_input.TabIndex = 13;
            // 
            // txtM_corporation
            // 
            this.txtM_corporation.Location = new System.Drawing.Point(73, 157);
            this.txtM_corporation.Name = "txtM_corporation";
            this.txtM_corporation.Size = new System.Drawing.Size(335, 20);
            this.txtM_corporation.StyleController = this.layoutControl1;
            this.txtM_corporation.TabIndex = 17;
            // 
            // txtM_zip
            // 
            this.txtM_zip.Location = new System.Drawing.Point(273, 84);
            this.txtM_zip.Name = "txtM_zip";
            this.txtM_zip.Size = new System.Drawing.Size(135, 20);
            this.txtM_zip.StyleController = this.layoutControl1;
            this.txtM_zip.TabIndex = 18;
            // 
            // txtCard_id
            // 
            this.txtCard_id.Location = new System.Drawing.Point(473, 36);
            this.txtCard_id.Name = "txtCard_id";
            this.txtCard_id.Properties.MaxLength = 20;
            this.txtCard_id.Size = new System.Drawing.Size(135, 20);
            this.txtCard_id.StyleController = this.layoutControl1;
            this.txtCard_id.TabIndex = 20;
            // 
            // txtJoin_date
            // 
            this.txtJoin_date.EditValue = null;
            this.txtJoin_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtJoin_date.Location = new System.Drawing.Point(73, 84);
            this.txtJoin_date.Name = "txtJoin_date";
            this.txtJoin_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtJoin_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtJoin_date.Size = new System.Drawing.Size(135, 20);
            this.txtJoin_date.StyleController = this.layoutControl1;
            this.txtJoin_date.TabIndex = 23;
            // 
            // txtEnd_date
            // 
            this.txtEnd_date.EditValue = null;
            this.txtEnd_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEnd_date.Location = new System.Drawing.Point(73, 108);
            this.txtEnd_date.Name = "txtEnd_date";
            this.txtEnd_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEnd_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtEnd_date.Size = new System.Drawing.Size(135, 20);
            this.txtEnd_date.StyleController = this.layoutControl1;
            this.txtEnd_date.TabIndex = 24;
            // 
            // txtM_id
            // 
            this.txtM_id.Location = new System.Drawing.Point(73, 12);
            this.txtM_id.Name = "txtM_id";
            this.txtM_id.Properties.ReadOnly = true;
            this.txtM_id.Size = new System.Drawing.Size(135, 20);
            this.txtM_id.StyleController = this.layoutControl1;
            this.txtM_id.TabIndex = 30;
            // 
            // txtM_address_song
            // 
            this.txtM_address_song.Location = new System.Drawing.Point(73, 229);
            this.txtM_address_song.Name = "txtM_address_song";
            this.txtM_address_song.Size = new System.Drawing.Size(335, 20);
            this.txtM_address_song.StyleController = this.layoutControl1;
            this.txtM_address_song.TabIndex = 37;
            // 
            // txtM_station
            // 
            this.txtM_station.Location = new System.Drawing.Point(473, 157);
            this.txtM_station.Name = "txtM_station";
            this.txtM_station.Size = new System.Drawing.Size(135, 20);
            this.txtM_station.StyleController = this.layoutControl1;
            this.txtM_station.TabIndex = 38;
            // 
            // txtM_zip_song
            // 
            this.txtM_zip_song.Location = new System.Drawing.Point(473, 181);
            this.txtM_zip_song.Name = "txtM_zip_song";
            this.txtM_zip_song.Size = new System.Drawing.Size(135, 20);
            this.txtM_zip_song.StyleController = this.layoutControl1;
            this.txtM_zip_song.TabIndex = 39;
            // 
            // txtM_department_song
            // 
            this.txtM_department_song.Location = new System.Drawing.Point(73, 205);
            this.txtM_department_song.Name = "txtM_department_song";
            this.txtM_department_song.Size = new System.Drawing.Size(335, 20);
            this.txtM_department_song.StyleController = this.layoutControl1;
            this.txtM_department_song.TabIndex = 40;
            // 
            // txtM_name_accept
            // 
            this.txtM_name_accept.Location = new System.Drawing.Point(473, 229);
            this.txtM_name_accept.Name = "txtM_name_accept";
            this.txtM_name_accept.Size = new System.Drawing.Size(135, 20);
            this.txtM_name_accept.StyleController = this.layoutControl1;
            this.txtM_name_accept.TabIndex = 41;
            // 
            // txtM_introduce
            // 
            this.txtM_introduce.Location = new System.Drawing.Point(273, 132);
            this.txtM_introduce.Name = "txtM_introduce";
            this.txtM_introduce.Size = new System.Drawing.Size(135, 20);
            this.txtM_introduce.StyleController = this.layoutControl1;
            this.txtM_introduce.TabIndex = 44;
            // 
            // txtM_mobile
            // 
            this.txtM_mobile.Location = new System.Drawing.Point(73, 277);
            this.txtM_mobile.Name = "txtM_mobile";
            this.txtM_mobile.Properties.MaxLength = 11;
            this.txtM_mobile.Size = new System.Drawing.Size(335, 20);
            this.txtM_mobile.StyleController = this.layoutControl1;
            this.txtM_mobile.TabIndex = 45;
            // 
            // txtM_fax
            // 
            this.txtM_fax.Location = new System.Drawing.Point(273, 253);
            this.txtM_fax.Name = "txtM_fax";
            this.txtM_fax.Size = new System.Drawing.Size(135, 20);
            this.txtM_fax.StyleController = this.layoutControl1;
            this.txtM_fax.TabIndex = 61;
            // 
            // txtSum_date
            // 
            this.txtSum_date.EditValue = null;
            this.txtSum_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSum_date.Location = new System.Drawing.Point(473, 349);
            this.txtSum_date.Name = "txtSum_date";
            this.txtSum_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSum_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSum_date.Size = new System.Drawing.Size(135, 20);
            this.txtSum_date.StyleController = this.layoutControl1;
            this.txtSum_date.TabIndex = 66;
            // 
            // txtStation_id
            // 
            this.txtStation_id.EditValue = "root";
            this.txtStation_id.Location = new System.Drawing.Point(73, 36);
            this.txtStation_id.Name = "txtStation_id";
            this.txtStation_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStation_id.Properties.DisplayMember = "站点名称";
            this.txtStation_id.Properties.NullText = "";
            this.txtStation_id.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.txtStation_id.Properties.ValueMember = "站点编码";
            this.txtStation_id.Size = new System.Drawing.Size(135, 20);
            this.txtStation_id.StyleController = this.layoutControl1;
            this.txtStation_id.TabIndex = 22;
            this.txtStation_id.EditValueChanged += new System.EventHandler(this.txtStation_id_EditValueChanged);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // txtM_type
            // 
            this.txtM_type.EditValue = "";
            this.txtM_type.Location = new System.Drawing.Point(273, 36);
            this.txtM_type.Name = "txtM_type";
            this.txtM_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_type.Properties.NullText = "";
            this.txtM_type.Size = new System.Drawing.Size(135, 20);
            this.txtM_type.StyleController = this.layoutControl1;
            this.txtM_type.TabIndex = 4;
            // 
            // txtM_zy
            // 
            this.txtM_zy.EditValue = "";
            this.txtM_zy.Location = new System.Drawing.Point(273, 60);
            this.txtM_zy.Name = "txtM_zy";
            this.txtM_zy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_zy.Properties.NullText = "";
            this.txtM_zy.Size = new System.Drawing.Size(135, 20);
            this.txtM_zy.StyleController = this.layoutControl1;
            this.txtM_zy.TabIndex = 32;
            // 
            // txtM_sex
            // 
            this.txtM_sex.EditValue = "";
            this.txtM_sex.Location = new System.Drawing.Point(473, 12);
            this.txtM_sex.Name = "txtM_sex";
            this.txtM_sex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_sex.Properties.NullText = "";
            this.txtM_sex.Properties.PopupSizeable = false;
            this.txtM_sex.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtM_sex.Size = new System.Drawing.Size(135, 20);
            this.txtM_sex.StyleController = this.layoutControl1;
            this.txtM_sex.TabIndex = 5;
            // 
            // txtM_send_letter
            // 
            this.txtM_send_letter.EditValue = "";
            this.txtM_send_letter.Location = new System.Drawing.Point(473, 205);
            this.txtM_send_letter.Name = "txtM_send_letter";
            this.txtM_send_letter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_send_letter.Properties.NullText = "";
            this.txtM_send_letter.Properties.PopupSizeable = false;
            this.txtM_send_letter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtM_send_letter.Size = new System.Drawing.Size(135, 20);
            this.txtM_send_letter.StyleController = this.layoutControl1;
            this.txtM_send_letter.TabIndex = 43;
            // 
            // txtLs_flag
            // 
            this.txtLs_flag.EditValue = "";
            this.txtLs_flag.Location = new System.Drawing.Point(73, 325);
            this.txtLs_flag.Name = "txtLs_flag";
            this.txtLs_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLs_flag.Properties.NullText = "";
            this.txtLs_flag.Properties.PopupSizeable = false;
            this.txtLs_flag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtLs_flag.Size = new System.Drawing.Size(135, 20);
            this.txtLs_flag.StyleController = this.layoutControl1;
            this.txtLs_flag.TabIndex = 63;
            // 
            // txtJy_flag
            // 
            this.txtJy_flag.EditValue = "";
            this.txtJy_flag.Location = new System.Drawing.Point(273, 325);
            this.txtJy_flag.Name = "txtJy_flag";
            this.txtJy_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtJy_flag.Properties.NullText = "";
            this.txtJy_flag.Properties.PopupSizeable = false;
            this.txtJy_flag.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtJy_flag.Size = new System.Drawing.Size(135, 20);
            this.txtJy_flag.StyleController = this.layoutControl1;
            this.txtJy_flag.TabIndex = 35;
            // 
            // txtYg_flag
            // 
            this.txtYg_flag.EditValue = "";
            this.txtYg_flag.Location = new System.Drawing.Point(473, 325);
            this.txtYg_flag.Name = "txtYg_flag";
            this.txtYg_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYg_flag.Properties.NullText = "";
            this.txtYg_flag.Size = new System.Drawing.Size(135, 20);
            this.txtYg_flag.StyleController = this.layoutControl1;
            this.txtYg_flag.TabIndex = 64;
            // 
            // txtM_mobile_type
            // 
            this.txtM_mobile_type.EditValue = "";
            this.txtM_mobile_type.Location = new System.Drawing.Point(473, 277);
            this.txtM_mobile_type.Name = "txtM_mobile_type";
            this.txtM_mobile_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_mobile_type.Properties.NullText = "";
            this.txtM_mobile_type.Size = new System.Drawing.Size(135, 20);
            this.txtM_mobile_type.StyleController = this.layoutControl1;
            this.txtM_mobile_type.TabIndex = 46;
            // 
            // txtM_join_type
            // 
            this.txtM_join_type.EditValue = "";
            this.txtM_join_type.Location = new System.Drawing.Point(73, 132);
            this.txtM_join_type.Name = "txtM_join_type";
            this.txtM_join_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_join_type.Properties.NullText = "";
            this.txtM_join_type.Properties.PopupSizeable = false;
            this.txtM_join_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtM_join_type.Size = new System.Drawing.Size(135, 20);
            this.txtM_join_type.StyleController = this.layoutControl1;
            this.txtM_join_type.TabIndex = 42;
            // 
            // txtO_id_charge
            // 
            this.txtO_id_charge.EditValue = "";
            this.txtO_id_charge.Location = new System.Drawing.Point(473, 132);
            this.txtO_id_charge.Name = "txtO_id_charge";
            this.txtO_id_charge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtO_id_charge.Properties.NullText = "";
            this.txtO_id_charge.Properties.View = this.gridView2;
            this.txtO_id_charge.Size = new System.Drawing.Size(135, 20);
            this.txtO_id_charge.StyleController = this.layoutControl1;
            this.txtO_id_charge.TabIndex = 68;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtFocus_flag
            // 
            this.txtFocus_flag.EditValue = "";
            this.txtFocus_flag.Location = new System.Drawing.Point(473, 301);
            this.txtFocus_flag.Name = "txtFocus_flag";
            this.txtFocus_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFocus_flag.Properties.NullText = "";
            this.txtFocus_flag.Size = new System.Drawing.Size(135, 20);
            this.txtFocus_flag.StyleController = this.layoutControl1;
            this.txtFocus_flag.TabIndex = 36;
            // 
            // txtStation_id_yg
            // 
            this.txtStation_id_yg.EditValue = "root";
            this.txtStation_id_yg.Location = new System.Drawing.Point(73, 60);
            this.txtStation_id_yg.Name = "txtStation_id_yg";
            this.txtStation_id_yg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStation_id_yg.Properties.DisplayMember = "站点名称";
            this.txtStation_id_yg.Properties.NullText = "";
            this.txtStation_id_yg.Properties.TreeList = this.treeList1;
            this.txtStation_id_yg.Properties.ValueMember = "站点编码";
            this.txtStation_id_yg.Size = new System.Drawing.Size(135, 20);
            this.txtStation_id_yg.StyleController = this.layoutControl1;
            this.txtStation_id_yg.TabIndex = 72;
            // 
            // treeList1
            // 
            this.treeList1.KeyFieldName = "站点编码";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.ParentFieldName = "父站点";
            this.treeList1.RootValue = "root";
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowCustomizeChildren = false;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem30,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem22,
            this.layoutControlItem4,
            this.layoutControlItem32,
            this.layoutControlItem20,
            this.layoutControlItem23,
            this.layoutControlItem18,
            this.layoutControlItem12,
            this.layoutControlItem24,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem42,
            this.layoutControlItem44,
            this.layoutControlItem68,
            this.layoutControlItem17,
            this.layoutControlItem38,
            this.layoutControlItem39,
            this.layoutControlItem40,
            this.layoutControlItem37,
            this.layoutControlItem43,
            this.layoutControlItem41,
            this.layoutControlItem61,
            this.layoutControlItem45,
            this.layoutControlItem46,
            this.layoutControlItem10,
            this.layoutControlItem36,
            this.layoutControlItem63,
            this.layoutControlItem35,
            this.layoutControlItem64,
            this.layoutControlItem11,
            this.layoutControlItem66,
            this.layoutControlItem13,
            this.layoutControlItem27,
            this.layoutControlItem21});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(622, 397);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtM_adress;
            this.layoutControlItem2.CustomizationFormText = "会员地址";
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "会员地址";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtM_tel;
            this.layoutControlItem3.CustomizationFormText = "电话";
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 241);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "电话";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem30.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem30.Control = this.txtM_id;
            this.layoutControlItem30.CustomizationFormText = "会员编码";
            this.layoutControlItem30.FillControlToClientArea = false;
            this.layoutControlItem30.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem30.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem30.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem30.Text = "会员编码*";
            this.layoutControlItem30.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtM_name;
            this.layoutControlItem1.CustomizationFormText = "会员名称";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "会员姓名*";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtM_sex;
            this.layoutControlItem5.CustomizationFormText = "性别";
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "性别";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem22.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem22.Control = this.txtStation_id;
            this.layoutControlItem22.CustomizationFormText = "所属站点";
            this.layoutControlItem22.FillControlToClientArea = false;
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem22.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem22.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem22.Text = "所属站点*";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtM_type;
            this.layoutControlItem4.CustomizationFormText = "会员级别";
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "会员级别*";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem32.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem32.Control = this.txtM_zy;
            this.layoutControlItem32.CustomizationFormText = "会员类别";
            this.layoutControlItem32.FillControlToClientArea = false;
            this.layoutControlItem32.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem32.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem32.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem32.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem32.Text = "会员类别";
            this.layoutControlItem32.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.AppearanceItemCaption.ForeColor = System.Drawing.Color.Red;
            this.layoutControlItem20.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem20.Control = this.txtCard_id;
            this.layoutControlItem20.CustomizationFormText = "会员卡号";
            this.layoutControlItem20.FillControlToClientArea = false;
            this.layoutControlItem20.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem20.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem20.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem20.Text = "会员卡号*";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.txtJoin_date;
            this.layoutControlItem23.CustomizationFormText = "入会时间";
            this.layoutControlItem23.FillControlToClientArea = false;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem23.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem23.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem23.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem23.Text = "入会时间";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.txtM_zip;
            this.layoutControlItem18.CustomizationFormText = "邮政编码";
            this.layoutControlItem18.FillControlToClientArea = false;
            this.layoutControlItem18.Location = new System.Drawing.Point(200, 72);
            this.layoutControlItem18.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem18.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem18.Text = "邮政编码";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtM_password;
            this.layoutControlItem12.CustomizationFormText = "密码";
            this.layoutControlItem12.FillControlToClientArea = false;
            this.layoutControlItem12.Location = new System.Drawing.Point(400, 72);
            this.layoutControlItem12.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem12.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem12.Text = "密码";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.txtEnd_date;
            this.layoutControlItem24.CustomizationFormText = "到期时间";
            this.layoutControlItem24.FillControlToClientArea = false;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem24.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem24.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem24.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem24.Text = "到期时间";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtM_birthday;
            this.layoutControlItem8.CustomizationFormText = "出生日期";
            this.layoutControlItem8.FillControlToClientArea = false;
            this.layoutControlItem8.Location = new System.Drawing.Point(200, 96);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "出生日期";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtM_ic;
            this.layoutControlItem9.CustomizationFormText = "身份证";
            this.layoutControlItem9.FillControlToClientArea = false;
            this.layoutControlItem9.Location = new System.Drawing.Point(400, 96);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "身份证";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem42
            // 
            this.layoutControlItem42.Control = this.txtM_join_type;
            this.layoutControlItem42.CustomizationFormText = "入会方式";
            this.layoutControlItem42.FillControlToClientArea = false;
            this.layoutControlItem42.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem42.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem42.Name = "layoutControlItem42";
            this.layoutControlItem42.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem42.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem42.Text = "入会方式";
            this.layoutControlItem42.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem44
            // 
            this.layoutControlItem44.Control = this.txtM_introduce;
            this.layoutControlItem44.CustomizationFormText = "介绍人";
            this.layoutControlItem44.FillControlToClientArea = false;
            this.layoutControlItem44.Location = new System.Drawing.Point(200, 120);
            this.layoutControlItem44.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem44.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem44.Name = "layoutControlItem44";
            this.layoutControlItem44.Size = new System.Drawing.Size(200, 25);
            this.layoutControlItem44.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem44.Text = "介绍人";
            this.layoutControlItem44.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem68
            // 
            this.layoutControlItem68.Control = this.txtO_id_charge;
            this.layoutControlItem68.CustomizationFormText = "主管业务";
            this.layoutControlItem68.FillControlToClientArea = false;
            this.layoutControlItem68.Location = new System.Drawing.Point(400, 120);
            this.layoutControlItem68.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem68.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem68.Name = "layoutControlItem68";
            this.layoutControlItem68.Size = new System.Drawing.Size(202, 25);
            this.layoutControlItem68.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem68.Text = "主管业务";
            this.layoutControlItem68.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.txtM_corporation;
            this.layoutControlItem17.CustomizationFormText = "会员单位";
            this.layoutControlItem17.FillControlToClientArea = false;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 145);
            this.layoutControlItem17.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem17.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem17.Text = "会员单位";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.txtM_station;
            this.layoutControlItem38.CustomizationFormText = "送货到站";
            this.layoutControlItem38.FillControlToClientArea = false;
            this.layoutControlItem38.Location = new System.Drawing.Point(400, 145);
            this.layoutControlItem38.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem38.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem38.Name = "layoutControlItem38";
            this.layoutControlItem38.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem38.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem38.Text = "送货到站";
            this.layoutControlItem38.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.txtM_zip_song;
            this.layoutControlItem39.CustomizationFormText = "送货邮编";
            this.layoutControlItem39.FillControlToClientArea = false;
            this.layoutControlItem39.Location = new System.Drawing.Point(400, 169);
            this.layoutControlItem39.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem39.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem39.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem39.Text = "送货邮编";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.txtM_department_song;
            this.layoutControlItem40.CustomizationFormText = "接货单位";
            this.layoutControlItem40.FillControlToClientArea = false;
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 193);
            this.layoutControlItem40.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem40.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem40.Name = "layoutControlItem40";
            this.layoutControlItem40.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem40.Text = "接货单位";
            this.layoutControlItem40.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.txtM_address_song;
            this.layoutControlItem37.CustomizationFormText = "接货地址";
            this.layoutControlItem37.FillControlToClientArea = false;
            this.layoutControlItem37.Location = new System.Drawing.Point(0, 217);
            this.layoutControlItem37.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem37.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem37.Name = "layoutControlItem37";
            this.layoutControlItem37.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem37.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem37.Text = "接货地址";
            this.layoutControlItem37.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem43
            // 
            this.layoutControlItem43.Control = this.txtM_send_letter;
            this.layoutControlItem43.CustomizationFormText = "是否发信";
            this.layoutControlItem43.FillControlToClientArea = false;
            this.layoutControlItem43.Location = new System.Drawing.Point(400, 193);
            this.layoutControlItem43.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem43.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem43.Name = "layoutControlItem43";
            this.layoutControlItem43.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem43.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem43.Text = "是否发信";
            this.layoutControlItem43.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem41
            // 
            this.layoutControlItem41.Control = this.txtM_name_accept;
            this.layoutControlItem41.CustomizationFormText = "接货人";
            this.layoutControlItem41.FillControlToClientArea = false;
            this.layoutControlItem41.Location = new System.Drawing.Point(400, 217);
            this.layoutControlItem41.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem41.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem41.Name = "layoutControlItem41";
            this.layoutControlItem41.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem41.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem41.Text = "接货人";
            this.layoutControlItem41.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem61
            // 
            this.layoutControlItem61.Control = this.txtM_fax;
            this.layoutControlItem61.CustomizationFormText = "传真";
            this.layoutControlItem61.FillControlToClientArea = false;
            this.layoutControlItem61.Location = new System.Drawing.Point(200, 241);
            this.layoutControlItem61.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem61.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem61.Name = "layoutControlItem61";
            this.layoutControlItem61.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem61.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem61.Text = "传真";
            this.layoutControlItem61.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem45
            // 
            this.layoutControlItem45.Control = this.txtM_mobile;
            this.layoutControlItem45.CustomizationFormText = "手机号码";
            this.layoutControlItem45.FillControlToClientArea = false;
            this.layoutControlItem45.Location = new System.Drawing.Point(0, 265);
            this.layoutControlItem45.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem45.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem45.Name = "layoutControlItem45";
            this.layoutControlItem45.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem45.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem45.Text = "手机号码";
            this.layoutControlItem45.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem46
            // 
            this.layoutControlItem46.Control = this.txtM_mobile_type;
            this.layoutControlItem46.CustomizationFormText = "手机类型";
            this.layoutControlItem46.FillControlToClientArea = false;
            this.layoutControlItem46.Location = new System.Drawing.Point(400, 265);
            this.layoutControlItem46.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem46.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem46.Name = "layoutControlItem46";
            this.layoutControlItem46.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem46.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem46.Text = "手机类型";
            this.layoutControlItem46.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtM_email;
            this.layoutControlItem10.CustomizationFormText = "电子邮箱";
            this.layoutControlItem10.FillControlToClientArea = false;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 289);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "电子邮箱";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.txtFocus_flag;
            this.layoutControlItem36.CustomizationFormText = "是否员工";
            this.layoutControlItem36.FillControlToClientArea = false;
            this.layoutControlItem36.Location = new System.Drawing.Point(400, 289);
            this.layoutControlItem36.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem36.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem36.Text = "是否员工";
            this.layoutControlItem36.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem63
            // 
            this.layoutControlItem63.Control = this.txtLs_flag;
            this.layoutControlItem63.CustomizationFormText = "是否零售";
            this.layoutControlItem63.FillControlToClientArea = false;
            this.layoutControlItem63.Location = new System.Drawing.Point(0, 313);
            this.layoutControlItem63.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem63.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem63.Name = "layoutControlItem63";
            this.layoutControlItem63.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem63.Text = "是否零售";
            this.layoutControlItem63.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.txtJy_flag;
            this.layoutControlItem35.CustomizationFormText = "是否借阅";
            this.layoutControlItem35.FillControlToClientArea = false;
            this.layoutControlItem35.Location = new System.Drawing.Point(200, 313);
            this.layoutControlItem35.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem35.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem35.Name = "layoutControlItem35";
            this.layoutControlItem35.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem35.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem35.Text = "是否借阅";
            this.layoutControlItem35.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem64
            // 
            this.layoutControlItem64.Control = this.txtYg_flag;
            this.layoutControlItem64.CustomizationFormText = "是否网购";
            this.layoutControlItem64.FillControlToClientArea = false;
            this.layoutControlItem64.Location = new System.Drawing.Point(400, 313);
            this.layoutControlItem64.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem64.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem64.Name = "layoutControlItem64";
            this.layoutControlItem64.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem64.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem64.Text = "是否网购";
            this.layoutControlItem64.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtMemo;
            this.layoutControlItem11.CustomizationFormText = "备注";
            this.layoutControlItem11.FillControlToClientArea = false;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 337);
            this.layoutControlItem11.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem11.MinSize = new System.Drawing.Size(105, 24);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(400, 40);
            this.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem11.Text = "备注";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem66
            // 
            this.layoutControlItem66.Control = this.txtSum_date;
            this.layoutControlItem66.CustomizationFormText = "累计开始";
            this.layoutControlItem66.FillControlToClientArea = false;
            this.layoutControlItem66.Location = new System.Drawing.Point(400, 337);
            this.layoutControlItem66.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem66.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem66.Name = "layoutControlItem66";
            this.layoutControlItem66.Size = new System.Drawing.Size(202, 40);
            this.layoutControlItem66.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem66.Text = "累计开始";
            this.layoutControlItem66.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.txtM_help_input;
            this.layoutControlItem13.CustomizationFormText = "助记码";
            this.layoutControlItem13.FillControlToClientArea = false;
            this.layoutControlItem13.Location = new System.Drawing.Point(400, 241);
            this.layoutControlItem13.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem13.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem13.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem13.Text = "助记码";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.txtStation_id_yg;
            this.layoutControlItem27.CustomizationFormText = "发货站点";
            this.layoutControlItem27.FillControlToClientArea = false;
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem27.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem27.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem27.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem27.Text = "发货站点";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(58, 14);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.txtM_age;
            this.layoutControlItem21.CustomizationFormText = "年龄";
            this.layoutControlItem21.Location = new System.Drawing.Point(400, 48);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(202, 24);
            this.layoutControlItem21.Text = "年龄";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(58, 14);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(634, 432);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(628, 403);
            this.xtraTabPage1.Text = "会员基本信息";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.layoutControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(628, 403);
            this.xtraTabPage2.Text = "会员其他信息";
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.textEdit4);
            this.layoutControl2.Controls.Add(this.textEdit3);
            this.layoutControl2.Controls.Add(this.textEdit2);
            this.layoutControl2.Controls.Add(this.textEdit1);
            this.layoutControl2.Controls.Add(this.txtM_degree);
            this.layoutControl2.Controls.Add(this.txtM_national);
            this.layoutControl2.Controls.Add(this.txtM_zw);
            this.layoutControl2.Controls.Add(this.txtM_native);
            this.layoutControl2.Controls.Add(this.txtM_income);
            this.layoutControl2.Controls.Add(this.txtActive_flag);
            this.layoutControl2.Controls.Add(this.txtM_arears);
            this.layoutControl2.Controls.Add(this.txtM_province);
            this.layoutControl2.Controls.Add(this.txtM_city);
            this.layoutControl2.Controls.Add(this.txtInput_date);
            this.layoutControl2.Controls.Add(this.txtLast_mod_date);
            this.layoutControl2.Controls.Add(this.txtM_period);
            this.layoutControl2.Controls.Add(this.txtO_id_input);
            this.layoutControl2.Controls.Add(this.txtO_id_modify);
            this.layoutControl2.Controls.Add(this.txtM_ziye);
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(624, 398);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(287, 36);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(121, 20);
            this.textEdit4.StyleController = this.layoutControl2;
            this.textEdit4.TabIndex = 77;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(87, 36);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(121, 20);
            this.textEdit3.StyleController = this.layoutControl2;
            this.textEdit3.TabIndex = 76;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(87, 12);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(121, 20);
            this.textEdit2.StyleController = this.layoutControl2;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(287, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(121, 20);
            this.textEdit1.StyleController = this.layoutControl2;
            this.textEdit1.TabIndex = 4;
            // 
            // txtM_degree
            // 
            this.txtM_degree.EditValue = "";
            this.txtM_degree.Location = new System.Drawing.Point(487, 12);
            this.txtM_degree.Name = "txtM_degree";
            this.txtM_degree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_degree.Properties.NullText = "";
            this.txtM_degree.Size = new System.Drawing.Size(121, 20);
            this.txtM_degree.StyleController = this.layoutControl2;
            this.txtM_degree.TabIndex = 32;
            // 
            // txtM_national
            // 
            this.txtM_national.EditValue = "";
            this.txtM_national.Location = new System.Drawing.Point(487, 36);
            this.txtM_national.Name = "txtM_national";
            this.txtM_national.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_national.Properties.NullText = "";
            this.txtM_national.Size = new System.Drawing.Size(121, 20);
            this.txtM_national.StyleController = this.layoutControl2;
            this.txtM_national.TabIndex = 6;
            // 
            // txtM_zw
            // 
            this.txtM_zw.EditValue = "";
            this.txtM_zw.Location = new System.Drawing.Point(287, 60);
            this.txtM_zw.Name = "txtM_zw";
            this.txtM_zw.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_zw.Properties.NullText = "";
            this.txtM_zw.Size = new System.Drawing.Size(121, 20);
            this.txtM_zw.StyleController = this.layoutControl2;
            this.txtM_zw.TabIndex = 36;
            // 
            // txtM_native
            // 
            this.txtM_native.EditValue = "";
            this.txtM_native.Location = new System.Drawing.Point(487, 60);
            this.txtM_native.Name = "txtM_native";
            this.txtM_native.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_native.Properties.NullText = "";
            this.txtM_native.Size = new System.Drawing.Size(121, 20);
            this.txtM_native.StyleController = this.layoutControl2;
            this.txtM_native.TabIndex = 8;
            // 
            // txtM_income
            // 
            this.txtM_income.EditValue = "";
            this.txtM_income.Location = new System.Drawing.Point(487, 108);
            this.txtM_income.Name = "txtM_income";
            this.txtM_income.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_income.Properties.NullText = "";
            this.txtM_income.Size = new System.Drawing.Size(121, 20);
            this.txtM_income.StyleController = this.layoutControl2;
            this.txtM_income.TabIndex = 72;
            // 
            // txtActive_flag
            // 
            this.txtActive_flag.EditValue = "";
            this.txtActive_flag.Location = new System.Drawing.Point(287, 108);
            this.txtActive_flag.Name = "txtActive_flag";
            this.txtActive_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActive_flag.Properties.NullText = "";
            this.txtActive_flag.Size = new System.Drawing.Size(121, 20);
            this.txtActive_flag.StyleController = this.layoutControl2;
            this.txtActive_flag.TabIndex = 34;
            // 
            // txtM_arears
            // 
            this.txtM_arears.EditValue = "";
            this.txtM_arears.Location = new System.Drawing.Point(87, 108);
            this.txtM_arears.Name = "txtM_arears";
            this.txtM_arears.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_arears.Properties.NullText = "";
            this.txtM_arears.Size = new System.Drawing.Size(121, 20);
            this.txtM_arears.StyleController = this.layoutControl2;
            this.txtM_arears.TabIndex = 17;
            // 
            // txtM_province
            // 
            this.txtM_province.EditValue = "";
            this.txtM_province.Location = new System.Drawing.Point(287, 84);
            this.txtM_province.Name = "txtM_province";
            this.txtM_province.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_province.Properties.NullText = "";
            this.txtM_province.Properties.View = this.searchLookUpEdit1View;
            this.txtM_province.Size = new System.Drawing.Size(121, 20);
            this.txtM_province.StyleController = this.layoutControl2;
            this.txtM_province.TabIndex = 16;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtM_city
            // 
            this.txtM_city.EditValue = "";
            this.txtM_city.Location = new System.Drawing.Point(487, 84);
            this.txtM_city.Name = "txtM_city";
            this.txtM_city.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_city.Properties.NullText = "";
            this.txtM_city.Properties.View = this.gridView1;
            this.txtM_city.Size = new System.Drawing.Size(121, 20);
            this.txtM_city.StyleController = this.layoutControl2;
            this.txtM_city.TabIndex = 15;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtInput_date
            // 
            this.txtInput_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInput_date.Location = new System.Drawing.Point(387, 132);
            this.txtInput_date.Name = "txtInput_date";
            this.txtInput_date.Properties.Mask.EditMask = "d";
            this.txtInput_date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtInput_date.Properties.ReadOnly = true;
            this.txtInput_date.Size = new System.Drawing.Size(225, 20);
            this.txtInput_date.StyleController = this.layoutControl2;
            this.txtInput_date.TabIndex = 75;
            // 
            // txtLast_mod_date
            // 
            this.txtLast_mod_date.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLast_mod_date.Location = new System.Drawing.Point(387, 156);
            this.txtLast_mod_date.Name = "txtLast_mod_date";
            this.txtLast_mod_date.Properties.Mask.EditMask = "d";
            this.txtLast_mod_date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtLast_mod_date.Properties.ReadOnly = true;
            this.txtLast_mod_date.Size = new System.Drawing.Size(225, 20);
            this.txtLast_mod_date.StyleController = this.layoutControl2;
            this.txtLast_mod_date.TabIndex = 35;
            // 
            // txtM_period
            // 
            this.txtM_period.EditValue = "";
            this.txtM_period.Location = new System.Drawing.Point(87, 60);
            this.txtM_period.Name = "txtM_period";
            this.txtM_period.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_period.Properties.NullText = "";
            this.txtM_period.Size = new System.Drawing.Size(121, 20);
            this.txtM_period.StyleController = this.layoutControl2;
            this.txtM_period.TabIndex = 71;
            // 
            // txtO_id_input
            // 
            this.txtO_id_input.Location = new System.Drawing.Point(87, 132);
            this.txtO_id_input.Name = "txtO_id_input";
            this.txtO_id_input.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtO_id_input.Properties.NullText = "";
            this.txtO_id_input.Properties.ReadOnly = true;
            this.txtO_id_input.Size = new System.Drawing.Size(221, 20);
            this.txtO_id_input.StyleController = this.layoutControl2;
            this.txtO_id_input.TabIndex = 33;
            // 
            // txtO_id_modify
            // 
            this.txtO_id_modify.Location = new System.Drawing.Point(87, 156);
            this.txtO_id_modify.Name = "txtO_id_modify";
            this.txtO_id_modify.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtO_id_modify.Properties.NullText = "";
            this.txtO_id_modify.Properties.ReadOnly = true;
            this.txtO_id_modify.Size = new System.Drawing.Size(221, 20);
            this.txtO_id_modify.StyleController = this.layoutControl2;
            this.txtO_id_modify.TabIndex = 74;
            // 
            // txtM_ziye
            // 
            this.txtM_ziye.EditValue = "";
            this.txtM_ziye.Location = new System.Drawing.Point(87, 84);
            this.txtM_ziye.Name = "txtM_ziye";
            this.txtM_ziye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtM_ziye.Properties.NullText = "";
            this.txtM_ziye.Size = new System.Drawing.Size(121, 20);
            this.txtM_ziye.StyleController = this.layoutControl2;
            this.txtM_ziye.TabIndex = 73;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowCustomizeChildren = false;
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem19,
            this.layoutControlItem28,
            this.layoutControlItem51,
            this.layoutControlItem52,
            this.layoutControlItem48,
            this.layoutControlItem33,
            this.layoutControlItem25,
            this.layoutControlItem7,
            this.layoutControlItem49,
            this.layoutControlItem16,
            this.layoutControlItem31,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem34,
            this.layoutControlItem47,
            this.layoutControlItem26,
            this.layoutControlItem29,
            this.layoutControlItem50});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(624, 398);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit1;
            this.layoutControlItem6.CustomizationFormText = "实洋累计";
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(200, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "实洋累计";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.txtO_id_input;
            this.layoutControlItem19.CustomizationFormText = "建档人";
            this.layoutControlItem19.FillControlToClientArea = false;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem19.MaxSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem19.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem19.Text = "建档人";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.textEdit2;
            this.layoutControlItem28.CustomizationFormText = "码洋累计";
            this.layoutControlItem28.FillControlToClientArea = false;
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem28.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem28.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem28.Text = "码洋累计";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem51
            // 
            this.layoutControlItem51.Control = this.textEdit3;
            this.layoutControlItem51.CustomizationFormText = "其他实洋累计";
            this.layoutControlItem51.FillControlToClientArea = false;
            this.layoutControlItem51.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem51.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem51.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem51.Name = "layoutControlItem51";
            this.layoutControlItem51.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem51.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem51.Text = "其他实洋累计";
            this.layoutControlItem51.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem52
            // 
            this.layoutControlItem52.Control = this.textEdit4;
            this.layoutControlItem52.CustomizationFormText = "其他码洋累计";
            this.layoutControlItem52.FillControlToClientArea = false;
            this.layoutControlItem52.Location = new System.Drawing.Point(200, 24);
            this.layoutControlItem52.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem52.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem52.Name = "layoutControlItem52";
            this.layoutControlItem52.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem52.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem52.Text = "其他码洋累计";
            this.layoutControlItem52.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem48
            // 
            this.layoutControlItem48.Control = this.txtM_national;
            this.layoutControlItem48.CustomizationFormText = "名族";
            this.layoutControlItem48.FillControlToClientArea = false;
            this.layoutControlItem48.Location = new System.Drawing.Point(400, 24);
            this.layoutControlItem48.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem48.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem48.Name = "layoutControlItem48";
            this.layoutControlItem48.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem48.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem48.Text = "名族";
            this.layoutControlItem48.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.txtM_period;
            this.layoutControlItem33.CustomizationFormText = "光顾周期";
            this.layoutControlItem33.FillControlToClientArea = false;
            this.layoutControlItem33.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem33.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem33.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem33.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem33.Text = "光顾周期";
            this.layoutControlItem33.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.txtM_zw;
            this.layoutControlItem25.CustomizationFormText = "职务";
            this.layoutControlItem25.FillControlToClientArea = false;
            this.layoutControlItem25.Location = new System.Drawing.Point(200, 48);
            this.layoutControlItem25.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem25.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem25.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem25.Text = "职务";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtM_native;
            this.layoutControlItem7.CustomizationFormText = "国籍";
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(400, 48);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "国籍";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem49
            // 
            this.layoutControlItem49.Control = this.txtM_ziye;
            this.layoutControlItem49.CustomizationFormText = "职业";
            this.layoutControlItem49.FillControlToClientArea = false;
            this.layoutControlItem49.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem49.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem49.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem49.Name = "layoutControlItem49";
            this.layoutControlItem49.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem49.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem49.Text = "职业";
            this.layoutControlItem49.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.txtM_arears;
            this.layoutControlItem16.CustomizationFormText = "所在区域";
            this.layoutControlItem16.FillControlToClientArea = false;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem16.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem16.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem16.Text = "所在区域";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.txtM_degree;
            this.layoutControlItem31.CustomizationFormText = "学历";
            this.layoutControlItem31.FillControlToClientArea = false;
            this.layoutControlItem31.Location = new System.Drawing.Point(400, 0);
            this.layoutControlItem31.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem31.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem31.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem31.Text = "学历";
            this.layoutControlItem31.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtM_city;
            this.layoutControlItem14.CustomizationFormText = "现居城市";
            this.layoutControlItem14.FillControlToClientArea = false;
            this.layoutControlItem14.Location = new System.Drawing.Point(400, 72);
            this.layoutControlItem14.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem14.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem14.Text = "现居城市";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.txtM_province;
            this.layoutControlItem15.CustomizationFormText = "现居省份";
            this.layoutControlItem15.FillControlToClientArea = false;
            this.layoutControlItem15.Location = new System.Drawing.Point(200, 72);
            this.layoutControlItem15.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem15.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem15.Text = "现居省份";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.txtInput_date;
            this.layoutControlItem34.CustomizationFormText = "建档日期";
            this.layoutControlItem34.FillControlToClientArea = false;
            this.layoutControlItem34.Location = new System.Drawing.Point(300, 120);
            this.layoutControlItem34.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem34.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(304, 24);
            this.layoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem34.Text = "建档日期";
            this.layoutControlItem34.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem47
            // 
            this.layoutControlItem47.Control = this.txtO_id_modify;
            this.layoutControlItem47.CustomizationFormText = "最后修改人";
            this.layoutControlItem47.FillControlToClientArea = false;
            this.layoutControlItem47.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem47.MaxSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem47.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem47.Name = "layoutControlItem47";
            this.layoutControlItem47.Size = new System.Drawing.Size(300, 234);
            this.layoutControlItem47.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem47.Text = "最后修改人";
            this.layoutControlItem47.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.txtLast_mod_date;
            this.layoutControlItem26.CustomizationFormText = "最后修改日期";
            this.layoutControlItem26.FillControlToClientArea = false;
            this.layoutControlItem26.Location = new System.Drawing.Point(300, 144);
            this.layoutControlItem26.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem26.MinSize = new System.Drawing.Size(300, 24);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(304, 234);
            this.layoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem26.Text = "最后修改日期";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.txtActive_flag;
            this.layoutControlItem29.CustomizationFormText = "是否有效";
            this.layoutControlItem29.FillControlToClientArea = false;
            this.layoutControlItem29.Location = new System.Drawing.Point(200, 96);
            this.layoutControlItem29.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem29.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem29.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem29.Text = "是否有效";
            this.layoutControlItem29.TextSize = new System.Drawing.Size(72, 14);
            // 
            // layoutControlItem50
            // 
            this.layoutControlItem50.Control = this.txtM_income;
            this.layoutControlItem50.CustomizationFormText = "收入水平";
            this.layoutControlItem50.FillControlToClientArea = false;
            this.layoutControlItem50.Location = new System.Drawing.Point(400, 96);
            this.layoutControlItem50.MaxSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem50.MinSize = new System.Drawing.Size(200, 24);
            this.layoutControlItem50.Name = "layoutControlItem50";
            this.layoutControlItem50.Size = new System.Drawing.Size(204, 24);
            this.layoutControlItem50.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem50.Text = "收入水平";
            this.layoutControlItem50.TextSize = new System.Drawing.Size(72, 14);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(554, 438);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "反馈(&F)";
            this.btnFeedback.Visible = false;
            // 
            // btn_ask
            // 
            this.btn_ask.Location = new System.Drawing.Point(509, 438);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(117, 23);
            this.btn_ask.TabIndex = 8;
            this.btn_ask.Text = "转为爱书卡并冲值";
            this.btn_ask.Visible = false;
            this.btn_ask.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FromEditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 471);
            this.Controls.Add(this.btn_ask);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FromEditMember";
            this.Text = "会员";
            this.Load += new System.EventHandler(this.FromEditMember_Load);
            this.Controls.SetChildIndex(this.dataNavigator1, 0);
            this.Controls.SetChildIndex(this.dataViewNavigator1, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.picPrint, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.btnFeedback, 0);
            this.Controls.SetChildIndex(this.btn_ask, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtM_age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_ic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_help_input.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_corporation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCard_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJoin_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJoin_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_address_song.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_station.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zip_song.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_department_song.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_name_accept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_introduce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_mobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSum_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_sex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_send_letter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLs_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJy_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYg_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_mobile_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_join_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_charge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFocus_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStation_id_yg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_degree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_national.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_zw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_native.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_income.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActive_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_arears.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_province.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_city.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLast_mod_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_period.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_input.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtO_id_modify.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtM_ziye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region 变量
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

        private DevExpress.XtraEditors.TextEdit txtM_name;
        private DevExpress.XtraEditors.TextEdit txtM_adress;
        private DevExpress.XtraEditors.TextEdit txtM_tel;
        private DevExpress.XtraEditors.DateEdit txtM_birthday;
        private DevExpress.XtraEditors.TextEdit txtM_ic;
        private DevExpress.XtraEditors.TextEdit txtM_email;
        private DevExpress.XtraEditors.TextEdit txtMemo;
        private DevExpress.XtraEditors.TextEdit txtM_password;
        private DevExpress.XtraEditors.TextEdit txtM_help_input;
        private DevExpress.XtraEditors.TextEdit txtM_corporation;
        private DevExpress.XtraEditors.TextEdit txtM_zip;
        private DevExpress.XtraEditors.TextEdit txtCard_id;
        private DevExpress.XtraEditors.DateEdit txtJoin_date;
        private DevExpress.XtraEditors.DateEdit txtEnd_date;
        private DevExpress.XtraEditors.TextEdit txtM_id;
        private DevExpress.XtraEditors.TextEdit txtM_address_song;
        private DevExpress.XtraEditors.TextEdit txtM_station;
        private DevExpress.XtraEditors.TextEdit txtM_zip_song;
        private DevExpress.XtraEditors.TextEdit txtM_department_song;
        private DevExpress.XtraEditors.TextEdit txtM_name_accept;
        private DevExpress.XtraEditors.TextEdit txtM_introduce;
        private DevExpress.XtraEditors.TextEdit txtM_mobile;
        private DevExpress.XtraEditors.TextEdit txtM_fax;
        private DevExpress.XtraEditors.DateEdit txtSum_date;

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem35;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem37;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem38;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem40;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem41;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem42;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem43;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem44;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem45;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem46;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem61;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem63;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem64;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem66;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem68;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem51;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem52;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem48;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem49;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem50;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem47;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraEditors.TreeListLookUpEdit txtStation_id;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.LookUpEdit txtM_type;
        private DevExpress.XtraEditors.LookUpEdit txtM_zy;
        private DevExpress.XtraEditors.LookUpEdit txtM_sex;
        private DevExpress.XtraEditors.LookUpEdit txtM_send_letter;
        private DevExpress.XtraEditors.LookUpEdit txtLs_flag;
        private DevExpress.XtraEditors.LookUpEdit txtJy_flag;
        private DevExpress.XtraEditors.LookUpEdit txtYg_flag;
        private DevExpress.XtraEditors.LookUpEdit txtM_degree;
        private DevExpress.XtraEditors.LookUpEdit txtM_national;
        private DevExpress.XtraEditors.LookUpEdit txtM_zw;
        private DevExpress.XtraEditors.LookUpEdit txtM_native;
        private DevExpress.XtraEditors.LookUpEdit txtM_income;
        private DevExpress.XtraEditors.LookUpEdit txtActive_flag;
        private DevExpress.XtraEditors.LookUpEdit txtM_arears;
        private DevExpress.XtraEditors.SearchLookUpEdit txtM_province;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit txtM_city;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtInput_date;
        private DevExpress.XtraEditors.TextEdit txtLast_mod_date;
        private DevExpress.XtraEditors.LookUpEdit txtM_period;
        private DevExpress.XtraEditors.LookUpEdit txtM_mobile_type;
        private DevExpress.XtraEditors.LookUpEdit txtM_join_type;
        private DevExpress.XtraEditors.SearchLookUpEdit txtO_id_charge;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LookUpEdit txtO_id_input;
        private DevExpress.XtraEditors.LookUpEdit txtO_id_modify;
        private DevExpress.XtraEditors.LookUpEdit txtFocus_flag;
        private DevExpress.XtraEditors.LookUpEdit txtM_ziye;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraEditors.TextEdit txtM_age;
        private DevExpress.XtraEditors.TreeListLookUpEdit txtStation_id_yg;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.SimpleButton btnFeedback;
        #endregion


        /// <summary>
        /// 创建一个临时对象，方便在附件管理中获取存在的GUID
        /// </summary>
        private MemberInfo tempInfo = new MemberInfo();
        private DevExpress.XtraEditors.SimpleButton btn_ask;
        public string memberCord = "";

        private MemberInfo KMember = null;//输入爱书卡冲值中的会员信息

        public FromEditMember()
        {
            InitializeComponent();
            InitDictItem();
            txtO_id_input.EditValue = string.Empty;
            txtO_id_modify.EditValue = string.Empty;
        }

        /// <summary>
        /// 实现控件输入检查的函数
        /// </summary>
        /// <returns></returns>
        public override bool CheckInput()
        {
            bool result = true;//默认是可以通过

            #region MyRegion
            if (this.txtM_name.Text.Trim().Length == 0)
            {
                MessagboxUit.ShowTips("请输入会员姓名");
                this.txtM_name.Focus();
                result = false;
            }

            if (this.txtM_type.Text.Trim().Length == 0)
            {
                MessagboxUit.ShowTips("请选择会员级别");
                this.txtM_name.Focus();
                result = false;
            }
            if (txtM_zy.Text.Length == 0)
            {
                MessagboxUit.ShowTips("请选择会员类别");
                this.txtM_zy.Focus();
                result = false;
            }
            if (this.txtStation_id.Text.Length == 0)
            {
                MessagboxUit.ShowTips("请选择“所属站点”");
                this.txtStation_id.Focus();
                result = false;
            }
            #endregion

            return result;
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        private void InitDictItem()
        {
            //初始化代码
            #region 性别
            this.txtM_sex.Properties.DisplayMember = "显示值";
            this.txtM_sex.Properties.ValueMember = "项目值";
            this.txtM_sex.Properties.DataSource = DictItemUtil.SexbyEditor();
            #endregion

            #region 所属站点/发货站点
            this.txtStation_id.Properties.DataSource = DictItemUtil.GetAllStationForDropDown();
            this.txtStation_id_yg.Properties.DataSource = DictItemUtil.GetAllStationForDropDown();
            #endregion

            #region 会员级别
            this.txtM_type.Properties.DisplayMember = "显示值";
            this.txtM_type.Properties.ValueMember = "项目值";
            this.txtM_type.Properties.DataSource = DictItemUtil.M_typeByEditor();
            #endregion

            #region 会员类别
            this.txtM_zy.Properties.DisplayMember = "显示值";
            this.txtM_zy.Properties.ValueMember = "项目值";
            this.txtM_zy.Properties.DataSource = DictItemUtil.M_zyByEditor();
            #endregion

            #region 入会方式
            this.txtM_join_type.Properties.DisplayMember = "显示值";
            this.txtM_join_type.Properties.ValueMember = "项目值";
            this.txtM_join_type.Properties.DataSource = DictItemUtil.M_Join_typeByEditor();
            #endregion

            #region 主管业务、修改人、建档人
            this.txtO_id_charge.Properties.DisplayMember = "显示值";
            this.txtO_id_charge.Properties.ValueMember = "项目值";
            this.txtO_id_charge.Properties.DataSource = DictItemUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_input.Properties.DisplayMember = "显示值";
            this.txtO_id_input.Properties.ValueMember = "项目值";
            this.txtO_id_input.Properties.DataSource = DictItemUtil.GetOperatorOrSaleManByEditor();

            this.txtO_id_modify.Properties.DisplayMember = "显示值";
            this.txtO_id_modify.Properties.ValueMember = "项目值";
            this.txtO_id_modify.Properties.DataSource = DictItemUtil.GetOperatorOrSaleManByEditor();

            #endregion

            #region 是否发信、是否员工、是否零售、是否借阅、是否网购、是否有效
            this.txtM_send_letter.Properties.DisplayMember = "显示值";
            this.txtM_send_letter.Properties.ValueMember = "项目值";
            this.txtM_send_letter.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txtFocus_flag.Properties.DisplayMember = "显示值";
            this.txtFocus_flag.Properties.ValueMember = "项目值";
            this.txtFocus_flag.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txtLs_flag.Properties.DisplayMember = "显示值";
            this.txtLs_flag.Properties.ValueMember = "项目值";
            this.txtLs_flag.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txtJy_flag.Properties.DisplayMember = "显示值";
            this.txtJy_flag.Properties.ValueMember = "项目值";
            this.txtJy_flag.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txtYg_flag.Properties.DisplayMember = "显示值";
            this.txtYg_flag.Properties.ValueMember = "项目值";
            this.txtYg_flag.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            this.txtActive_flag.Properties.DisplayMember = "显示值";
            this.txtActive_flag.Properties.ValueMember = "项目值";
            this.txtActive_flag.Properties.DataSource = DictItemUtil.YesOrNoByEditor();

            #endregion

            #region 手机类型
            this.txtM_mobile_type.Properties.DisplayMember = "显示值";
            this.txtM_mobile_type.Properties.ValueMember = "项目值";
            this.txtM_mobile_type.Properties.DataSource = DictItemUtil.MoblieTypeByEditor();
            #endregion

            #region 学历
            //this.txtM_degree.Properties.DisplayMember = "显示值";
            //this.txtM_degree.Properties.ValueMember = "项目值";
            //this.txtM_degree.Properties.DataSource = DictItemUtil.MemberDegreeByEditor();
            #endregion

            #region 光顾周期
            this.txtM_period.Properties.DisplayMember = "显示值";
            this.txtM_period.Properties.ValueMember = "项目值";
            this.txtM_period.Properties.DataSource = DictItemUtil.MemberPeriodByEditor();
            #endregion

            #region 职务
            this.txtM_zw.Properties.DisplayMember = "显示值";
            this.txtM_zw.Properties.ValueMember = "项目值";
            this.txtM_zw.Properties.DataSource = DictItemUtil.DutyByEditor();
            #endregion

            #region 职业
            this.txtM_ziye.Properties.DisplayMember = "显示值";
            this.txtM_ziye.Properties.ValueMember = "项目值";
            this.txtM_ziye.Properties.DataSource = DictItemUtil.MemberZyByEditor();
            #endregion

            #region 现居城市
            this.txtM_city.Properties.DisplayMember = "省份名称";
            this.txtM_city.Properties.DisplayMember = "城市名称";
            this.txtM_city.Properties.ValueMember = "城市编码";
            this.txtM_city.Properties.DataSource = DictItemUtil.CitysByEditor();
            #endregion

            #region 现居省份
            this.txtM_province.Properties.DisplayMember = "地区名称";
            this.txtM_province.Properties.DisplayMember = "省份名称";
            this.txtM_province.Properties.ValueMember = "省份编码";
            this.txtM_province.Properties.DataSource = DictItemUtil.ProvinceByEditor();
            #endregion

            #region 所在区域
            this.txtM_arears.Properties.DisplayMember = "显示值";
            this.txtM_arears.Properties.ValueMember = "项目值";
            this.txtM_arears.Properties.DataSource = DictItemUtil.ArearsByEditor();
            #endregion

            #region 收入水平
            this.txtM_income.Properties.DisplayMember = "显示值";
            this.txtM_income.Properties.ValueMember = "项目值";
            this.txtM_income.Properties.DataSource = DictItemUtil.M_IncomeByEditor();
            #endregion

            #region 国籍
            //this.txtM_native.Properties.DisplayMember = "显示值";
            //this.txtM_native.Properties.ValueMember = "项目值";
            //this.txtM_native.Properties.DataSource = DictItemUtil.M_NativeByEditor();
            #endregion

            #region 民族
            //this.txtM_national.Properties.DisplayMember = "显示值";
            //this.txtM_national.Properties.ValueMember = "项目值";
            //this.txtM_national.Properties.DataSource = DictItemUtil.M_NationalByEditor();

            #endregion

        }
        public void SetMember()
        {
            if (string.IsNullOrEmpty(mmm_id)) return;
            InitDictItem();
           MemberInfo k= BLLFactory<Member>.Instance.FindByID(mmm_id);
        }

        /// <summary>
        /// 数据显示的函数
        /// </summary>
        public override void DisplayData()
        {
            if (string.IsNullOrEmpty(mmm_id)) return;
            this.btn_ask.Visible = true;
            InitDictItem();//数据字典加载（公用）
            KMember = new MemberInfo();
            KMember = BLLFactory<Member>.Instance.FindByID(mmm_id);
            if (KMember != null)
            {
                #region 显示信息
                tempInfo = KMember;
                if (tempInfo != null)
                {

                    txtM_name.Text = tempInfo.M_name;
                    txtM_adress.Text = tempInfo.M_adress;
                    txtM_tel.Text = tempInfo.M_tel;
                    txtM_type.EditValue = tempInfo.M_type;
                    txtM_sex.EditValue = tempInfo.M_sex;
                    txtM_national.EditValue = tempInfo.M_national;
                    txtM_native.EditValue = tempInfo.M_native;
                    txtM_birthday.Text = tempInfo.M_birthday.ToString();
                    txtM_ic.Text = tempInfo.M_ic;
                    txtM_email.Text = tempInfo.M_email;
                    txtMemo.Text = tempInfo.Memo;
                    txtM_password.Text = tempInfo.M_password;
                    txtM_help_input.Text = tempInfo.M_help_input;
                    txtM_city.EditValue = tempInfo.M_city;
                    txtM_province.EditValue = tempInfo.M_province;
                    txtM_arears.EditValue = tempInfo.M_arears;
                    txtM_corporation.Text = tempInfo.M_corporation;
                    txtM_zip.Text = tempInfo.M_zip;
                    txtM_degree.EditValue = tempInfo.M_degree;
                    txtCard_id.Text = tempInfo.Card_id;
                    txtStation_id.EditValue = tempInfo.Station_id;
                    txtJoin_date.Text = tempInfo.Join_date.ToString("yyyy/MM/dd");
                    txtEnd_date.Text = tempInfo.End_date.ToString("yyyy/MM/dd");
                    txtO_id_input.EditValue = tempInfo.O_id_input;
                    txtActive_flag.EditValue = tempInfo.Active_flag;
                    txtLast_mod_date.Text = tempInfo.Last_mod_date.ToString("yyyy/MM/dd");
                    txtM_id.Text = tempInfo.M_id;
                    txtM_zw.EditValue = tempInfo.M_zw;
                    txtM_zy.EditValue = tempInfo.M_zy;
                    txtM_period.EditValue = tempInfo.M_period;
                    txtM_income.EditValue = tempInfo.M_income;
                    txtJy_flag.EditValue = tempInfo.Jy_flag;
                    txtFocus_flag.EditValue = tempInfo.Focus_flag;
                    txtM_address_song.Text = tempInfo.M_address_song;
                    txtM_station.Text = tempInfo.M_station;
                    txtM_zip_song.Text = tempInfo.M_zip_song;
                    txtM_department_song.Text = tempInfo.M_department_song;
                    txtM_name_accept.Text = tempInfo.M_name_accept;
                    txtM_join_type.Text = tempInfo.M_join_type;
                    txtM_send_letter.EditValue = tempInfo.M_send_letter;
                    txtM_introduce.Text = tempInfo.M_introduce;
                    txtM_mobile.Text = tempInfo.M_mobile;
                    txtM_mobile_type.EditValue = tempInfo.M_mobile_type;
                    txtM_ziye.EditValue = tempInfo.M_ziye;
                    txtM_fax.Text = tempInfo.M_fax;
                    txtLs_flag.EditValue = tempInfo.Ls_flag;
                    txtYg_flag.EditValue = tempInfo.Yg_flag;
                    txtSum_date.Text = tempInfo.Sum_date.ToString("yyyy/MM/dd");
                    txtStation_id_yg.EditValue = tempInfo.Station_id_yg;
                    txtO_id_charge.EditValue = tempInfo.O_id_charge;
                    //txtO_id_modify.EditValue = tempInfo.O_id_modify;
                    //txtInput_date.Text = tempInfo.Input_date.ToString("yyyy/MM/dd");
                }
                #endregion

            }
            else
            {

            }


        }

        public override void ClearScreen()
        {
            this.tempInfo = new MemberInfo();
            base.ClearScreen();
        }

        /// <summary>
        /// 编辑或者保存状态下取值函数
        /// </summary>
        /// <param name="info"></param>
        private void SetInfo(MemberInfo info)
        {
            info.M_name = txtM_name.Text;
            info.M_adress = txtM_adress.Text;
            info.M_tel = txtM_tel.Text;
            info.M_type = txtM_type.EditValue.ToString();
            info.M_sex = txtM_sex.EditValue.ToString();
            info.M_national = txtM_national.EditValue.ToString();
            info.M_native = txtM_native.EditValue.ToString();
            info.M_birthday = txtM_birthday.Text.ToDateTime();
            info.M_ic = txtM_ic.Text;
            info.M_email = txtM_id.Text;
            info.Memo = txtMemo.Text;
            info.M_password = txtM_password.Text;
            info.M_help_input = txtM_help_input.Text;
            info.M_city = txtM_city.EditValue.ToString();
            info.M_province = txtM_province.EditValue.ToString();
            info.M_arears = txtM_arears.EditValue.ToString();
            info.M_corporation = txtM_corporation.Text;
            info.M_zip = txtM_zip.Text;
            info.M_degree = txtM_degree.EditValue.ToString();
            info.Card_id = txtCard_id.Text;
            info.Station_id = txtStation_id.EditValue.ToString();
            info.Join_date = txtJoin_date.Text.ToDateTime();
            info.End_date = txtEnd_date.Text.ToDateTime();
            info.O_id_input = txtO_id_input.EditValue.ToString();
            info.Active_flag = txtActive_flag.EditValue.ToString();
            info.Last_mod_date = txtLast_mod_date.Text.ToDateTime();
            info.M_id = txtM_id.Text;
            info.M_zw = txtM_zw.EditValue.ToString();
            info.M_zy = txtM_zy.EditValue.ToString();
            info.M_period = txtM_period.EditValue.ToString();
            info.M_income = txtM_income.EditValue.ToString();
            info.Jy_flag = txtJy_flag.EditValue.ToString();
            info.Focus_flag = txtFocus_flag.EditValue.ToString();
            info.M_address_song = txtM_address_song.Text;
            info.M_station = txtM_station.Text;
            info.M_zip_song = txtM_zip_song.Text;
            info.M_department_song = txtM_department_song.Text;
            info.M_name_accept = txtM_name_accept.Text;
            info.M_join_type = txtM_join_type.EditValue.ToString();
            info.M_send_letter = txtM_send_letter.EditValue.ToString();
            info.M_introduce = txtM_introduce.Text;
            info.M_mobile = txtM_mobile.Text;
            info.M_mobile_type = txtM_mobile_type.EditValue.ToString();
            info.M_ziye = txtM_ziye.EditValue.ToString();
            info.M_fax = txtM_fax.Text;
            info.Ls_flag = txtLs_flag.EditValue.ToString();
            info.Yg_flag = txtYg_flag.EditValue.ToString();
            info.Sum_date = txtSum_date.Text.ToDateTime();
            info.Station_id_yg = txtStation_id_yg.EditValue.ToString();
            info.O_id_charge = txtO_id_charge.EditValue.ToString();
            //info.O_id_modify = txtO_id_modify.EditValue.ToString();
            //info.Input_date = txtInput_date.Text.ToDateTime();
        }

        /// <summary>
        /// 新增状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveAddNew()
        {

            tempInfo = new MemberInfo();//必须使用存在的局部变量，因为部分信息可能被附件使用
            SetInfo(tempInfo);
            //tempInfo.O_id_modify = Portal.gc.LoginUserInfo.O_id;
            try
            {
                #region 新增数据
                //检查是否还有其他相同关键字的记录
                bool exist = BLLFactory<Member>.Instance.IsExistKey("card_id", tempInfo.Card_id);
                if (exist)
                {
                    MessagboxUit.ShowTips(string.Format("卡号{0}已存在,请重试", txtCard_id.Text));
                    return false;
                }

                bool succeed = BLLFactory<Member>.Instance.Insert(tempInfo);
                if (succeed)
                {
                    //可添加其他关联操作
                    if (MasterView.DataSource != null)
                    {
                        ((List<MemberInfo>)this.MasterView.DataSource).Add(tempInfo);
                        MasterView.RefreshData();
                        MasterView.MoveLast();
                        this.rowIndex = MasterView.FocusedRowHandle;
                    }
                   memberCord = tempInfo.Card_id;
                    return true;
                }
                #endregion
            }
            catch (Exception ex)
            {
                LogTextHelper.Error(ex);
                MessagboxUit.ShowError(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// 编辑状态下的数据保存
        /// </summary>
        /// <returns></returns>
        public override bool SaveUpdated()
        {
            string condition = string.Format("card_id ='{0}' and m_id <> '{1}' ", this.txtCard_id.Text, txtM_id.Text);
            bool exist = BLLFactory<Member>.Instance.IsExistRecord(condition);
            if (exist)
            {
                MessagboxUit.ShowTips(string.Format("卡号{0}已存在,请重试", txtCard_id.Text));
                return false;
            }

            MemberInfo info = BLLFactory<Member>.Instance.FindByID(tempInfo.M_id);
            if (info != null)
            {
                SetInfo(info);
               // info.O_id_modify = Portal.gc.LoginUserInfo.O_id;

                try
                {
                    #region 更新数据
                    bool succeed = BLLFactory<Member>.Instance.Update(info, info.M_id);
                    if (succeed)
                    {
                        //可添加其他关联操作

                        return true;
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessagboxUit.ShowError(ex.Message);
                }
            }
            return false;
        }

        private void FromEditMember_Load(object sender, EventArgs e)
        {
            if (this.txtO_id_input.EditValue.ToString() == string.Empty)
            {
                txtO_id_input.EditValue = Portal.gc.loginUserInfo.O_id;
            }
            if (this.ID == string.Empty)
            {
                this.txtInput_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                this.btnFeedback.Enabled = false;
                //this.txtStation_id.ReadOnly = true;
            }
            if (this.txtStation_id.EditValue.ToString() == "root")
            {
                this.txtStation_id.EditValue = Portal.gc.loginUserInfo.Station_ID;
            }
            //if (!string.IsNullOrEmpty(MMM_id))
            //{
            //    DisplayData();
            //}
            Saved = true;
        }

        //private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (this.Text.Contains("新建"))
        //    {
        //        try
        //        {
        //            this.txtM_id.Text = string.Format("MM{0}{1:000000000}", this.txtStation_id.EditValue.ToString(), BLLFactory<Member>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
        //        }
        //        catch (Exception ex)
        //        {
        //            LogTextHelper.Error(ex);
        //            MessagboxUit.ShowError(ex.Message);
        //        }
        //    }
        //}
        private void txtM_birthday_EditValueChanged(object sender, EventArgs e)
        {
            int age = System.DateTime.Now.ToString().Substring(0, 4).ToInt32() - txtM_birthday.Text.Substring(0, 4).ToInt32();
            txtM_age.Text = age.ToString();
        }
        public override void SetDefault()
        {
            txtActive_flag.EditValue = "1";
            txtLs_flag.EditValue = "1";
            txtJy_flag.EditValue = "1";
            txtYg_flag.EditValue = "1";
            txtM_sex.EditValue = "0";
            txtSum_date.EditValue = DateTime.Now;
            txtJoin_date.EditValue = DateTime.Now;
            txtEnd_date.EditValue = DateTime.Now.AddYears(10);
        }
        public override void SetControlReadOnly()
        {
            this.txtCard_id.Properties.ReadOnly = true;
            this.txtStation_id.Properties.ReadOnly = true;

        }

        private void txtStation_id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.Text.Contains("新建"))
            {
                try
                {
                    this.txtM_id.Text = string.Format("MM{0}{1:000000000}", this.txtStation_id.EditValue.ToString(), BLLFactory<Member>.Instance.MaxCode(this.txtStation_id.EditValue.ToString()));
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessagboxUit.ShowError(ex.Message);
                }
            }
        }
        /// <summary>
        /// 打开会员冲值窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (formm_poss == null || formm_poss.IsDisposed)
            {
                if (BLLFactory<Ls_card_surplus>.Instance.IsExistKey("card_id", KMember.Card_id))
                {
                    
                }
                else
                {
                    if (MessagboxUit.ShowYesNoAndTips("是否转换成【爱书卡】?") == System.Windows.Forms.DialogResult.Yes)
                    {
                        Ls_card_surplusInfo cardinfo = new Ls_card_surplusInfo();
                        cardinfo.Card_id = KMember.Card_id;
                        cardinfo.Input_date = DateTime.Now;
                        cardinfo.End_date = KMember.End_date;
                        cardinfo.Valid_flag = "1";
                        cardinfo.M_id = KMember.M_id;
                        cardinfo.Memo = "";
                        cardinfo.O_id_input = Portal.gc.loginUserInfo.O_id;
                        cardinfo.Discount = 1.00m;
                        cardinfo.C_id = "";
                        cardinfo.O_id_operator = "";
                        cardinfo.Station_id = "";
                        cardinfo.D_id = "";
                        cardinfo.Lk_date = "1900-1-1 0:0:0.000".ToDateTime();
                        cardinfo.Lk_p_id = "";
                        cardinfo.Fk_input = Portal.gc.loginUserInfo.O_id;
                        cardinfo.Fk_date = DateTime.Now;
                        
                        try
                        {
                            if (BLLFactory<Ls_card_surplus>.Instance.Insert(cardinfo))
                            {
                                MessagboxUit.ShowTips("转换成【爱书卡】成功！");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessagboxUit.ShowError(ex.Message);
                        }
                    }
                    
                }
                formm_poss = new CordInputFrom();
                formm_poss.memberinfo = KMember;
                formm_poss.ShowDialog();
                formm_poss.Close();
               
            }
            else
            {
                formm_poss.Activate();
            }
        }

        private bool ExistMemberToCordMember(MemberInfo info)
        {
            bool result = false;
            if (info == null) return false;
            if( BLLFactory<Ls_card_surplus>.Instance.IsExistKey(" card_id", info.Card_id))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
