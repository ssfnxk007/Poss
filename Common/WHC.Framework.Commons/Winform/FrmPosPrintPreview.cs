using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// POS小票打印的打印预览管理界面
    /// </summary>
    public partial class FrmPosPrintPreview : Form
    {
        /// <summary>
        /// 设置待打印的内容
        /// </summary>
        public string PrintString = "";
        /// <summary>
        /// 指定默认的小票打印机名称，用作快速POS打印
        /// </summary>
        public string PrinterName = "Microsoft XPS Document Writer";

        /// <summary>
        /// POS打印机的边距,默认为2
        /// </summary>
        public int POSPageMargin = 2;

        /// <summary>
        /// POS打印机默认横向还是纵向，默认设置为纵向(false)
        /// </summary>
        public bool Landscape = false;

        private MultipadPrintDocument _printdocument = new MultipadPrintDocument();
        private Font printFont = new Font("宋体", 9f);

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmPosPrintPreview()
        {
            InitializeComponent();
        }

        private void FrmPosPrintPreview_Load(object sender, EventArgs e)
        {
            this.txtContent.Text = PrintString;
            this._printdocument.Text = this.txtContent.Text;
            this._printdocument.Font = printFont;
            this._printdocument.DefaultPageSettings.Landscape = Landscape;
            int posMargin = POSPageMargin;
            this._printdocument.DefaultPageSettings.Margins = new Margins(posMargin, posMargin, posMargin, posMargin);
            this._printdocument.PrinterSettings.PrinterName = PrinterName;
        }

        private void btnPrintSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = _printdocument;
            psd.PageSettings.Margins = PrinterUnitConvert.Convert(psd.PageSettings.Margins,
                PrinterUnit.ThousandthsOfAnInch, PrinterUnit.HundredthsOfAMillimeter);

            if (psd.ShowDialog() == DialogResult.OK)
            {
                _printdocument.Print();
            }
            else
            {
                psd.PageSettings.Margins = PrinterUnitConvert.Convert(psd.PageSettings.Margins,
                    PrinterUnit.HundredthsOfAMillimeter, PrinterUnit.ThousandthsOfAnInch);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            _printdocument.Text = this.txtContent.Text;
            _printdocument.Font = printFont;
            ppd.Document = _printdocument;
            ppd.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            _printdocument.Text = this.txtContent.Text;
            _printdocument.Font = printFont;
            pd.Document = _printdocument;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                _printdocument.Print();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
