using System;
using System.Reflection;
using YC.Client.DAL;

namespace YC.Client.Data
{

    /// <summary>
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
    /// </summary>
    public sealed partial class DataAccess
    {
        private static readonly string AssemblyPath = "YC.Client.Data";

        #region Createus
        /// <summary>
        /// 桥接数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IUsDataDal<T> CreateusData<T>() where T : class, new()
        {
            try
            {
                //通过反射获取到DAL类
                var classNamespace = Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath + ".Gngl.Us_gnglDal");
                return classNamespace as IUsDataDal<T>;

                //方式2 			
                //string classNamespace = AssemblyPath + ".us_gngl";
                //object objType = CreateObject(AssemblyPath, classNamespace);
                //return (Ius_gnglDal)objType;

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        #endregion

        #region CreateObject 

        //不使用缓存
        private static object CreateObjectNoCache(string classNamespace)
        {
            try
            {
                object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
                return objType;
            }
            catch //(System.Exception ex)
            {
                //string str=ex.Message;// 记录错误日志
                return null;
            }

        }

        //使用缓存
        private static object CreateObject(string AssemblyPath, string classNamespace)
        {
            //object objType = DataCache.GetCache(classNamespace);
            //if (objType == null)
            //{
            //    try
            //    {
            //        objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);
            //        DataCache.SetCache(classNamespace, objType);// 写入缓存
            //    }
            //    catch//(System.Exception ex)
            //    {
            //        //string str=ex.Message;// 记录错误日志
            //    }
            //}
            //return objType;
            return null;
        }

        #endregion

     
    }
}
