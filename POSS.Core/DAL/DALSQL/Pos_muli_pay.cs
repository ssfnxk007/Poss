using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;

using WHC.Pager.Entity;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using Microsoft.Practices.EnterpriseLibrary.Data;
using POSS.Entity;
using POSS.IDAL;

namespace POSS.DALSQL
{
    /// <summary>
    /// Pos_muli_pay
    /// </summary>
	public class Pos_muli_pay : BaseDALSQL<Pos_muli_payInfo>, IPos_muli_pay
	{
		#region 对象实例及构造函数

		public static Pos_muli_pay Instance
		{
			get
			{
				return new Pos_muli_pay();
			}
		}
		public Pos_muli_pay() : base("db_pos_muli_pay","pos_id")
		{
		}

		#endregion

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dr">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		protected override Pos_muli_payInfo DataReaderToEntity(IDataReader dataReader)
		{
			Pos_muli_payInfo info = new Pos_muli_payInfo();
			SmartDataReader reader = new SmartDataReader(dataReader);
			
			info.Pos_id = reader.GetString("pos_id");
			info.Pos_pay_id = reader.GetString("pos_pay_id");
			info.Pos_charge = reader.GetDecimal("pos_charge");
			info.Source_id = reader.GetString("source_id");
			
			return info;
		}

		/// <summary>
		/// 将实体对象的属性值转化为Hashtable对应的键值
		/// </summary>
		/// <param name="obj">有效的实体对象</param>
		/// <returns>包含键值映射的Hashtable</returns>
        protected override Hashtable GetHashByEntity(Pos_muli_payInfo obj)
		{
		    Pos_muli_payInfo info = obj as Pos_muli_payInfo;
			Hashtable hash = new Hashtable(); 
			
			hash.Add("pos_id", info.Pos_id);
 			hash.Add("pos_pay_id", info.Pos_pay_id);
 			hash.Add("pos_charge", info.Pos_charge);
 			hash.Add("source_id", info.Source_id);
 				
			return hash;
		}

        /// <summary>
        /// 获取字段中文别名（用于界面显示）的字典集合
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetColumnNameAlias()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            #region 添加别名解析
            //dict.Add("ID", "编号");
            dict.Add("Pos_id", "");
             dict.Add("Pos_pay_id", "");
             dict.Add("Pos_charge", "");
             dict.Add("Source_id", "");
             #endregion

            return dict;
        }

        /// <summary>
        /// 零售单保存
        /// </summary>
        /// <param name="lsinof"></param>
        /// <param name="itemlist"></param>
        /// <param name="paylist"></param>
        /// <returns></returns>
        public LsInfo Save(LsInfo lsinof, List<Ls_itemInfo> itemlist, List<QueryPaymethods> paylist)
        {
            LsInfo xx = new LsInfo();
             //Ls_itemInfo iteminfo = null;
             Pos_muli_payInfo payinfo = null;
            using (DbTransaction trans = CreateTransaction())
            {
                try
                {
                    if (string.IsNullOrEmpty(lsinof.Ls_id))
                    {
                        lsinof.Ls_id = GetCode(BillsClass.LS, true, lsinof.Station_id, trans);//获取零售单号
                    }
                    xx = lsinof;
                    BLLFactory<Ls>.Instance.Insert(lsinof, trans);//插入主机

                    foreach (Ls_itemInfo item in itemlist)
                    {
                        item.Ls_id = lsinof.Ls_id;
                        BLLFactory<Ls_item>.Instance.Insert(item, trans);//细表

                    }
                    foreach (QueryPaymethods item in paylist)
                    {
                        payinfo = new Pos_muli_payInfo();
                        payinfo.Pos_id = lsinof.Ls_id;
                        payinfo.Pos_charge = item.Pay_money;
                        payinfo.Pos_pay_id = item.Pay_id;
                        payinfo.Source_id = string.IsNullOrEmpty(item.Source_id)?item.Pay_id:item.Source_id;
                        Insert(payinfo, trans);
                    }

                    //效验零售单
                    SqlExecute(string.Format("EXEC dbo.Up_CHECK_LS_GROUP @as_ls_id = '{0}' ", lsinof.Ls_id), trans);
                    
                    trans.Commit();

                }
                catch (Exception ex)
                {
                    xx.Ls_id = "";
                    trans.Rollback();
                    LogTextHelper.Error(string.Format("在线零售保存失败！错误信息：{0}", ex.Message));
                    SqlErrText = string.Format("{0}{1},请联系管理员！【收款不成功！】", lsinof.Ls_id, ex.Message);
                }
            }
       
            return xx;
        }
        /// <summary>
        /// 零售出库
        /// </summary>
        /// <param name="ls_id"></param>
        /// <returns></returns>
        public bool Is_stockLs(LsInfo ls_id)
        {
            bool result = false;
            using (DbTransaction trans = CreateTransaction())
            {
                try
                {
                    SqlExecute(string.Format("update db_ls SET is_stock ='1' WHERE db_ls.ls_id ='{0}' and is_stock <> '1' ", ls_id.Ls_id), trans);
                    result = true;
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    result = false;
                    trans.Rollback();
                    LogTextHelper.Error(string.Format("在线零售保存检更新出库时！错误信息：{0}", ex.Message));
                    SqlErrText = string.Format("零售单号为:{0}中{1}", ls_id.Ls_id, ex.Message);
                }
            }
            return result;
        }
    }
}