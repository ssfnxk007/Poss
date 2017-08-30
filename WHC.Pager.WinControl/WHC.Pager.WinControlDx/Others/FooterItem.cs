using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization;


namespace WHC.Pager.WinControl
{
    [Serializable]
    public class FooterItem 
    {
        public string FieldName { get; set; }

        public string Format { get; set; }

        public string Describe { get; set; }

        public FooterItem(string fieldName, string format, string describe)
        { 
            this.FieldName = fieldName;
            this.Format = format;
            this.Describe = describe;
        }
        public FooterItem(string fieldName, string format)
        {
            this.FieldName = fieldName;
            this.Format = format;
        }
        public FooterItem(string fieldName)
        {
            this.FieldName = fieldName;
            this.Format = string.Empty;
        }
        public FooterItem()
        { }

    }
}
