using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog;
using YC.Model.Adhibition;
using YC.ViewModel.Adhibition;

namespace YC.ClientView.Adhibition
{
    /// <summary>
    /// AdhibitionView.xaml 的交互逻辑
    /// </summary>
    public partial class AdhibitionView : UserControl
    {
        public AdhibitionView()
        {
            InitializeComponent();
        }
    }

    public class AdhibitionViewDog : BaseView<AdhibitionView, AdhibitionViewModel, AdhibitionModel>, IModel
    {

    }
}
