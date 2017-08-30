using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using WHC.Framework.Commons;

namespace WHC.Framework.Commons
{
	/// <summary>
	/// Winform���ڴ�ӡ������
	/// </summary>
	public class PrintFormHelper
	{
        /// <summary>
        /// ������ӡ�����Ԥ���Ի���
        /// </summary>
        /// <param name="form">�������</param>
        public static void Print(Form form)
        {
            ScreenCapture capture = new ScreenCapture();
            Image image = capture.CaptureWindow(form.Handle);

            ImagePrintHelper helper = new ImagePrintHelper(image);
            helper.PrintPreview();
        }

        /// <summary>
        /// ��ӡ����ؼ�
        /// </summary>
        /// <param name="control">�ؼ�����</param>
        public static void Print(Control control)
        {
            ScreenCapture capture = new ScreenCapture();
            Image image = capture.CaptureWindow(control.Handle);

            ImagePrintHelper helper = new ImagePrintHelper(image);
            helper.PrintPreview();
        }
	}
}
