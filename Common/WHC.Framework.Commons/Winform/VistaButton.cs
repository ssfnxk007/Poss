using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// ����Vista������ɫ�Ĳ���Ч����Բ�ǵİ�ť�ؼ���������Բο�
    /// http://www.codeproject.com/KB/buttons/VistaButton.aspx
    /// </summary>
    [DefaultEvent("Click")]
    public class VistaButton : System.Windows.Forms.UserControl
    {
        #region -  Designer  -

        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public VistaButton()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
            mFadeIn.Interval = 30;
            mFadeOut.Interval = 30;
        }

        /// <summary>
        /// �ͷſؼ���Դ
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region -  Component Designer generated code  -

        private void InitializeComponent()
        {
            // 
            // VistaButton
            // 
            this.Name = "VistaButton";
            this.Size = new System.Drawing.Size(100, 32);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VistaButton_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VistaButton_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VistaButton_KeyDown);
            this.MouseEnter += new System.EventHandler(this.VistaButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.VistaButton_MouseLeave);
            this.MouseUp += new MouseEventHandler(VistaButton_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VistaButton_MouseDown);
            this.GotFocus += new EventHandler(VistaButton_MouseEnter);
            this.LostFocus += new EventHandler(VistaButton_MouseLeave);
            this.mFadeIn.Tick += new EventHandler(mFadeIn_Tick);
            this.mFadeOut.Tick += new EventHandler(mFadeOut_Tick);
            this.Resize += new EventHandler(VistaButton_Resize);
        }

        #endregion

        #endregion

        #region -  Enums  -

        /// <summary>
        /// �ÿؼ������״̬
        /// </summary>
        enum State { None, Hover, Pressed };

        /// <summary>
        /// ����겻�ڿؼ������ʱ�򣬻��ư�ť������ʽ
        /// </summary>
        public enum Style
        {
            /// <summary>
            /// �������Ʒ�ʽ
            /// </summary>
            Default,

            /// <summary>
            /// �������ͣ��ʱ����Ʊ���
            /// </summary>
            Flat
        };

        #endregion

        #region -  Properties  -

        #region -  Private Variables  -

        private bool calledbykey = false;
        private State mButtonState = State.None;
        private Timer mFadeIn = new Timer();
        private Timer mFadeOut = new Timer();
        private int mGlowAlpha = 0;

        #endregion

        #region -  Text  -

        private string mText;
        /// <summary>
        /// ��ʾ�ڰ�ť�ϵ��ı�
        /// </summary>
        [Category("Text"),
         Description("��ʾ�ڰ�ť�ϵ��ı�")]
        public string ButtonText
        {
            get { return mText; }
            set { mText = value; this.Invalidate(); }
        }

        private Color mForeColor = Color.White;
        /// <summary>
        /// �����ı�����ɫ��ǰ��ɫ��
        /// </summary>
        [Category("Text"),
         Browsable(true),
         DefaultValue(typeof(Color), "White"),
         Description("�����ı�����ɫ��ǰ��ɫ��")]
        public override Color ForeColor
        {
            get { return mForeColor; }
            set { mForeColor = value; this.Invalidate(); }
        }

        private ContentAlignment mTextAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// ��ť�ı��Ķ��뷽ʽ
        /// </summary>
        [Category("Text"),
         DefaultValue(typeof(ContentAlignment), "MiddleCenter"),
         Description("��ť�ı��Ķ��뷽ʽ")]
        public ContentAlignment TextAlign
        {
            get { return mTextAlign; }
            set { mTextAlign = value; this.Invalidate(); }
        }

        #endregion

        #region -  Image  -

        private Image mImage;
        /// <summary>
        /// ��ť��ʾ��ͼƬ
        /// </summary>
        [Category("Image"),
         DefaultValue(null),
         Description("��ť��ʾ��ͼƬ")]
        public Image Image
        {
            get { return mImage; }
            set { mImage = value; this.Invalidate(); }
        }

        private ContentAlignment mImageAlign = ContentAlignment.MiddleLeft;
        /// <summary>
        /// ��ťͼƬ���뷽ʽ
        /// </summary>
        [Category("Image"),
         DefaultValue(typeof(ContentAlignment), "MiddleLeft"),
         Description("��ťͼƬ���뷽ʽ")]
        public ContentAlignment ImageAlign
        {
            get { return mImageAlign; }
            set { mImageAlign = value; this.Invalidate(); }
        }

        private Size mImageSize = new Size(24, 24);
        /// <summary>
        /// ��ťͼƬ�Ĵ�С��Ĭ��Ϊ24x24
        /// </summary>
        [Category("Image"),
         DefaultValue(typeof(Size), "24, 24"),
         Description("��ťͼƬ�Ĵ�С��Ĭ��Ϊ24x24")]
        public Size ImageSize
        {
            get { return mImageSize; }
            set { mImageSize = value; this.Invalidate(); }
        }

        #endregion

        #region -  Appearance  -

        private Style mButtonStyle = Style.Default;
        /// <summary>
        /// ���õ�����ƿ�����ť�����Ƿ����
        /// </summary>
        [Category("Appearance"),
         DefaultValue(typeof(Style), "Default"),
         Description("���õ�����ƿ�����ť�����Ƿ����")]
        public Style ButtonStyle
        {
            get { return mButtonStyle; }
            set { mButtonStyle = value; this.Invalidate(); }
        }

        private int mCornerRadius = 8;
        /// <summary>
        ///  ��ťԲ�ǰ뾶��Բ�ǰ뾶Խ�󣬱߽�Խƽ���������Բ��ô��ڿؼ��߶ȵ�һ�롣
        /// </summary>
        [Category("Appearance"),
         DefaultValue(8),
         Description("��ťԲ�ǰ뾶��Բ�ǰ뾶Խ�󣬱߽�Խƽ���������Բ��ô��ڿؼ��߶ȵ�һ�롣")]
        public int CornerRadius
        {
            get { return mCornerRadius; }
            set { mCornerRadius = value; this.Invalidate(); }
        }

        private Color mHighlightColor = Color.White;
        /// <summary>
        /// �����İ�ť�ϵĸ�����ʾ����ɫ
        /// </summary>
        [Category("Appearance"),
         DefaultValue(typeof(Color), "White"),
         Description("�����İ�ť�ϵĸ�����ʾ����ɫ")]
        public Color HighlightColor
        {
            get { return mHighlightColor; }
            set { mHighlightColor = value; this.Invalidate(); }
        }

        private Color mButtonColor = Color.Black;
        /// <summary>
        /// �ڳ�����ɫBaseColor����İ�ť�ײ���ɫ
        /// </summary>
        [Category("Appearance"),
         DefaultValue(typeof(Color), "Black"),
         Description("�ڳ�����ɫBaseColor����İ�ť�ײ���ɫ")]
        public Color ButtonColor
        {
            get { return mButtonColor; }
            set { mButtonColor = value; this.Invalidate(); }
        }

        private Color mGlowColor = Color.FromArgb(141, 189, 255);
        /// <summary>
        /// ������ڿؼ������ʱ�򣬰�ť�ķ�����ɫ
        /// </summary>
        [Category("Appearance"),
         DefaultValue(typeof(Color), "141,189,255"),
         Description("������ڿؼ������ʱ�򣬰�ť�ķ�����ɫ")]
        public Color GlowColor
        {
            get { return mGlowColor; }
            set { mGlowColor = value; this.Invalidate(); }
        }

        private Image mBackImage;
        /// <summary>
        /// ��ť�ı���ͼƬ��������ڰ�ť���棬ͼƬ������
        /// </summary>
        [Category("Appearance"),
         DefaultValue(null),
         Description("��ť�ı���ͼƬ��������ڰ�ť���棬ͼƬ������")]
        public Image BackImage
        {
            get { return mBackImage; }
            set { mBackImage = value; this.Invalidate(); }
        }

        private Color mBaseColor = Color.Black;
        /// <summary>
        /// ��ťĬ�ϵĳ�����ɫ���������ΪTransparent���ɻ�ò���Ч��
        /// </summary>
        [Category("Appearance"),
         DefaultValue(typeof(Color), "Black"),
         Description("��ťĬ�ϵĳ�����ɫ���������ΪTransparent���ɻ�ò���Ч��")]
        public Color BaseColor
        {
            get { return mBaseColor; }
            set { mBaseColor = value; this.Invalidate(); }
        }

        #endregion

        #endregion

        #region -  Functions  -

        private GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X, y = r.Y, w = r.Width, h = r.Height;
            GraphicsPath rr = new GraphicsPath();
            rr.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            rr.AddLine(x + r1, y, x + w - r2, y);
            rr.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
            rr.AddLine(x + w, y + r2, x + w, y + h - r3);
            rr.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
            rr.AddLine(x + w - r3, y + h, x + r4, y + h);
            rr.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
            rr.AddLine(x, y + h - r4, x, y + r1);
            return rr;
        }

        private StringFormat StringFormatAlignment(ContentAlignment textalign)
        {
            StringFormat sf = new StringFormat();
            switch (textalign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopRight:
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomRight:
                    sf.LineAlignment = StringAlignment.Far;
                    break;
            }
            switch (textalign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    sf.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.BottomCenter:
                    sf.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    sf.Alignment = StringAlignment.Far;
                    break;
            }
            return sf;
        }

        #endregion

        #region -  Drawing  -

        /// <summary>
        /// ʹ��ButtonColor���Ի��ƿؼ�����߿�
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawOuterStroke(Graphics g)
        {
            if (this.ButtonStyle == Style.Flat && this.mButtonState == State.None) { return; }
            Rectangle r = this.ClientRectangle;
            r.Width -= 1; r.Height -= 1;
            using (GraphicsPath rr = RoundRect(r, CornerRadius, CornerRadius, CornerRadius, CornerRadius))
            {
                using (Pen p = new Pen(this.ButtonColor))
                {
                    g.DrawPath(p, rr);
                }
            }
        }

        /// <summary>
        /// ʹ��HighlightColor���������ƿؼ����ڱ߿�
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawInnerStroke(Graphics g)
        {
            if (this.ButtonStyle == Style.Flat && this.mButtonState == State.None) { return; }
            Rectangle r = this.ClientRectangle;
            r.X++; r.Y++;
            r.Width -= 3; r.Height -= 3;
            using (GraphicsPath rr = RoundRect(r, CornerRadius, CornerRadius, CornerRadius, CornerRadius))
            {
                using (Pen p = new Pen(this.HighlightColor))
                {
                    g.DrawPath(p, rr);
                }
            }
        }

        /// <summary>
        /// ʹ�ñ���ͼ���BaseColor�����ƿؼ�����ɫ
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawBackground(Graphics g)
        {
            if (this.ButtonStyle == Style.Flat && this.mButtonState == State.None) { return; }
            int alpha = (mButtonState == State.Pressed) ? 204 : 127;
            Rectangle r = this.ClientRectangle;
            r.Width--; r.Height--;
            using (GraphicsPath rr = RoundRect(r, CornerRadius, CornerRadius, CornerRadius, CornerRadius))
            {
                using (SolidBrush sb = new SolidBrush(this.BaseColor))
                {
                    g.FillPath(sb, rr);
                }
                SetClip(g);
                if (this.BackImage != null) { g.DrawImage(this.BackImage, this.ClientRectangle); }
                g.ResetClip();
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(alpha, this.ButtonColor)))
                {
                    g.FillPath(sb, rr);
                }
            }
        }

        /// <summary>
        /// ���ڰ�ť�Ϸ���ʱ��ʹ��HightlightColor������ͻ����ʾЧ��
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawHighlight(Graphics g)
        {
            if (this.ButtonStyle == Style.Flat && this.mButtonState == State.None) { return; }
            int alpha = (mButtonState == State.Pressed) ? 60 : 150;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height / 2);
            using (GraphicsPath r = RoundRect(rect, CornerRadius, CornerRadius, 0, 0))
            {
                using (LinearGradientBrush lg = new LinearGradientBrush(r.GetBounds(),
                                            Color.FromArgb(alpha, this.HighlightColor),
                                            Color.FromArgb(alpha / 3, this.HighlightColor),
                                            LinearGradientMode.Vertical))
                {
                    g.FillPath(lg, r);
                }
            }
        }

        /// <summary>
        /// ������������ڣ�ʹ��GlowColor���������Ʒ���İ�ť
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawGlow(Graphics g)
        {
            if (this.mButtonState == State.Pressed) { return; }
            SetClip(g);
            using (GraphicsPath glow = new GraphicsPath())
            {
                glow.AddEllipse(-5, this.Height / 2 - 10, this.Width + 11, this.Height + 11);
                using (PathGradientBrush gl = new PathGradientBrush(glow))
                {
                    gl.CenterColor = Color.FromArgb(mGlowAlpha, this.GlowColor);
                    gl.SurroundColors = new Color[] { Color.FromArgb(0, this.GlowColor) };
                    g.FillPath(gl, glow);
                }
            }
            g.ResetClip();
        }

        /// <summary>
        /// Ϊ��ť�����ı�
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawText(Graphics g)
        {
            StringFormat sf = StringFormatAlignment(this.TextAlign);
            Rectangle r = new Rectangle(8, 8, this.Width - 17, this.Height - 17);
            g.DrawString(this.ButtonText, this.Font, new SolidBrush(this.ForeColor), r, sf);
        }

        /// <summary>
        /// Ϊ��ť����ͼƬ
        /// </summary>
        /// <param name="g">�����¼��е�Graphics����</param>
        private void DrawImage(Graphics g)
        {
            if (this.Image == null) { return; }
            Rectangle r = new Rectangle(8, 8, this.ImageSize.Width, this.ImageSize.Height);
            switch (this.ImageAlign)
            {
                case ContentAlignment.TopCenter:
                    r = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, 8, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.TopRight:
                    r = new Rectangle(this.Width - 8 - this.ImageSize.Width, 8, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.MiddleLeft:
                    r = new Rectangle(8, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.MiddleCenter:
                    r = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.MiddleRight:
                    r = new Rectangle(this.Width - 8 - this.ImageSize.Width, this.Height / 2 - this.ImageSize.Height / 2, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.BottomLeft:
                    r = new Rectangle(8, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.BottomCenter:
                    r = new Rectangle(this.Width / 2 - this.ImageSize.Width / 2, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                    break;
                case ContentAlignment.BottomRight:
                    r = new Rectangle(this.Width - 8 - this.ImageSize.Width, this.Height - 8 - this.ImageSize.Height, this.ImageSize.Width, this.ImageSize.Height);
                    break;
            }
            g.DrawImage(this.Image, r);
        }

        private void SetClip(Graphics g)
        {
            Rectangle r = this.ClientRectangle;
            r.X++; r.Y++; r.Width -= 3; r.Height -= 3;
            using (GraphicsPath rr = RoundRect(r, CornerRadius, CornerRadius, CornerRadius, CornerRadius))
            {
                g.SetClip(rr);
            }
        }

        #endregion

        #region -  Private Subs  -

        private void VistaButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DrawBackground(e.Graphics);
            DrawHighlight(e.Graphics);
            DrawImage(e.Graphics);
            DrawText(e.Graphics);
            DrawGlow(e.Graphics);
            DrawOuterStroke(e.Graphics);
            DrawInnerStroke(e.Graphics);
        }

        private void VistaButton_Resize(object sender, EventArgs e)
        {
            Rectangle r = this.ClientRectangle;
            r.X -= 1; r.Y -= 1;
            r.Width += 2; r.Height += 2;
            using (GraphicsPath rr = RoundRect(r, CornerRadius, CornerRadius, CornerRadius, CornerRadius))
            {
                this.Region = new Region(rr);
            }
        }

        #region -  Mouse and Keyboard Events  -

        private void VistaButton_MouseEnter(object sender, EventArgs e)
        {
            mButtonState = State.Hover;
            mFadeOut.Stop();
            mFadeIn.Start();
        }
        private void VistaButton_MouseLeave(object sender, EventArgs e)
        {
            mButtonState = State.None;
            if (this.mButtonStyle == Style.Flat) { mGlowAlpha = 0; }
            mFadeIn.Stop();
            mFadeOut.Start();
        }

        private void VistaButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mButtonState = State.Pressed;
                if (this.mButtonStyle != Style.Flat) { mGlowAlpha = 255; }
                mFadeIn.Stop();
                mFadeOut.Stop();
                this.Invalidate();
            }
        }

        private void mFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat) { mGlowAlpha = 0; }
            if (mGlowAlpha + 30 >= 255)
            {
                mGlowAlpha = 255;
                mFadeIn.Stop();
            }
            else
            {
                mGlowAlpha += 30;
            }
            this.Invalidate();
        }

        private void mFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.ButtonStyle == Style.Flat) { mGlowAlpha = 0; }
            if (mGlowAlpha - 30 <= 0)
            {
                mGlowAlpha = 0;
                mFadeOut.Stop();
            }
            else
            {
                mGlowAlpha -= 30;
            }
            this.Invalidate();
        }

        private void VistaButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs m = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                VistaButton_MouseDown(sender, m);
            }
        }

        private void VistaButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                MouseEventArgs m = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);
                calledbykey = true;
                VistaButton_MouseUp(sender, m);
            }
        }

        private void VistaButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mButtonState = State.Hover;
                mFadeIn.Stop();
                mFadeOut.Stop();
                this.Invalidate();
                if (calledbykey == true) { this.OnClick(EventArgs.Empty); calledbykey = false; }
            }
        }

        #endregion

        #endregion

    }
}