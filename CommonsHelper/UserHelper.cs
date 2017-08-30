using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHC.Framework.Commons;
using POSS.Entity;
using POSS.BLL;
using WHC.Framework.ControlUtil;
using System.Data;

namespace CommonsHelper
{
   public class UserHelper
    {
        #region 下拉显示
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public static List<Query_OperatorsInfo> GetO_id()
        {
            Query_OperatorsInfo data = new Query_OperatorsInfo();
            data.O_id = "0";
            data.O_name = "请选择...";
            List<Query_OperatorsInfo> ne = new List<Query_OperatorsInfo>();
            ne = BLLFactory<Users>.Instance.GetO_id();
            ne.Insert(0, data);
            return ne;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <returns></returns>
        public static List<Query_Station_totalInfo> Get_Station_id()
        {
            Query_Station_totalInfo data = new Query_Station_totalInfo();
            data.Station_id = "0";
            data.Station_name = "请选择...";
            List<Query_Station_totalInfo> ne = new List<Query_Station_totalInfo>();
            ne = BLLFactory<Users>.Instance.GetSatation_idByName();
            ne.Insert(0, data);
            return ne;
        }
        /// <summary>
        /// 获取库房信息
        /// </summary>
        /// <returns></returns>
        public static List<Query_stocksInfo> Get_Stock()
        {
            Query_stocksInfo data = new Query_stocksInfo();
            data.S_id = "AUTO";
            data.S_name = "自动";
            List<Query_stocksInfo> ne = new List<Query_stocksInfo>();
            ne = BLLFactory<Users>.Instance.GetStocks_idByName();
            ne.Insert(0, data);
            return ne;

        }
        public static List<Query_StandInfo> Get_Stand()
        {
            Query_StandInfo data = new Query_StandInfo();
            data.Stand_id = "0";
            data.Stand_name = "请选择...";
            List<Query_StandInfo> ne = new List<Query_StandInfo>();
            ne = BLLFactory<Users>.Instance.GetStand_idByName();
            ne.Insert(0, data);
            return ne;
        } 
        #endregion

        #region 返回是或否
        /// <summary>
        /// 返回是或否
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_y_n()
        {
            DataTable dt = DataTableHelper.CreateTable("显示值|string,项目值|string");
            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "是";

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "0";
            dr[1] = "否";
            dt.Rows.Add(dr);

            return dt;
        } 
        #endregion

        #region 保存用户信息
        /// <summary>
        /// 保存用户信息
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public static bool SaveUsers(UsersInfo us)
        {
            bool temp = false;
            if (us != null)
            {
                temp = BLLFactory<Users>.Instance.SaveUser(us);
            }

            return temp;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public static List<UsersInfo> Get_UsersInfo()
        {
            UsersInfo data = new UsersInfo();
            data.O_id = "0";
            data.O_name = "请选择...";
            List<UsersInfo> ne = new List<UsersInfo>();
            ne = BLLFactory<Users>.Instance.GetUsers_idByName();
            ne.Insert(0, data);
            return ne;
        } 
        #endregion

        #region 验证用户密码
        /// <summary>
        ///  验证用户密码（不区分大小写）
        /// </summary>
        /// <param name="usinfo"></param>
        /// <returns></returns>
        public static string Validation_Users(string o_id, string o_passwd)
        {
            string result = string.Empty;
            if (o_id != null || o_passwd != null)
            {
                string oo_id = string.Empty;
                oo_id = o_id;
                List<UsersInfo> infolist = BLLFactory<Users>.Instance.Validation_Users(oo_id);
                if (infolist.Count == 1)
                {
                    string k_passwd = o_passwd.ToLower().ToString();
                    string passwd = string.Empty;
                    foreach (UsersInfo item in infolist)
                    {
                        passwd = item.Passwd.ToLower().ToString();
                    }
                    if (passwd == k_passwd)
                    {
                        result = "成功";
                    }
                    else
                    {
                        result = "失败";
                    }

                }
                else
                {
                    result = "用户编码重复！";
                }
            }
            else
            {
                result = "密码或用户编号不能为空！";
            }


            return result;
        } 
        #endregion


    }
}
