using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WHC.Framework;
using WHC.Framework.Commons;
using WHC.Framework.ControlUtil.Facade;
using WHC.Security;
using WHC.Security.Entity;
using Erp.Base.Facade;
using DevExpress.XtraEditors.Repository;
using WHC.Security.Facade;
using WHC.Dictionary.Facade;
namespace Erp.Base
{
    public class BaseUtil
    {
        private static Station_totalInfo currentStation = null;

        /// <summary>
        /// 当前站点
        /// </summary>
        public static Station_totalInfo CurrentStation
        {
            get 
            { 
                return BaseUtil.currentStation; 
            }
            set 
            { 
                BaseUtil.currentStation = value; 
            }
        }
        private static SimpleOperator currentOperator = null;

        /// <summary>
        /// 当前操作员
        /// </summary>
        public static SimpleOperator CurrentOperator
        {
            get { return BaseUtil.currentOperator; }
            set { BaseUtil.currentOperator = value; }
        }
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
        #region 编辑类
        /// <summary>
        /// 出版社信息 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable PublishByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["PublishByEditor"] == null)
            {
                dt = CallerFactory<IPublishsService>.Instance.SqlTable("SELECT pub_id[项目值],pub_name[显示值] FROM  dbo.db_publishs");
                dt.TableName = "PublishByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["PublishByEditor"].Copy();
            }
            return dt;
        }

        /// <summary>
        /// 商品分类 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable H_TypeByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["H_TypeByEditor"] == null)
            {
                dt = CallerFactory<IDz_typeService>.Instance.SqlTable("SELECT h_type[项目值],type_name[显示值],type_id [上级分类] FROM  dbo.dz_type");
                dt.TableName = "H_TypeByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["H_TypeByEditor"].Copy();
            }
            return dt;
        }
        /// <summary>
        /// 货源选择 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable F_idByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["F_idByEditor"] == null)
            {
                dt = CallerFactory<IFactoryService>.Instance.SqlTable("SELECT f_id[项目值],f_department[显示值],f_help_Input [谐音] FROM dbo.db_factory");
                dt.TableName = "F_idByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["F_idByEditor"].Copy();
            }
            return dt;
        }


        /// <summary>
        /// 商品选择 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable H_idByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["H_idByEditor"] == null)
            {
                dt = CallerFactory<IProductService>.Instance.SqlTable("SELECT h_id[项目值],h_name[显示值] FROM dbo.db_product");
                dt.TableName = "H_idByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["H_idByEditor"].Copy();
            }
            return dt;
        }

        /// <summary>
        /// 客户选择 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable C_idByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["C_idByEditor"] == null)
            {
                dt = CallerFactory<IProductService>.Instance.SqlTable("SELECT c_id[项目值],c_department[显示值] FROM dbo.db_clients");
                dt.TableName = "C_idByEditor";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["C_idByEditor"].Copy();
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
                dt = CallerFactory<IStation_totalService>.Instance.GetTreeListStation();
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
        /// 会员类别 2列 项目值 显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable GetOperatorOrSaleManByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["O_id"] == null)
            {
                dt = CallerFactory<IOperatorsService>.Instance.SqlTable("SELECT o_id[项目值],o_name[显示值] FROM dbo.db_operators");
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
        /// 返回评价等级
        /// </summary>
        /// <returns></returns>
        public static DataTable FeedBackLevelByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["FeedBackLevel"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "非常好";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "好";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "2";
                dr[1] = "一般";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "3";
                dr[1] = "差";
                dt.Rows.Add(dr);

                dt.TableName = "FeedBackLevel";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["FeedBackLevel"].Copy();
            }

            return dt;
        }

        public static DataTable PriceLevelByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["PriceLevel"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "偏高";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "适中";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "2";
                dr[1] = "偏低";
                dt.Rows.Add(dr);

 
                dt.TableName = "PriceLevel";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["PriceLevel"].Copy();
            }

            return dt;
        }

        /// <summary>
        /// 返回软件系列的信息
        /// </summary>
        /// <returns></returns>
        public static DataTable Is_networkByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["IsNetwork"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "*";
                dr[1] = "*";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "连锁版";
                dt.Rows.Add(dr);

                dt.TableName = "IsNetwork";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["IsNetwork"].Copy();
            }

            return dt;
        }

        /// <summary>
        /// 返回计算模式的信息
        /// </summary>
        /// <returns></returns>
        public static DataTable Compute_methodByEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["ComputeMethod"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "集中式";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "分点计算";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "2";
                dr[1] = "分布式计算";
                dt.Rows.Add(dr);


                dt.TableName = "ComputeMethod";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["ComputeMethod"].Copy();
            }

            return dt;
        }

 
        #endregion




        #region Grid控件显示
        /// <summary>
        /// 返回出版社信息,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox PublishByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = PublishByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }

        /// <summary>
        /// 返回手机类型,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox MoblieTypeByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = MoblieTypeByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }

        /// <summary>
        /// 返回商品分类信息,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox H_TypeByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = H_TypeByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }
        /// <summary>
        /// 返回内报单 报出类别
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox NbCollectByFrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = NbCollectbyEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }

        /// <summary>
        /// 返回报订单类别的DataTable,返回的DataTable含2列:项目值,显示值
        /// </summary>
        /// <returns></returns>
        public static DataTable NbCollectbyEditor()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["NbCollect"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;

                dr = dt.NewRow();
                dr[0] = "1";
                dr[1] = "已报出";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "可报出";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "3";
                dr[1] = "暂缓报出";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr[0] = "4";
                dr[1] = "未审核";
                dt.Rows.Add(dr);

                dt.TableName = "NbCollect";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["NbCollect"].Copy();
            }

            return dt;
        }
        /// <summary>
        /// 返回货源信息,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox F_idByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = F_idByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }
        public static RepositoryItemSearchLookUpEdit F_idSerchLookUpEditByGrid()
        {
            DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit item = null;
            item = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            item.RepositoryItems.Clear();
            DataTable dt = F_idByEditor();
            item.ValueMember = "项目值";
            item.DisplayMember = "显示值";
            item.DataSource = dt;

            return item;
        }
        /// <summary>
        /// 返回客户信息,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox C_idByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = C_idByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }
        /// <summary>
        /// 返回商品信息,用于Grid控件显示
        /// </summary>
        /// <returns></returns>
        public static RepositoryItemImageComboBox H_idByGrid()
        {
            RepositoryItemImageComboBox cbx_result = new RepositoryItemImageComboBox();
            DevExpress.XtraEditors.Controls.ImageComboBoxItem item = null;
            cbx_result.Items.Clear();
            DataTable dt = H_idByEditor();
            foreach (DataRow r in dt.Rows)
            {
                item = new DevExpress.XtraEditors.Controls.ImageComboBoxItem();
                item.Value = r[0].ToString();
                item.Description = r[1].ToString();
                cbx_result.Items.Add(item);
            }
            return cbx_result;
        }

        #endregion
        public static void Init(LoginOwnerInfo ownerInfo, LoginStationInfo statinInfo, LoginUserInfo userInfo)
        {
            Portal.gc.LoginStationInfo = statinInfo;
            Portal.gc.LoginUserInfo = userInfo;
            Portal.gc.LoginOwnerInfo = ownerInfo;
        }

        public static DataTable receipts_class()
        {
            DataTable dt = null;
            if (GetDictItem().Tables["receipts_class"] == null)
            {
                dt = DataTableHelper.CreateTable("项目值|string,显示值|string");
                DataRow dr;
                dr = dt.NewRow();
                dr[0] = "KB";
                dr[1] = "客户报定";
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr[0] = "NB";
                dr[1] = "店面报定";
                dt.Rows.Add(dr);

                dt.TableName = "receipts_class";
                GetDictItem().Tables.Add(dt.Copy());
            }
            else
            {
                dt = GetDictItem().Tables["receipts_class"].Copy();
            }

            return dt;
        }



    }
}
