using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;

namespace YC.Client.Execute.UnityInjection.ViewDialog
{
    /// <summary>
    /// 基层Dlg模型
    /// </summary>
    /// <typeparam name="T">视图</typeparam>
    public class BaseView<View, ViewModel, Model> : IModel where View : UserControl, new()
        where ViewModel : BaseOperation<Model>, new()
        where Model : class, new()
    {
        /// <summary>
        /// 泛型视图
        /// </summary>
        public View TView;

        /// <summary>
        /// 泛型ViewModel
        /// </summary>
        public ViewModel SViewModel;

        /// <summary>
        /// 绑定上下文(默认)
        /// </summary>
        /// <typeparam name="TViewModel"></typeparam>
        /// <param name="viewModel"></param>
        public void BindViewModel<TViewModel>(TViewModel viewModel)
        {
            this.GetView().DataContext = viewModel;
        }

        /// <summary>
        /// 绑定默认视图
        /// </summary>
        public void BindDefaultModel(int? authValue)
        {
            if (SViewModel == null) SViewModel = new ViewModel();
            SViewModel.InitViewModel();
            this.GetView().DataContext = SViewModel;
        }

        /// <summary>
        /// 获取视图页
        /// </summary>
        /// <returns></returns>
        public UserControl GetView()
        {
            if (TView == null) TView = new View();
            return TView as UserControl;
        }
    } 
}
