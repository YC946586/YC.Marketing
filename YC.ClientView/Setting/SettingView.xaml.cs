using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using YC.Client.Execute.UnityInjection;
using YC.Client.Execute.UnityInjection.ViewDialog;
using YC.Model.Setting;
using YC.ViewModel.Adhibition;
using YC.ViewModel.Setting;

namespace YC.ClientView.Setting
{
    /// <summary>
    /// SettingView.xaml 的交互逻辑
    /// </summary>
    public partial class SettingView : UserControl
    {
        public SettingView()
        {
            InitializeComponent();



            ItemsControl.Loaded += ItemContainerGenerator_StatusChanged;
        }

        private void ItemContainerGenerator_StatusChanged(object sender, EventArgs e)
        {
            if (ItemsControl.ItemContainerGenerator.Status == System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
            {
                ItemsControl.ItemContainerGenerator.StatusChanged -= ItemContainerGenerator_StatusChanged;
                if (Dispatcher != null)
                    Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.DataBind, new Action(DelayedAction));
            }
        }

        void DelayedAction()
        {
            
            for (int i = 0; i < ItemsControl.Items.Count; i++)
            {
                var item = ItemsControl.ItemContainerGenerator.ContainerFromIndex(i) as System.Windows.Controls.ContentPresenter;
                if (item != null) _offsets.Add(item.ActualHeight);
            }
            //ItemsControl.ItemContainerGenerator.Items.Select(s => (s as ContentPresenter).ActualHeight).ToList();
            ////ItemsControl.ItemContainerGenerator.Items.Cast<ContentPresenter>()
            ////    .Select(s => s.ActualHeight)
            ////    .ToList();

        }

        private void ItemsControlOnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (sender is ItemsControl itemsControl)
                //{
                //    _offsets = itemsControl.Items
                //        .Cast<Border>()
                //        .Select(item => item.ActualHeight)
                //        .ToList()
                //        .AsReadOnly();
                //}
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private volatile bool _isBusy;

        private void ScrollViewer_OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var index = VerticalOffsetToIndex(e.VerticalOffset);

            _isBusy = true;
            ListBox.SetCurrentValue(Selector.SelectedIndexProperty, index);
            _isBusy = false;
        }

        private void ListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_isBusy) return;

            var index = ListBox.Items.IndexOf(e.AddedItems[0]);
            ScrollViewer.ScrollToVerticalOffset(IndexToVerticalOffset(index));
        }

        private List<double> _offsets=new List<double>();

        private double IndexToVerticalOffset(int index)
        {
            return _offsets?.Take(index).Sum() ?? 0D;
        }

        private int VerticalOffsetToIndex(double verticalOffset)
        {
            if (_offsets == null) return 0;

            var sum = 0D;
            for (var i = 0; i < _offsets.Count; i++)
            {
                var offset = _offsets[i];
                sum += offset;
                if (sum > verticalOffset) return i;
            }

            return 0;
        }
    }
    public class SettingViewDog : BaseView<SettingView, SettingViewModel, SettingModel>, IModel
    {

    }
}
