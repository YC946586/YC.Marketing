using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Execute.UnityInjection
{

    /// <summary>
    /// Unity容器接口
    /// </summary>
    public interface IUnityLocator
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="Template"></typeparam>
        void Register<TInterface, Template>() where Template : TInterface;

        /// <summary>
        /// 获取接口
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <returns></returns>
        TInterface Get<TInterface>(string typeName);

        /// <summary>
        /// 自动注册
        /// </summary>
        void Register();
    }
}
