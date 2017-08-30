using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil;
using POSS.BLL;
using POSS.Entity;

namespace POSS
{
    public class DictItemUtil
    {
        private static DataSet DictItem = null;

        /// <summary>
        /// 返回数据字典集
        /// </summary>
        /// <returns></returns>
        private static DataSet GetDictItem()
        {
            if (DictItem == null)
            {
                DictItem = new DataSet();
            }
            return DictItem;
        }

        /// <summary>
        /// 返回男女性别的DataTable,返回的DataTable含2列:项目值,显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable SexbyEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["sex"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "男";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "女";
                dt.Rows.Add(dr);
                dt.TableName = "sex";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["sex"].Copy();
            }

            return dt;
        }

        /// <summary>
        /// 站点信息选择
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllStationForDropDown()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["StationTreeList"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT station_id [站点编码],station_name [站点名称],station_parent [父站点] FROM dbo.db_station_total WHERE is_exists='1'");
                dt.TableName = "StationTreeList";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["StationTreeList"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 员工 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable GetOperatorOrSaleManByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["O_id"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT o_id[项目值],o_name[显示值] FROM dbo.db_operators");
                dt.TableName = "O_id";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["O_id"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 会员级别 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable M_typeByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["M_type"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT m_type[项目值],m_type_name[显示值] FROM dbo.db_member_type");
                dt.TableName = "M_type";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["M_type"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 会员类别 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable M_zyByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["M_zy"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT type_id[项目值],type_name[显示值] FROM dbo.dz_yg_typeother");
                dt.TableName = "M_zy";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["M_zy"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 会员类别 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable M_Join_typeByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables[" M_Join_type"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT jion_id[项目值],jion_name[显示值] FROM dbo.dz_yg_join_type");
                dt.TableName = " M_Join_type";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables[" M_Join_type"].Copy();
            }
            return dt;
        }

        /// <summary>
        /// 返回是和否的DataTable,返回的DataTable含2列:项目值,显示值（0：否；1：是）
        /// </summary>
        /// <returns></returns>
        public static DataTable YesOrNoByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["yesorno"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "是";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "否";
                dt.Rows.Add(dr);

                dt.TableName = "yesorno";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["yesorno"].Copy();
            }

            return dt;
        }

        /// <summary>
        /// 返回手机类型的DataTable,返回的DataTable含2列:项目值,显示值（0：否；1：是）
        /// </summary>
        /// <returns></returns>
        public static DataTable MoblieTypeByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["MoblieType"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "电信";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "联通";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "2";
                dr[1] = "神州行";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "3";
                dr[1] = "动感地带";
                dt.Rows.Add(dr);

                dt.TableName = "MoblieType";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["MoblieType"].Copy();
            }

            return dt;
        }


        /// <summary>
        /// 会员光顾周期 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable MemberPeriodByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["MemberPeriod"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT p_id[项目值],p_name[显示值] FROM dbo.dz_member_period");
                dt.TableName = "MemberPeriod";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["MemberPeriod"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 返回职务信息的DataTable,返回的DataTable含2列:项目值,显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable DutyByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["DutyByEditor"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("select zw_id[项目值],zw_name[显示值] from dz_duty");
                dt.TableName = "DutyByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["DutyByEditor"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 会员职业 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable MemberZyByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["MemberZy"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT zy_id[项目值],zy_name[显示值] FROM dbo.dz_zy");
                dt.TableName = "MemberZy";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["MemberZy"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 城市信息选择 3列  省份名称 城市编码 城市名称 
        /// </summary>
        /// <returns></returns>
        public static DataTable CitysByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["CitysByEditor"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT city_id [城市编码],cityname [城市名称],(SELECT p_name FROM dz_province WHERE p_id=dz_citys.p_id)[省份名称] FROM dz_citys");
                dt.TableName = "CitysByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["CitysByEditor"];
            }
            return dt;
        }
        /// <summary>
        /// 省份信息选择 3列 ，项目值，显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable ProvinceByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["ProvinceByEditor"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT p_id[项目值],p_name[显示值],(SELECT a_name FROM dz_arears WHERE a_id=dz_province.a_id)[地区名称] FROM dz_province");
                dt.TableName = "ProvinceByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["ProvinceByEditor"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 地区信息选择 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable ArearsByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["ArearsByEditor"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT a_id [项目值],a_name [显示值] FROM dbo.dz_arears");
                dt.TableName = "ArearsByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["ArearsByEditor"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 会员收入水平 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable M_IncomeByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables[" M_Income"] == null)
            {
                dt = BLLFactory<Member>.Instance.SqlTable("SELECT i_id[项目值],i_name[显示值] FROM dbo.dz_member_income");
                dt.TableName = " M_Income";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables[" M_Income"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 获取支付方式
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_paymods()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["dz_paymethods"] == null)
            {
                dt = BLLFactory<Dz_paymethods>.Instance.SqlTable(@"SELECT
	                        p_id[项目值]  ,
                            p_name[显示值] 
                        FROM dbo.dz_paymethods where  dz_paymethods.p_id <> '!!!!'  AND    
            ( dz_paymethods.p_id <> '****' ) AND  ( dz_paymethods.p_id <> '$$$$' )  and ( dz_paymethods.p_id <> '0002' ) and ( dz_paymethods.p_id <> '0003' ) and (dz_paymethods.p_id <> '0009')");
                dt.TableName = "dz_paymethods";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["dz_paymethods"].Copy();
            }

            return dt;
        }
    }
}
