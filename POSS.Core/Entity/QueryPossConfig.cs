using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSS.Entity
{
   public class QueryPossConfig
    {
        private string m_id;//ID
        private string m_is_jifen;//是否积分
        private string m_is_ysdh;//一书多库位选择
        private string m_taosu;//显示行数
        private string m_wx_appid;//微信appid
        private string m_wx_mchid;//微信mchid
        private string m_wx_key;//微信kdy
        private string m_wx_appsecret;//微信appsecret
        private string m_wx_miaosu;//微信消费描述
        private string m_zfb_appid;//支付宝appid
        private string m_zfb_mchid;//支付宝mcid
        private string m_zfb_key;//支付宝key
        private string m_zfb_appsecret;//支付宝appsecret
        private string m_zfc_miaosu;//支付宝消费描述

        /// <summary>
        /// ID
        /// </summary>
        public string Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        /// <summary>
        /// 是否积分
        /// </summary>
        public string Is_jifen
        {
            get { return m_is_jifen; }
            set { m_is_jifen = value; }
        }

        /// <summary>
        /// 一书多库位选择
        /// </summary>
        public string Is_ysdh
        {
            get { return m_is_ysdh; }
            set { m_is_ysdh = value; }
        }

        /// <summary>
        /// 显示行数
        /// </summary>
        public string Taosu
        {
            get { return m_taosu; }
            set { m_taosu = value; }
        }

        /// <summary>
        /// 微信appid
        /// </summary>
        public string Wx_appid
        {
            get { return m_wx_appid; }
            set { m_wx_appid = value; }
        }

        /// <summary>
        /// 微信mchid
        /// </summary>
        public string Wx_mchid
        {
            get { return m_wx_mchid; }
            set { m_wx_mchid = value; }
        }

        /// <summary>
        /// 微信kdy
        /// </summary>
        public string Wx_key
        {
            get { return m_wx_key; }
            set { m_wx_key = value; }
        }

        /// <summary>
        /// 微信appsecret
        /// </summary>
        public string Wx_appsecret
        {
            get { return m_wx_appsecret; }
            set { m_wx_appsecret = value; }
        }

        /// <summary>
        /// 微信消费描述
        /// </summary>
        public string Wx_miaosu
        {
            get { return m_wx_miaosu; }
            set { m_wx_miaosu = value; }
        }

        /// <summary>
        /// 支付宝appid
        /// </summary>
        public string Zfb_appid
        {
            get { return m_zfb_appid; }
            set { m_zfb_appid = value; }
        }

        /// <summary>
        /// 支付宝mcid
        /// </summary>
        public string Zfb_mchid
        {
            get { return m_zfb_mchid; }
            set { m_zfb_mchid = value; }
        }

        /// <summary>
        /// 支付宝key
        /// </summary>
        public string Zfb_key
        {
            get { return m_zfb_key; }
            set { m_zfb_key = value; }
        }

        /// <summary>
        /// 支付宝appsecret
        /// </summary>
        public string Zfb_appsecret
        {
            get { return m_zfb_appsecret; }
            set { m_zfb_appsecret = value; }
        }

        /// <summary>
        /// 支付宝消费描述
        /// </summary>
        public string Zfc_miaosu
        {
            get { return m_zfc_miaosu; }
            set { m_zfc_miaosu = value; }
        }



    }
}
