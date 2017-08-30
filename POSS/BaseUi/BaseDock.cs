using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using POSS;
using POSS.Entity;

namespace POSS
{
    /// <summary>
    /// 用于一般列表界面的基类
    /// </summary>
    public partial class BaseDock : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler OnDataSaved;//子窗体数据保存的触发

        public BaseDock()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
        }

        /// <summary>
        /// 处理数据保存后的事件触发
        /// </summary>
        public virtual void ProcessDataSaved(object sender, EventArgs e)
        {
            if (OnDataSaved != null)
            {
                OnDataSaved(sender, e);
                
            }
        }

        public void WriteException(Exception ex)
        {
            // 在本地记录异常
            LogTextHelper.Error(ex);
             MessagboxUit.ShowError(ex.Message);
        }

        /// <summary>
        /// 处理异常信息
        /// </summary>
        /// <param name="exception">异常</param>
        public void ProcessException(Exception ex)
        {
            this.WriteException(ex);

            // 显示异常页面
            //FrmException frmException = new FrmException(this.UserInfo, ex);
            //frmException.ShowDialog();

            MessageBox.Show(ex.Message);//临时处理
        }

        /// <summary>
        /// 可供重写的窗体加载函数，子窗体特殊处理只需重写该函数
        /// </summary>
        public virtual void FormOnLoad()
        {
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {       
            if (!this.DesignMode)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDock));
                //this.Icon = WHC.WareHouseMis.DotUI.Properties.Resources.app;

                //this.StartPosition = FormStartPosition.CenterScreen;

                base.OnControlAdded(e);
            }

        }

        protected override void OnLoad(EventArgs e)
        {
            if (!this.DesignMode)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDock));

                this.StartPosition = FormStartPosition.CenterScreen;
                base.OnLoad(e);
            }
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                // 设置鼠标繁忙状态
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    this.FormOnLoad();
                }
                catch (Exception ex)
                {
                    this.ProcessException(ex);
                }
                finally
                {
                    // 设置鼠标默认状态
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5://刷新
                    this.FormOnLoad();
                    break;
            }
        }
    }
}
