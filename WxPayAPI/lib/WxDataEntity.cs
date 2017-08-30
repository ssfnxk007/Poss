using System;
using System.Collections.Generic;
using System.Web;

namespace WxPayAPI
{
    public class WxDataEntity
    {
        private string m_appid;//公众账号ID
        private string m_attach;//商家数据包
        private string m_bank_type;//付款银行
        private string m_cash_fee;//现金支付金额
        private string m_cash_fee_type;//现金支付货币类型
        private string m_fee_type;//货币种类
        private string m_is_subscribe;//是否关注公众账号
        private string m_mch_id;//商户号
        private string m_nonce_str;//随机字符串
        private string m_openid;//用户标识
        private string m_out_trade_no;//商户订单号
        private string m_result_code;//业务结果 SUCCESS/FAIL
        private string m_return_code;//返回状态码SUCCESS表示商户接收通知成功并校验成功
        private string m_return_msg;//返回信息
        private string m_sign;//签名
        private string m_time_end;//支付完成时间
        private int m_total_fee;//订单金额
        private string m_trade_type;//交易类型
        private string m_transaction_id;//微信支付订单号
        private string m_err_code;//错误代码
        private string m_err_code_des;//错误代码描述

        private bool m_result;//结果成功还是失败
        /// <summary>
        /// 结果成功还是失败
        /// </summary>
        public bool Result
        {
            get { return m_result; }
            set { m_result = value; }
        }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        public string Appid
        {
            get { return m_appid; }
            set { m_appid = value; }
        }

        /// <summary>
        /// 商家数据包
        /// </summary>
        public string Attach
        {
            get { return m_attach; }
            set { m_attach = value; }
        }

        /// <summary>
        /// 付款银行
        /// </summary>
        public string Bank_type
        {
            get { return m_bank_type; }
            set { m_bank_type = value; }
        }

        /// <summary>
        /// 现金支付金额
        /// </summary>
        public string Cash_fee
        {
            get { return m_cash_fee; }
            set { m_cash_fee = value; }
        }

        /// <summary>
        /// 现金支付货币类型
        /// </summary>
        public string Cash_fee_type
        {
            get { return m_cash_fee_type; }
            set { m_cash_fee_type = value; }
        }

        /// <summary>
        /// 货币种类
        /// </summary>
        public string Fee_type
        {
            get { return m_fee_type; }
            set { m_fee_type = value; }
        }

        /// <summary>
        /// 是否关注公众账号
        /// </summary>
        public string Is_subscribe
        {
            get { return m_is_subscribe; }
            set { m_is_subscribe = value; }
        }

        /// <summary>
        /// 商户号
        /// </summary>
        public string Mch_id
        {
            get { return m_mch_id; }
            set { m_mch_id = value; }
        }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string Nonce_str
        {
            get { return m_nonce_str; }
            set { m_nonce_str = value; }
        }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string Openid
        {
            get { return m_openid; }
            set { m_openid = value; }
        }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string Out_trade_no
        {
            get { return m_out_trade_no; }
            set { m_out_trade_no = value; }
        }

        /// <summary>
        /// 业务结果 SUCCESS/FAIL
        /// </summary>
        public string Result_code
        {
            get { return m_result_code; }
            set { m_result_code = value; }
        }

        /// <summary>
        /// 返回状态码SUCCESS表示商户接收通知成功并校验成功
        /// </summary>
        public string Return_code
        {
            get { return m_return_code; }
            set { m_return_code = value; }
        }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Return_msg
        {
            get { return m_return_msg; }
            set { m_return_msg = value; }
        }

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign
        {
            get { return m_sign; }
            set { m_sign = value; }
        }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        public string Time_end
        {
            get { return m_time_end; }
            set { m_time_end = value; }
        }

        /// <summary>
        /// 订单金额
        /// </summary>
        public int Total_fee
        {
            get { return m_total_fee; }
            set { m_total_fee = value; }
        }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string Trade_type
        {
            get { return m_trade_type; }
            set { m_trade_type = value; }
        }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        public string Transaction_id
        {
            get { return m_transaction_id; }
            set { m_transaction_id = value; }
        }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string Err_code
        {
            get { return m_err_code; }
            set { m_err_code = value; }
        }

        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string Err_code_des
        {
            get { return m_err_code_des; }
            set { m_err_code_des = value; }
        }




    }
}