using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSS.Entity;
using WHC.Framework.Commons;
using Microsoft.VisualBasic;

namespace POSS
{
   public class Pos58Helper
    {
        public struct keyAndValue
        {
            public String keyStr;
            public String valueStr;
        }

        private List<keyAndValue> keyAndValueListTop = new List<keyAndValue>();
        /// <summary>  
        /// 小票头部信息  
        /// </summary>  
        public List<keyAndValue> KeyAndValueListTop
        {
            get { return keyAndValueListTop; }
        }
        /// <summary>  
        /// 增加小票头部键值对  
        /// </summary>  
        /// <param name="keyStr">键</param>  
        /// <param name="valueStr">值</param>  
        public void AddKeyAndValueTop(String keyStr, String valueStr)
        {
            keyAndValue keyandvale = new keyAndValue();
            keyandvale.keyStr = keyStr;
            keyandvale.valueStr = valueStr;
            this.keyAndValueListTop.Add(keyandvale);
        }

        private List<keyAndValue> keyAndValueListFoot = new List<keyAndValue>();
        /// <summary>  
        /// 小票底部信息  
        /// </summary>  
        public List<keyAndValue> KeyAndValueListFoot
        {
            get { return keyAndValueListFoot; }
        }
        /// <summary>  
        /// 增加小票底部键值对  
        /// </summary>  
        /// <param name="keyStr">键</param>  
        /// <param name="valueStr">值</param>  
        public void AddKeyAndValueFoot(String keyStr, String valueStr)
        {
            keyAndValue keyandvale = new keyAndValue();
            keyandvale.keyStr = keyStr;
            keyandvale.valueStr = valueStr;
            this.keyAndValueListFoot.Add(keyandvale);
        }
        private String ticketSignature;
        /// <summary>  
        /// 小票顶部签名  
        /// </summary>  
        public String TicketSignature
        {
            get { return ticketSignature; }
            set { ticketSignature = value; }
        }

        private String ticketTitle;
        /// <summary>  
        /// 小票的标题  
        /// </summary>  
        public String TicketTitle
        {
            get { return ticketTitle; }
            set { ticketTitle = value; }
        }
        private String ticketFooter;

        /// <summary>  
        /// 小票底部签名  
        /// </summary>  
        public String TicketFooter
        {
            get { return ticketFooter; }
            set { ticketFooter = value; }
        }
        private List<SimpleProductInfo> dtGoodsList;

        /// <summary>  
        /// 商品列表信息  
        /// </summary>  
        public List<SimpleProductInfo> DtGoodsList
        {
            get { return dtGoodsList; }
            set { dtGoodsList = value; }
        }
        private int ticketWidth;

        /// <summary>  
        /// 小票宽度,按字符数计算  
        /// </summary>  
        public int TicketWidth
        {
            get { return ticketWidth; }
            set { ticketWidth = value; }
        }
        private Decimal colper1;

        /// <summary>  
        /// 商品列表中第一个标题所占小票总宽度的百分比  
        /// </summary>  
        public Decimal Colper1
        {
            get { return colper1; }
            set { colper1 = value; }
        }
        private Decimal colper2;
        /// <summary>  
        /// 商品列表中第二个标题所占小票总宽度的百分比  
        /// </summary>  
        public Decimal Colper2
        {
            get { return colper2; }
            set { colper2 = value; }
        }
        private Decimal colper3;
        /// <summary>  
        /// 商品列表中第三个标题所占小票总宽度的百分比  
        /// </summary>  
        public Decimal Colper3
        {
            get { return colper3; }
            set { colper3 = value; }
        }

        private Decimal colper4;

        /// <summary>  
        /// 商品列表中第四个标题所占小票总宽度的百分比  
        /// </summary>  
        public Decimal Colper4
        {
            get { return colper4; }
            set { colper4 = value; }
        }
        /// <summary>
        /// 商品列表中 商品名称 所占小票总宽度的百分比 
        /// </summary>
        public Decimal Colper
        {
            get { return colper4; }
            set { colper4 = value; }
        }

        private Char signWeight;
        /// <summary>  
        /// 重要分隔符的样式  
        /// </summary>  
        public Char SignWeight
        {
            get { return signWeight; }
            set { signWeight = value; }
        }
        private Char signLight;
        /// <summary>  
        /// 一般分隔符的样式  
        /// </summary>  
        public Char SignLight
        {
            get { return signLight; }
            set { signLight = value; }
        } /// <summary>  
          /// 排列商品列表的表头信息  
          /// </summary>  
          /// <param name="arg">表头标题</param>  
          /// <param name="charNum">标题所占总字符数，一般按照小票总宽度的百分比来设置</param>  
          /// <returns>带有格式的标题</returns>  
        private String ArrangeArgPosition(String arg, int ticketwidth, Decimal colPer)
        {
            String result = String.Empty;
            try
            {
                int charNum = Convert.ToInt32(ticketWidth * colPer);
                if (0 != charNum)
                {
                    int argcount = System.Text.Encoding.Default.GetByteCount(arg);

                    for (int i = 0; i < charNum - argcount; i++)
                    {
                        arg = arg + " ";
                    }
                    result = result + arg;
                }
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }
            return result;

        }
        /// <summary>  
        /// 设置小票头部信息，可以自动区分汉字还是英文，格式只限2行  
        /// </summary>  
        /// <param name="arg">小票头部内容</param>  
        /// <param name="ticketwidth">小票宽度，按照字符个数计算</param>  
        /// <param name="isMiddle">是否中间对齐</param>  
        /// <returns>带格式的小票头部信息</returns>  
        private String SetArgPosition(String arg, int ticketwidth, bool isMiddle)
        {
            String result = String.Empty;
            try
            {


                int argnum = System.Text.Encoding.Default.GetByteCount(arg);
                if (argnum <= ticketwidth)
                {
                    if (isMiddle)
                    {
                        for (int i = 0; i < (ticketwidth - argnum) / 2; i++)
                        {
                            result = " " + result;
                        }
                    }
                    result = result + arg + "\r\n";

                }
                else
                {
                    for (int i = 0; i <= ticketwidth / 2; i++)
                    {
                        int temp = ticketwidth / 2 + i;
                        if (ticketwidth == System.Text.Encoding.Default.GetByteCount(arg.Substring(0, temp)) || ticketwidth == System.Text.Encoding.Default.GetByteCount(arg.Substring(0, temp)) - 1)
                        {
                            result = result + arg.Substring(0, temp);
                            result = result + "\r\n";
                            result = result + arg.Substring(temp, arg.Length - (temp)) + "\r\n";
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }
            return result;
        }
        /// <summary>  
        /// 设置小票各部分的分隔线  
        /// </summary>  
        /// <param name="ticketwidth">小票的宽度，按照字符个数计算</param>  
        /// <param name="signChar">分隔线的样式</param>  
        /// <returns>小票的分隔线</returns>  
        private String CreateLine(int ticketwidth, Char signChar)
        {
            String result = String.Empty;
            try
            {
                for (int i = 0; i < ticketwidth; i++)
                {
                    result += signChar;
                }
                result += "\r\n";
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }


            return result;
        }

        /// <summary>  
        /// 生成小票  
        /// </summary>  
        /// <param name="ticket">TicketSet对象</param>  
        /// <returns>最终小票结果</returns>  
        public String Ticket()
        {
            String ticketStr = String.Empty;
            try
            {
                //小票头部  
                ticketStr = SetArgPosition(this.TicketSignature, this.TicketWidth, true);
                ticketStr += SetArgPosition(this.TicketTitle, this.TicketWidth, true);
                ticketStr += CreateLine(this.TicketWidth, this.signWeight);

                //小票上部内容  
                for (int i = 0; i < this.KeyAndValueListTop.Count; i++)
                {
                    ticketStr += this.KeyAndValueListTop[i].keyStr + this.KeyAndValueListTop[i].valueStr + "\r\n";
                }

                //商品列表  
                ticketStr += ItemsList();

                //小票下部内容  
                for (int i = 0; i < this.KeyAndValueListFoot.Count; i++)
                {
                    ticketStr += this.KeyAndValueListFoot[i].keyStr + this.KeyAndValueListFoot[i].valueStr + "\r\n";
                }

                //小票底部  
                ticketStr += CreateLine(this.TicketWidth, this.signWeight);
                ticketStr += this.TicketFooter + "\r\n";

            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }

            return ticketStr;
        }
        #region "把字符串按指定最大长度分行，使得最后一行长度为指定的最低长度"  

        /// <summary>    
        /// 处理字符串自动换行问题。最短为intLenMin，最长为intLenMax，最后一行用空格补齐到intLenMin长度。http://blog.csdn.net/xiaoxian8023/article/details/7276220    
        /// </summary>    
        /// <param name="strOldText">原字符串</param>    
        /// <param name="intLenMin">最短字节长度</param>    
        /// <param name="intLenMax">最长字节长度</param>    
        /// <returns>string</returns>    
        /// <remarks></remarks>    
        public string AutomaticLine(string strOldText, int intLenMin, int intLenMax)
        {

            int intLength = 0;
            string strResult = "";

            //获取原字符串的字节长度    
            intLength = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(strOldText);

            if (intLength > intLenMax)
            {
                //总字节数> 最长截取的最长字节数，    
                //则截取最长字节数, 然后对剩余字符串再处理    

                //获取字符串的UCS2码    
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(strOldText);
                //获取字符的实际截取位置    
                int intCutPos = RealCutPos(bytes, intLenMax);
                //采用递归调用    
                strResult = System.Text.Encoding.Unicode.GetString(bytes, 0, intCutPos * 2) + "\r\n" + AutomaticLine(Strings.Mid(strOldText, intCutPos + 1), intLenMin, intLenMax);

            }
            else if (intLength > intLenMin)
            {
                //如果 最长字节数 >总字节数 > 最短字节数，则 换行，并补齐空格到最短字节数位置    
                strResult = strOldText + "\r\n" + Strings.Space(intLenMin);

            }
            else
            {
                //如果 总字节数 < 最短字节数，则直接补齐空格到最短字节数的位置    
                strResult = strOldText + Strings.Space(intLenMin - intLength);
            }
            return strResult;
        }

        /// <summary>    
        /// 返回字符的实际截取位置    
        /// </summary>    
        /// <param name="bytes">UCS2码</param>    
        /// <param name="intLength">要截取的字节长度</param>    
        /// <returns></returns>    
        /// <remarks></remarks>    
        public int RealCutPos(byte[] bytes, int intLength)
        {
            //获取UCS2编码    
            int intCountB = 0;
            // 统计当前的字节数     
            int intCutPos = 0;
            //记录要截取字节的位置      

            while ((intCutPos < bytes.GetLength(0) && intCountB < intLength))
            {
                // 偶数位置，如0、2、4等，为UCS2编码中两个字节的第一个字节    
                if (intCutPos % 2 == 0)
                {
                    // 在UCS2第一个字节时，字节数加1    
                    intCountB += 1;
                }
                else
                {
                    // 当UCS2编码的第二个字节大于0时，该UCS2字符为汉字，一个汉字算两个字节    
                    if (bytes[intCutPos] > 0)
                    {
                        intCountB += 1;
                    }
                }
                intCutPos += 1;
            }

            // 如果intCutPos为奇数时，处理成偶数      
            if (intCutPos % 2 == 1)
            {
                // 该UCS2字符是汉字时，去掉这个截一半的汉字    
                if (bytes[intCutPos] > 0)
                {
                    intCutPos = intCutPos - 1;
                }
                else
                {
                    // 该UCS2字符是字母或数字，则保留该字符    
                    intCutPos = intCutPos + 1;
                }
            }

            return intCutPos / 2;
        }

        #endregion
        /// <summary>  
        /// 商品列表设置  
        /// </summary>  
        /// <param name="ticket">TicketSet对象</param>  
        /// <returns>带格式的商品列表</returns>  
        private String ItemsList()
        {
            String result = string.Empty;
            try
            {
                if (this.dtGoodsList != null && this.dtGoodsList.Count > 0 )
                {
                    result = CreateLine(this.TicketWidth, this.SignWeight);

                    //foreach (DataColumn col in dtGoodsList.Columns)  
                    //{  
                    //    result += ArrangeArgPosition(col.Caption, this.TicketWidth, this.Colper1);  
                    //}
                    //result += ArrangeArgPosition("", this.TicketWidth, this.Colper);
                    result += ArrangeArgPosition("折扣", this.TicketWidth, this.Colper1);
                    result += ArrangeArgPosition("数量", this.TicketWidth, this.Colper2);
                    result += ArrangeArgPosition("售价", this.TicketWidth, this.Colper3);
                    result += ArrangeArgPosition("合计", this.TicketWidth, this.Colper4);

                    result += "\r\n";
                    result += CreateLine(this.ticketWidth, this.SignLight);

                    for (int i = 0; i < this.dtGoodsList.Count; i++)
                    {
                        //result += SetArgPosition(this.dtGoodsList.Rows[i][0].ToString(), this.TicketWidth, false);  

                        //string temp = ArrangeArgPosition(this.dtGoodsList.Rows[i][0].ToString(), this.TicketWidth, this.Colper1);  
                        int charNum = Convert.ToInt32(ticketWidth * Colper1);
                        string temp2 = AutomaticLine(dtGoodsList[i].H_name, charNum, TicketWidth);//8, 36  
                        result += temp2;
                        result += ArrangeArgPosition(string.Format("{0:0.00%}",this.dtGoodsList[i].H_output_discount_ls), this.TicketWidth, this.Colper2);
                        result += ArrangeArgPosition(string.Format("{0:n0}", this.dtGoodsList[i].H_amount), this.TicketWidth, this.Colper3);
                        result += ArrangeArgPosition(string.Format("{0:c2}", this.dtGoodsList[i].H_output_price), this.TicketWidth, this.Colper4);
                        result += ArrangeArgPosition(string.Format("{3:c2}", this.dtGoodsList[i].H_amount * dtGoodsList[i].H_output_price* dtGoodsList[i].H_output_discount_ls), this.TicketWidth, this.Colper4);

                        result += "\r\n";
                    }
                    result += CreateLine(this.ticketWidth, this.SignLight);
                }
            }
            catch (Exception ex)
            {
                LogTextHelper.Info(ex.Message);

            }

            return result;
        }

    }
}
