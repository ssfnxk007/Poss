using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Erp.Base.Entity;
using Erp.Base.Facade;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Erp.Base.UI
{

    public class StockTips : XtraUserControl
    {
        #region 变量定义
		
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 库存明细ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 按本地库房LToolStripMenuItem;
        private ToolStripMenuItem 按地区分布AToolStripMenuItem;
        private ToolStripMenuItem 站点SToolStripMenuItem;
        private ToolStripMenuItem 按库房KToolStripMenuItem;
        private ToolStripMenuItem 简单模式NToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 关闭CToolStripMenuItem;
        private string h_id = string.Empty;
        private StockModel currentStockModel;
        private IContainer components;
        private PanelControl panelControl1;
        private Panel panel1;
        private INIFileUtil iniFile = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");

        private List<StockTipsInfo> stocklist = new List<StockTipsInfo>();


        private bool tipsVisable = true; 
	#endregion

        #region 属性
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool TipsVisable
        {
            get { return tipsVisable; }
            set
            {
                tipsVisable = value;
                if (value == false)
                {
                    this.Visible = false;
                }
            }
        }

        /// <summary>
        /// 商品编码
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string H_id
        {
            get
            {
                return h_id;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.stocklist.Clear();
                    this.stocklist.AddRange(CallerFactory<IProductService>.Instance.GetStockTips(value));
                    h_id = value;
                    string mode = iniFile.IniReadValue(ParentForm.Name, "StockModel");
                    if (!string.IsNullOrEmpty(mode))
                    {
                        this.CurrentStockModel = EnumHelper.GetInstance<StockModel>(mode);

                    }
                }

            }
        }

        /// <summary>
        /// 当前库存获取方式
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StockModel CurrentStockModel
        {
            get
            {
                return currentStockModel;
            }
            set
            {
                SetChecked(false);
                switch (value)
                {

                    case StockModel.ByStationName:
                        站点SToolStripMenuItem.Checked = true;
                        this.AddControlList(GetStockAmountByStation());
                        break;
                    case StockModel.ByStationArea:
                        按地区分布AToolStripMenuItem.Checked = true;
                        this.AddControlList(GetStockAmountByArea());
                        break;
                    case StockModel.ByLocalStation:
                        按本地库房LToolStripMenuItem.Checked = true;
                        this.AddControlList(GetStockAmountByStationLocalFlag());
                        break;
                    case StockModel.ByStockName:
                        按库房KToolStripMenuItem.Checked = true;
                        this.AddControlList(GetStockAmoutByStockID());
                        break;
                    case StockModel.ByAllStock:
                        简单模式NToolStripMenuItem.Checked = true;
                        this.AddControlList(GetStockAmountForEnough());
                        break;
                    default:
                        break;
                }
                currentStockModel = value;
                try
                {
                    iniFile.IniWriteValue(this.ParentForm.Name, "StockModel", ((StockModel)currentStockModel).ToString());
                }
                catch (Exception)
                {
                }
            }
        }


        #endregion

        #region 库存获取方法

        /// <summary>
        /// 获取库房
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStockAmoutByStockID()
        {
            var query = from i in stocklist
                        group i by i.S_id
                            into g
                            select
                            new
                            {
                                H_amount = g.Sum(i => i.H_amount),
                                S_name = g.Max(i => i.S_name)
                            };
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in query)
            {
                result.Add(item.S_name, item.H_amount);
            }
            return result;
        }
        /// <summary>
        /// 按站点
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStockAmountByStation()
        {
            var query = from i in stocklist
                        group i by i.Station_id
                            into g
                            select
                            new
                            {
                                Station_name = g.Max(i => i.Station_name),
                                H_amount = g.Sum(i => i.H_amount)
                            };
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in query)
            {
                result.Add(item.Station_name, item.H_amount);
            }
            return result;
        }
        /// <summary>
        /// 按是否是本地
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStockAmountByStationLocalFlag()
        {
            var query = from i in stocklist
                        group i by i.Local_flag
                            into g
                            select
                            new
                            {
                                Local = g.Max(i => i.Local_flag) =="1" ? "本地库房" :"非本地库房",
                                H_amount = g.Sum(i => i.H_amount)
                            };
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in query)
            {
                result.Add(item.Local, item.H_amount);
            }
            return result;
        }
        /// <summary>
        /// 按地区分部
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStockAmountByArea()
        {
            var query = from i in stocklist
                        group i by i.A_id
                            into g
                            select
                            new
                            {
                                AID = g.Max(i => i.A_id),
                                H_amount = g.Sum(i => i.H_amount)
                            };
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in query)
            {
                result.Add(item.AID, item.H_amount);
            }
            return result;
        }



        /// <summary>
        /// 获取可支配数
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStockAmountForEnough()
        {
            var query = from i in stocklist
                        where i.H_amount>0
                        group i by i.Station_id
                            into g
                            select
                            new
                            {
                                ShortName = g.Max(i=>i.Station_ShortName),
                                H_amount = g.Sum(i => i.H_amount) - g.Max(i=>i.NotDealAmount)
                            };
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in query)
            {
                result.Add(item.ShortName, item.H_amount);
            }
            return result;

        } 
        #endregion

        #region Checked
        private void SetChecked(bool isChecked)
        {
            按本地库房LToolStripMenuItem.Checked = isChecked;
            按地区分布AToolStripMenuItem.Checked = isChecked;
            简单模式NToolStripMenuItem.Checked = isChecked;
            按库房KToolStripMenuItem.Checked = isChecked;
            站点SToolStripMenuItem.Checked = isChecked;
        } 
        #endregion

        #region 构造方法
        public StockTips()
        {
            InitializeComponent();
            this.contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            this.contextMenuStrip1.Closed += contextMenuStrip1_Closed;
        }
        
        #endregion

        #region 菜单事件
        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            SetChecked(false);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string mode = iniFile.IniReadValue(ParentForm.Name, "StockModel");
            if (!string.IsNullOrEmpty(mode))
            {
                this.CurrentStockModel = EnumHelper.GetInstance<StockModel>(mode);
            }
        }

        private void 库存明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 按本地库房LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentStockModel = StockModel.ByLocalStation;
        }

        private void 按地区分布AToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.CurrentStockModel = StockModel.ByStationArea;
        }

        private void 站点SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.CurrentStockModel = StockModel.ByStationName;

        }

        private void 按库房KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CurrentStockModel = StockModel.ByStockName;
        }

        private void 简单模式NToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.CurrentStockModel = StockModel.ByAllStock;
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        #endregion

        #region 添加控件
        private void AddControlList(Dictionary<string, int> Dict)
        {
            this.panel1.Controls.Clear();
            Label lb;
            int x = 0;
            int y = 0;
            foreach (var keys in Dict.Keys)
            {
                lb = new Label();
                lb.AutoSize = false;
                lb.Text = keys;
                lb.Width = 100;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                this.panel1.Controls.Add(lb);
                lb.Location = new Point(x, y);
                lb = new Label();
                lb.AutoSize = false;
                lb.Width = 100;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.Text = Dict[keys].ToString();
                this.panel1.Controls.Add(lb);
                lb.Location = new Point(x, y + 16);
                x = x + 100;
            }
        }
        private void AddControl(DataTable dt)
        {
            this.panel1.Controls.Clear();
            Label lb;
            int x = 0;
            int y = 0;
            foreach (DataRow dr in dt.Rows)
            {
                lb = new Label();
                lb.AutoSize = false;
                lb.Text = dr[0].ToString();
                lb.Width = 100;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                this.panel1.Controls.Add(lb);
                lb.Location = new Point(x, y);
                lb = new Label();
                lb.AutoSize = false;
                lb.Width = 100;
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.Text = dr[1].ToString();
                this.panel1.Controls.Add(lb);
                lb.Location = new Point(x, y + 16);
                x = x + 100;
            }
        }

        #endregion

        #region InitializeComponent
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.库存明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.按本地库房LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按地区分布AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站点SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按库房KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单模式NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.库存明细ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.按本地库房LToolStripMenuItem,
            this.按地区分布AToolStripMenuItem,
            this.站点SToolStripMenuItem,
            this.按库房KToolStripMenuItem,
            this.简单模式NToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关闭CToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 170);
            // 
            // 库存明细ToolStripMenuItem
            // 
            this.库存明细ToolStripMenuItem.Name = "库存明细ToolStripMenuItem";
            this.库存明细ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.库存明细ToolStripMenuItem.Text = "库存明细(&M)";
            this.库存明细ToolStripMenuItem.Click += new System.EventHandler(this.库存明细ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 按本地库房LToolStripMenuItem
            // 
            this.按本地库房LToolStripMenuItem.Name = "按本地库房LToolStripMenuItem";
            this.按本地库房LToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.按本地库房LToolStripMenuItem.Text = "按本地库房(&L)";
            this.按本地库房LToolStripMenuItem.Click += new System.EventHandler(this.按本地库房LToolStripMenuItem_Click);
            // 
            // 按地区分布AToolStripMenuItem
            // 
            this.按地区分布AToolStripMenuItem.Name = "按地区分布AToolStripMenuItem";
            this.按地区分布AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.按地区分布AToolStripMenuItem.Text = "按地区分布(&A)";
            this.按地区分布AToolStripMenuItem.Click += new System.EventHandler(this.按地区分布AToolStripMenuItem_Click);
            // 
            // 站点SToolStripMenuItem
            // 
            this.站点SToolStripMenuItem.Name = "站点SToolStripMenuItem";
            this.站点SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.站点SToolStripMenuItem.Text = "站点(&S)";
            this.站点SToolStripMenuItem.Click += new System.EventHandler(this.站点SToolStripMenuItem_Click);
            // 
            // 按库房KToolStripMenuItem
            // 
            this.按库房KToolStripMenuItem.Name = "按库房KToolStripMenuItem";
            this.按库房KToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.按库房KToolStripMenuItem.Text = "按库房(&K)";
            this.按库房KToolStripMenuItem.Click += new System.EventHandler(this.按库房KToolStripMenuItem_Click);
            // 
            // 简单模式NToolStripMenuItem
            // 
            this.简单模式NToolStripMenuItem.Name = "简单模式NToolStripMenuItem";
            this.简单模式NToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.简单模式NToolStripMenuItem.Text = "简单模式(&N)";
            this.简单模式NToolStripMenuItem.Click += new System.EventHandler(this.简单模式NToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关闭CToolStripMenuItem.Text = "关闭(&C)";
            this.关闭CToolStripMenuItem.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(386, 45);
            this.panelControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 45);
            this.panel1.TabIndex = 0;
            // 
            // StockTips
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl1);
            this.Name = "StockTips";
            this.Size = new System.Drawing.Size(386, 45);
            this.Load += new System.EventHandler(this.StockTips_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        } 
        #endregion

        #region Load
        private void StockTips_Load(object sender, EventArgs e)
        {
            SetChecked(false);
        } 
        #endregion
    }


    #region StockModel
    public enum StockModel
    {
        /// <summary>
        /// 按站点获取
        /// </summary>
        ByStationName,

        /// <summary>
        /// 按站点所在地区获取
        /// </summary>
        ByStationArea,

        /// <summary>
        /// 按本地站点获取库存
        /// </summary>
        ByLocalStation,

        /// <summary>
        /// 按库房名称
        /// </summary>
        ByStockName,

        /// <summary>
        /// 获取全部
        /// </summary>
        ByAllStock


    } 
    #endregion


}
