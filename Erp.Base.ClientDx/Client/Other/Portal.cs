using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WHC.Framework.Commons;
using System.Diagnostics;

using WHC.Security.Common;
using DevExpress.LookAndFeel;

namespace Erp.Base
{
    public class Portal
    {
        public static GlobalControl gc = new GlobalControl();
        public static INIFileUtil iniHelper = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
      
    }
}
