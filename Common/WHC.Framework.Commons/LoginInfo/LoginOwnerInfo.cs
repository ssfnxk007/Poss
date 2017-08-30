using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 本单位基本信息
    /// </summary>
    public class LoginOwnerInfo
    {
        private string m_department;
        private string m_address;
        private string m_tel;
        private string m_compute_method;
        private string m_fax;
        private string m_zip;
        private string m_bank;
        private string m_tax;
        private string m_account;
        private string m_ow_mail;
        private string m_tax_account;
        private string m_database_id;
        private string m_tax_address;
        private bool m_is_posserver;
        private string m_tax_bank;

        /// <summary>
        /// 单位名称
        /// </summary>
        public string Department
        {
            get { return m_department; }
            set { m_department = value; }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel
        {
            get { return m_tel; }
            set { m_tel = value; }
        }

        /// <summary>
        /// 计算模式
        /// </summary>
        public string Compute_method
        {
            get { return m_compute_method; }
            set { m_compute_method = value; }
        }

        /// <summary>
        /// 传真
        /// </summary>
        public string Fax
        {
            get { return m_fax; }
            set { m_fax = value; }
        }

        /// <summary>
        /// 邮编
        /// </summary>
        public string Zip
        {
            get { return m_zip; }
            set { m_zip = value; }
        }

        /// <summary>
        /// 开户银行
        /// </summary>
        public string Bank
        {
            get { return m_bank; }
            set { m_bank = value; }
        }

        /// <summary>
        /// 税号
        /// </summary>
        public string Tax
        {
            get { return m_tax; }
            set { m_tax = value; }
        }

        /// <summary>
        /// 帐号
        /// </summary>
        public string Account
        {
            get { return m_account; }
            set { m_account = value; }
        }

        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Ow_mail
        {
            get { return m_ow_mail; }
            set { m_ow_mail = value; }
        }

        /// <summary>
        /// 增值税发票帐号
        /// </summary>
        public string Tax_account
        {
            get { return m_tax_account; }
            set { m_tax_account = value; }
        }

        /// <summary>
        /// 数据库码
        /// </summary>
        public string Database_id
        {
            get { return m_database_id; }
            set { m_database_id = value; }
        }

        /// <summary>
        /// 增值发票地址
        /// </summary>
        public string Tax_address
        {
            get { return m_tax_address; }
            set { m_tax_address = value; }
        }

        /// <summary>
        /// POS服务
        /// </summary>
        public bool Is_posserver
        {
            get { return m_is_posserver; }
            set { m_is_posserver = value; }
        }

        /// <summary>
        /// 增值税发票开户行
        /// </summary>
        public string Tax_bank
        {
            get { return m_tax_bank; }
            set { m_tax_bank = value; }
        }



    }
}
