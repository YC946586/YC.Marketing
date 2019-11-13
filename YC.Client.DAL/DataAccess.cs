using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace YC.Client.Data
{

    /// <summary>
    /// 
    /// </summary>
    public static class DataAccess
    {
        //private static readonly string AssemblyPath = "YC.Client.Data";

        private static readonly Dictionary<string, string> DicAttribute = new Dictionary<string, string>();
        #region Createus
        /// <summary>
        /// 获取对应的数据访问层
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IUsDataDal<T> CreateusData<T>() where T : class, new()
        {
            try
            {
                string assemblyPath= string.Empty;
                //如果已经查找到对应的Dal类就不继续找了
                var fullName = typeof(T).FullName;
                if (fullName != null && DicAttribute.ContainsKey(fullName))
                {
                    assemblyPath = DicAttribute[fullName];
                }
                else
                {
                    var propertys = Assembly.GetExecutingAssembly().GetTypes();
                    foreach (var item in propertys)
                    {
                        object[] objAttrs = item.GetCustomAttributes(typeof(DataAttribute), true); //获取自定义特性
                        if (objAttrs.Length == 0)
                            continue;
                        DataAttribute curData = objAttrs.First() as DataAttribute;
                        if (curData != null && curData.Data.Equals(typeof(T).FullName))
                        {
                            assemblyPath = item.FullName;
                             DicAttribute.Add(fullName, item.FullName);
                        }

                    }
                } 
                //通过反射获取到DAL类 因为都是当前路径 就写死路径
                var classNamespace = Assembly.Load("YC.Client.Data").CreateInstance(assemblyPath);
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
                object objType = Assembly.Load("YC.Client.Data").CreateInstance(classNamespace);
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
