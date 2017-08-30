using System;
using System.Collections.Generic;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// 全局统一的缓存类
    /// </summary>
    public class Cache
    {
        #region 变量声明
        private SortedDictionary<string, object> dic = new SortedDictionary<string, object>();
        private static volatile Cache instance = null;
        private static object lockHelper = new object();

        #endregion

        #region 构造方法
        private Cache()
        {
            
        }
        #endregion

        #region 添加，删除缓存
        /// <summary>
        /// 添加指定的键值元素
        /// </summary>
        /// <param name="key">元素的键</param>
        /// <param name="value">元素的值对象</param>
        public void Add(string key, object value)
        {
            dic.Add(key, value);
        }

        /// <summary>
        /// 移除指定的键
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            dic.Remove(key);
        }

        /// <summary>
        /// 移除所有键值
        /// </summary>
        public void RemoveAll()
        {
            dic.Clear();
        }

        #endregion

        #region 获取缓存
        /// <summary>
        /// 获取索引的对象
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public object this[string index]
        {
            get
            {
                if (dic.ContainsKey(index))
                    return dic[index];
                else
                    return null;
            }
            set { dic[index] = value; }
        }
        #endregion

        #region 单件实例化
        /// <summary>
        /// 单件实例
        /// </summary>
        public static Cache Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new Cache();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion

        #region 获取常用简单实体
        /// <summary>
        /// 获取当前登陆操作员的简单实体
        /// </summary>
        /// <returns></returns>
        public object GetSimpleLoginUser()
        {
            if (dic.ContainsKey("LoginUserInfo"))
            {
                return dic["LoginUserInfo"];
            }
            return null;
        }

        /// <summary>
        /// 获取当前员工权限列表
        /// </summary>
        /// <returns></returns>
        public object GetFunctionDict()
        {
            if (dic.ContainsKey("FunctionDict"))
            {
                return dic["FunctionDict"];
            }
            return null;
        }

        /// <summary>
        /// 获取登陆的站点简单实体
        /// </summary>
        /// <returns></returns>
        public object GetSimpleLoginStation()
        {
            if (dic.ContainsKey("LoginStationInfo"))
            {
                return dic["LoginStationInfo"];
            }
            return null;
        }

        /// <summary>
        /// 获取登陆的本单位基本信息
        /// </summary>
        /// <returns></returns>
        public object GetLoginOwner()
        {
            if (dic.ContainsKey("LoginOwnerInfo"))
            {
                return dic["LoginOwnerInfo"];
            }
            return null;
        }

        #endregion
    }
}