using System.Windows.Controls;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog;
using YC.Model.Asset;
using YC.ViewModel.Asset;

namespace YC.ClientView.Asset
{
    /// <summary>
    /// AssetView.xaml 的交互逻辑
    /// </summary>
    public partial class AssetView : UserControl
    {
        public AssetView()
        {
            InitializeComponent();
        }
    }

    public class AssetViewDog : BaseView<AssetView, AssetViewModel, AssetModel>, IModel
    {

    }


}
