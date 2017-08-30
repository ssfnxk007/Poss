using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Erp.Base.UI;
using WHC.Framework.Commons;

namespace Erp.Base.UI
{
    public partial class BaseEditForm : BaseForm
    {
        public string ID = string.Empty;  // 主键主键
        public List<string> IDList = new List<string>();//所有待展示的ID列表
        public bool Saved = true;  //是否修改
        public string LoginID = "";
        public int rowIndex = 0;
        protected DevExpress.XtraGrid.Views.Grid.GridView masterView = new DevExpress.XtraGrid.Views.Grid.GridView();



        /// <summary>
        /// 主表信息视图
        /// </summary>
        public DevExpress.XtraGrid.Views.Grid.GridView MasterView
        {
            get { return masterView; }
            set
            {
                masterView = value;
                this.dataViewNavigator1.View = value;
            }
        }


        public BaseEditForm()
        {
            InitializeComponent();
            this.dataNavigator1.PositionChanging += new PostionChangeingEventHandler(dataNavigator1_PositionChanging);
            this.dataNavigator1.PositionChanged += dataNavigator1_PositionChanged;
        }

        private void dataNavigator1_PositionChanged(object sender, EventArgs e)
        {
            this.ID = IDList[this.dataNavigator1.CurrentIndex];
            DisplayData();
            this.Saved = true;
        }

        private void dataNavigator1_PositionChanging(object sender, HandledEventArgs e)
        {
            if (CheckSaved())
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private bool CheckSaved()
        {
            if (!Saved)
            {
                if (MessageDxUtil.ShowYesNoAndTips("数据已改变,是否保存数据?") == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveEntity();
                    return Saved;
                }
                else
                {
                    this.Saved = true;
                }
            }
            return true;
        }
        public override void FormOnLoad()
        {
            base.FormOnLoad();
            if (!this.DesignMode)
            {
                if (rowIndex!=-1)
                {
                    if (!this.Text.Contains("编辑"))
                    {
                        this.Text = "编辑 " + this.Text;
                        SetControlReadOnly();
                    }
                    this.btnAdd.Visible = false;//如果是编辑，则屏蔽添加按钮

                    //this.dataNavigator1.IDList = IDList;
                    //this.dataNavigator1.CurrentIndex = IDList.IndexOf(ID);

                    DisplayData();
                }
                else
                {
                    if (!this.Text.Contains("新建"))
                    {
                        this.Text = "新建 " + this.Text;
                        SetDefault();
                    }
                }
                this.BuilderEvent(this);
            }
        }

        protected void TextOrValueChanging(object sender, EventArgs e)
        {
            this.Saved = false;
        }

        public virtual void BuilderEvent(Control controls)
        {
            for (int i = 0; i < controls.Controls.Count; i++)
            {
                if (controls.Controls[i].GetType().Name == "DataNavigator") continue;
                if (controls.Controls[i].GetType().Name == "DataViewNavigator") continue;


                if (controls.Controls[i].HasChildren)
                {
                    BuilderEvent(controls.Controls[i]);
                }
                switch (controls.Controls[i].GetType().Name)
                {
                    case "TextEdit":
                        ((DevExpress.XtraEditors.TextEdit)controls.Controls[i]).EditValueChanged += TextOrValueChanging;
                        break;
                    case "LookUpEdit":
                        ((DevExpress.XtraEditors.LookUpEdit)controls.Controls[i]).EditValueChanged += TextOrValueChanging;
                        break;
                    case "DateEdit":
                        ((DevExpress.XtraEditors.DateEdit)controls.Controls[i]).EditValueChanged += TextOrValueChanging;
                        break;
                    case "SearchLookUpEdit":
                        ((DevExpress.XtraEditors.SearchLookUpEdit)controls.Controls[i]).EditValueChanged += TextOrValueChanging;
                        break;
                    case "TreeListLookUpEdit":
                        ((DevExpress.XtraEditors.TreeListLookUpEdit)controls.Controls[i]).EditValueChanged += TextOrValueChanging;
                        break;
                    default:
                        break;
                }
            }

        }
        private void BaseEditForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 显示数据到控件上
        /// </summary>
        public virtual void DisplayData()
        {
        }

        private void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Saved)
            {
                if (MessageDxUtil.ShowYesNoAndTips("数据已改变,是否保存数据?") == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveEntity();
                    e.Cancel = Saved;
                }
            }
        }

        /// <summary>
        /// 检查输入的有效性
        /// </summary>
        /// <returns>有效</returns>
        public virtual bool CheckInput()
        {
            return true;
        }

        /// <summary>
        /// 清除屏幕
        /// </summary>
        public virtual void ClearScreen()
        {
            this.ID = "";////需要设置为空，表示新增
            ClearControlValue(this);
            this.FormOnLoad();
        }

        /// <summary>
        /// 清除容器里面某些控件的值
        /// </summary>
        /// <param name="parContainer">容器类控件</param>
        private void ClearControlValue(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {
                // 如果是容器类控件，递归调用自己
                if (parContainer.Controls[index].HasChildren)
                {
                    ClearControlValue(parContainer.Controls[index]);
                }
                else
                {
                    switch (parContainer.Controls[index].GetType().Name)
                    {
                        case "TextEdit":
                            parContainer.Controls[index].Text = "";
                            break;
                        case "SpinEdit":
                            ((DevExpress.XtraEditors.SpinEdit)(parContainer.Controls[index])).Value = 1;
                            break;
                        case "SearchLookUpEdit":
                            ((DevExpress.XtraEditors.SearchLookUpEdit)(parContainer.Controls[index])).EditValue = null;
                            break;
                        case "MemoEdit":
                            ((DevExpress.XtraEditors.MemoEdit)(parContainer.Controls[index])).Text = "";
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 保存数据（新增和编辑的保存）
        /// </summary>
        public virtual bool SaveEntity()
        {
            bool result = false;
            if (rowIndex!=-1)
            {
                //编辑的保存
                result = SaveUpdated();
            }
            else
            {
                //新增的保存
                result = SaveAddNew();
            }
            this.Saved = result;

            return result;
        }

        /// <summary>
        /// 更新已有的数据
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveUpdated()
        {
            return true;
        }

        /// <summary>
        /// 保存新增的数据
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveAddNew()
        {
            return true;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="close">关闭窗体</param>
        private void SaveEntity(bool close)
        {
            // 检查输入的有效性
            if (this.CheckInput())
            {
                // 设置鼠标繁忙状态
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    if (this.SaveEntity())
                    {
                        ProcessDataSaved(this.btnOK, new EventArgs());
                        this.Saved = true;
                        MessageDxUtil.ShowTips("保存成功");
                        if (close)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            this.ClearScreen();
                        }
                    }
                    else
                    {
                        MessageDxUtil.ShowError("保存失败!");
                    }
                }
                catch (Exception ex)
                {
                    LogTextHelper.Error(ex);
                    MessageDxUtil.ShowError(ex.Message);
                }
                finally
                {
                    // 设置鼠标默认状态
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.SaveEntity(false);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SaveEntity(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                this.FormOnLoad();
            }

            if (!(ActiveControl is Button))
            {
                if (ActiveControl is Form)
                {
                    if (keyData == Keys.Down || keyData == Keys.Enter)
                    {
                        return this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    else if (keyData == Keys.Up)
                    {
                        return this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                }

                if (keyData == Keys.Enter)
                {
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                    return true;
                }
                //if (keyData == Keys.Down)
                //{
                //    System.Windows.Forms.SendKeys.Send("{TAB}");
                //}
                //else
                //{
                //    SendKeys.Send("+{Tab}");
                //}

                return false;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void picPrint_Click(object sender, EventArgs e)
        {
           // PrintFormHelper.Print(this);
        }

        public virtual void ReadOnly() { }

        private void dataViewNavigator1_RowIndexChanging(object sender, HandledEventArgs e)
        {
            if (CheckSaved())
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void dataViewNavigator1_RowIndexChanged(object sender, EventArgs e)
        {
            this.rowIndex = masterView.FocusedRowHandle;
            DisplayData();
            this.Saved = true;
        }
        public virtual void SetControlReadOnly()
        {

        }
        public virtual void SetDefault()
        {

        }
    }
}
