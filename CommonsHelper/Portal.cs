using System;
using System.Collections.Generic;
using System.Text;

using WHC.Framework.Commons;
using System.Diagnostics;


namespace POSS
{
    public class Portal
    {
        public static GlobalControl gc = new GlobalControl();
        public static INIFileUtil iniHelper = new INIFileUtil(DirectoryUtil.GetCurrentDirectory() + @"\Values.ini");
    
    }
}
