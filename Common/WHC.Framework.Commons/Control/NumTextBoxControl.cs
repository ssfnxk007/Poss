using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace WHC.Framework.Commons
{
    public class NumTextBoxControl : TextEdit
    {
        [Description("字段中文名称")]
        public string ChineseColumnName { get; set; }

        [Description("字段名称")]
        public string ColumnName { get; set; }

        public NumTextBoxControl()
        {
            this.Leave += NumTextBoxControl_Leave;
            this.ToolTip = "有效条件：>100，<100，1-100，>=100，<=100，<>100，100\n\r条件描述：大于100，小于100，1至100，大于等于100.....\n\r多条件以,分开如：100,200,300\n\r条件描述：值等于100，或者等于200，或者等于300";
        }

        private void NumTextBoxControl_Leave(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                MessageUtil.ShowTips("请输入有效的查询值！\n\r有效条件如下：>100，<100，1-100，>=100，<=100，<>100，100\n\r条件描述：大于100，小于100，1至100，大于等于100.....\n\r多条件以,分开如：100,200,300\n\r条件描述：值等于100，或者等于200，或者等于300");
                this.Focus();
                this.SelectAll();
            }
        }
        /// <summary>
        /// 判断输入字符是否正确
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool CheckString(string s)
        {
            string text = s.Trim();
            if (text.IsNumber(true))
                return true;
            else if (text.Length>2&&( text.Substring(0, 2) == ">=" || text.Substring(0, 2) == "<=" || text.Substring(0, 2) == "<>"))
            {
                return text.Remove(0, 2).IsNumber(true);
            }
            else if (text.Length>1&&( text.Substring(0, 1) == ">" || text.Substring(0, 1) == "<" || text.Substring(0, 1) == "="))
            {
                return text.Remove(0, 1).IsNumber(true);
            }
            else if (text.StringCount("-") == 3)
            {
                string[] s1 = text.Split('-');
                return (s1[1].IsNumber(true) && s1[3].IsNumber(true));
            }
            else if (text.StringCount("-") == 2)
            {
                string[] s1 = text.Split('-');
                if (string.IsNullOrWhiteSpace(s1[0]))
                {
                    return (s1[1].IsNumber(true) && s1[2].IsNumber(true));
                }
                else
                {
                    return (s1[0].IsNumber(true) && s1[2].IsNumber(true));
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断输入是否合理
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(Text)) return true;

            bool checkedinput = true;
            string text = this.Text.TrimEnd();
            text = ReplaceText(text);
            string[] value = text.Split(',');
            foreach (string s in value)
            {
                if (!CheckString(s))
                {
                    checkedinput = false;
                    break;
                }
            }
            return checkedinput;
        }

        /// <summary>
        /// 返回SQL语法文本
        /// </summary>
        /// <returns></returns>
        public string Syntax()
        {
            if (string.IsNullOrWhiteSpace(Text)) return string.Empty;
            string result = string.Empty;
            if (CheckInput())
            {
                string text = this.Text.TrimEnd();
                text = ReplaceText(text);
                string[] value = text.Split(',');
                foreach (string s in value)
                {
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        result += Syntax(s);
                    }
                    else
                    {
                        result +=string.Format(" OR {0}", Syntax(s));
                    }
                }
            }
            return string.Format("({0})", result);
        }
        private string Syntax(string s)
        {
            string result = string.Empty;
            string text = s.Trim();
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            if (text.IsNumber(true))
                result = string.Format(" {0}={1} ", this.ColumnName, text);
            else if (text.Substring(0, 2) == ">=" || text.Substring(0, 2) == "<=" || text.Substring(0, 2) == "<>")
            {
                result = string.Format(" {0}{1}", this.ColumnName,  text);
            }
            else if (text.Substring(0, 1) == ">" || text.Substring(0, 1) == "<" || text.Substring(0, 1) == "=")
            {
                result = string.Format(" {0}{1}", this.ColumnName, text);
            }
            else if (text.StringCount("-") == 3)
            {
                string[] s1 = text.Split('-');
                if (s1[1].ToDecimal() > s1[3].ToDecimal())
                {
                    result = string.Format(" {0} BETWEEN -{1} AND -{2} ", this.ColumnName, s1[1], s1[3]);
                }
                else
                {
                    result = string.Format(" {0} BETWEEN -{1} AND -{2} ", this.ColumnName, s1[3], s1[1]);
                }
            }
            else if (text.StringCount("-") == 2)
            {
                string[] s1 = text.Split('-');
                if (string.IsNullOrWhiteSpace(s1[0]))
                {
                    result = string.Format(" {0} BETWEEN -{1} AND {2} ", this.ColumnName, s1[1], s1[2]);
                }
                else
                {
                    result = string.Format(" {0} BETWEEN -{1} AND {2} ", this.ColumnName, s1[2], s1[0]);
                }
            }
            else
            {
                result = string.Empty;
            }
            return result;
        }
        private string OperatorChar(string s)
        {
            if (s == ">")
            {
                return "大于";
            }
            else if (s == ">=")
            {
                return "大于等于";
            }
            else if (s == "<")
            {
                return "小于";
            }
            else if (s == "<=")
            {
                return "小于等于";
            }
            else if (s == "<>")
            {
                return "不等于";
            }
            else if (s == "-")
            {
                return "在『{0}』和『{1}』之间";
            }
            else { return string.Empty; }

        }
        private static string ReplaceText(string text)
        {
            text = text.Replace("１", "1");
            text = text.Replace("２", "2");
            text = text.Replace("３", "3");
            text = text.Replace("４", "4");
            text = text.Replace("５", "5");
            text = text.Replace("６", "6");
            text = text.Replace("７", "7");
            text = text.Replace("８", "8");
            text = text.Replace("９", "9");
            text = text.Replace("０", "0");
            text = text.Replace("　", "");
            text = text.Replace("，", ",");
            text = text.Replace("。", ".");
            text = text.Replace("－", "-");
            text = text.Replace("》=", ">=");
            text = text.Replace("》", ">");
            text = text.Replace("《=", "<=");
            text = text.Replace("《", "<");
            text = text.Replace("《》", "<>");
            text = text.Replace("+", "");
            text = text.Replace("＋", "");
            return text;
        }
        /// <summary>
        /// 返回中文查询文本
        /// </summary>
        /// <returns></returns>
        public string ChineseSyntax()
        {
            if (string.IsNullOrWhiteSpace(Text)) return string.Empty;
            string result = string.Empty;
            if (CheckInput())
            {
                string text = this.Text.TrimEnd();
                text = ReplaceText(text);
                string[] value = text.Split(',');
                foreach (string s in value)
                {
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        result +=ChineseSyntax(s);
                    }
                    else
                    {
                        result += string.Format(" 或者 {0}", ChineseSyntax(s));
                    }
                }
            }
            return result;

        }

        private string ChineseSyntax(string s)
        {
            string result = string.Empty;
            string text = s.Trim();
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            if (text.IsNumber(true))
            {
                result = string.Format(" 〖{0}〗等于『{1}』", this.ChineseColumnName, text);
            }
            else if (text.Substring(0, 2) == ">=" || text.Substring(0, 2) == "<=" || text.Substring(0, 2) == "<>")
            {
                result = string.Format(" 〖{0}〗{1}『{2}』", this.ChineseColumnName, this.OperatorChar(text.Substring(0, 2)), text.Remove(0, 2));
            }
            else if (text.Substring(0, 1) == ">" || text.Substring(0, 1) == "<" || text.Substring(0, 1) == "=")
            {
                result = string.Format(" 〖{0}〗{1}『{2}』", this.ChineseColumnName, this.OperatorChar(text.Substring(0, 1)), text.Remove(0, 1));
            }
            else if (text.StringCount("-") == 3)
            {
                string[] s1 = text.Split('-');
                if (s1[1].ToDecimal() > s1[3].ToDecimal())
                {
                    result = string.Format(" {0}{1}", this.ChineseColumnName, string.Format(this.OperatorChar("-"), "-" + s1[1], "-" + s1[3]));
                }
                else
                {
                    result = string.Format(" {0}{1}", this.ChineseColumnName, string.Format(this.OperatorChar("-"), "-" + s1[3], "-" + s1[1]));
                }
            }
            else if (text.StringCount("-") == 2)
            {
                string[] s1 = text.Split('-');
                if (string.IsNullOrWhiteSpace(s1[0]))
                {
                    result = string.Format(" 〖{0}〗{1}", this.ChineseColumnName, string.Format(this.OperatorChar("-"), "-" + s1[1], s1[2]));
                }
                else
                {
                    result = string.Format(" 〖{0}〗{1}", this.ChineseColumnName, string.Format(this.OperatorChar("-"), "-" + s1[2], s1[0]));
                }
            }
            else
            {
                result = string.Empty;
            }
            return result;
        }
        /// <summary>
        /// 清除条件
        /// </summary>
        public void Clear()
        {
            this.Text = string.Empty;
        }
    }

}
