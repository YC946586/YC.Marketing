using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Execute.UnityInjection
{
    /// <summary>
    /// Unity实例
    /// </summary>
    class UnityServiceLocator : IUnityLocator
    {
        private UnityContainer container;

        public UnityServiceLocator()
        {
            container = new UnityContainer();
        }

        void IUnityLocator.Register<TInterface, Template>()
        {
            container.RegisterType<TInterface, Template>();
        }

        TInterface IUnityLocator.Get<TInterface>(string typeName)
        {
            return container.Resolve<TInterface>(typeName);
        }

        /// <summary>
        ///默认自动注册
        /// </summary>
        public void Register()
        {
            //自动注册

            var polymorphismAssbly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");

            container.RegisterTypes(
                AllClasses.FromAssemblies(polymorphismAssbly),
                WithMappings.FromAllInterfaces,
                WithName.TypeName, WithLifetime.PerResolve);



        }
    }
}
