using DevExpress.XtraBars.Ribbon;
using POSS;
using POSS.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WHC.Framework.Commons;

namespace MainFrom
{
   public class FormMain: RibbonForm
    {
        private RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private RibbonPage ribbonPage1;
        private RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private RibbonStatusBar ribbonStatusBar1;


        /// <summary>
        /// 接收登录窗传过的用户编号
        /// </summary>
        public string O_id
        {
            get; set;
        }
        private void InitializeComponent()
        {
            DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barLinkContainerItem1
            // 
            barLinkContainerItem1.Caption = "本软件是为A系列提供不足而设计。由QQ:85530815提供\r\n";
            barLinkContainerItem1.Id = 3;
            barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barStaticItem1,
            barLinkContainerItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1293, 147);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "品种折扣设置";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barButtonItem1.SuperTip = superToolTip1;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.Tag = "DSAFS";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "交班情况统计";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "增加功能";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.LeftIndent = 6;
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem1);
            superToolTip2.Items.Add(toolTipSeparatorItem1);
            superToolTip2.Items.Add(toolTipTitleItem3);
            this.ribbonPageGroup1.SuperTip = superToolTip2;
            this.ribbonPageGroup1.Text = "品种折扣";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(barLinkContainerItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 600);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1293, 31);
            // 
            // FormMain
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 631);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormMain()
        {
            InitializeComponent();
            Portal.gc.loginUserInfo = Cache.Instance["loginUserInfo"] as LoginUserInfo;//取出缓存里的值
            Portal.gc.QPossConfig = Cache.Instance["QPossConfig"] as QueryPossConfig;
            this.FormClosing += FormMain_FormClosing;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                //System.Environment.Exit(0); //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
         
             System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form childrenForm in this.MdiChildren)
            {
                if (childrenForm.Name == "Product_price")
                {
                    childrenForm.Visible = true;
                    childrenForm.Activate();
                    this.ribbonPage1.Text = "定价算折扣";
                    return;
                }
            }
            Product_price jh = new Product_price();
            jh.MdiParent = this;
            jh.Show();
            jh.WindowState = FormWindowState.Maximized;
            this.ribbonPage1.Text = "定价算折扣";
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Portal.gc.loginUserInfo.O_Name == "administrator" && Portal.gc.loginUserInfo.O_id == "1")
            {
                foreach (Form childrenForm in this.MdiChildren)
                {
                    if (childrenForm.Name == "FormQueryLs")
                    {
                        childrenForm.Visible = true;
                        childrenForm.Activate();
                        this.ribbonPage1.Text = "交班";
                        return;
                    }
                }
                FormQueryLs jh = new FormQueryLs();
                jh.MdiParent = this;
                jh.Show();
                jh.WindowState = FormWindowState.Maximized;
                this.ribbonPage1.Text = "交班";
            }
            else
            {
                MessagboxUit.ShowError("请用超级管理员登录！");
            }
            
        }
    }
}
