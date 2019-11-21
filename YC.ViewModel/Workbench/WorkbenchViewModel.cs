using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;
using YC.Client.Execute.Commons;
using YC.Client.Execute.UnityInjection.ViewDialog.CoreLib;
using YC.Model.IndexModel;
using YC.Model.Workbench;
using YC.RequestConver;

namespace YC.ViewModel.Workbench
{
    public class WorkbenchViewModel : BaseOperation<WorkbenchModel>
    {

        /// <summary>
        /// 待办事项
        /// </summary>
        private readonly Dictionary<string, string> _dicTodo = new Dictionary<string, string>
        {
            {"待服务", "预约单"},
            {"待付款", "服务订单"},
            {"待发货", "产品订单"},
            {"待审核", "推广员申请"}
        };


        /// <summary>
        /// 待办事项
        /// </summary>
        private readonly Dictionary<string, int> _dicKdData = new Dictionary<string, int>
        {
            {"成交客户数", 1350},
            {"新增会员数", 756},
            {"客单价", 15876},
            {"预约单数", 652}
        };

        /// <summary>
        /// 初始化工作台
        /// </summary>
        public override void InitViewModel()
        {
            try
            {
                base.InitViewModel();
                Task.Factory.StartNew(() =>
                {
                    WorkbenchModel model = new WorkbenchModel();




                    //工作台数据
                    var gztModel = Common.GetGnglEntityByFjd("0124c130f5e64e4b9c04eda4e31b0002");


                    #region 客户数据

                    foreach (var item in _dicKdData)
                    {
                        KhDataModel khData = new KhDataModel
                        {
                            Title = item.Key,
                            TodeCount = item.Value.ToString("N2"),
                            YestAmount =Common.GetRandomSeed().ToString(),
                        };
                        model.ListKhData.Add(khData);
                    }

                    #endregion

                    //常用功能
                    var cygnModel = Common.GetGnglEntityByFjd(gztModel.Find(s => s.JDPX == 2).ZJ);
                    if (cygnModel.Any())
                    {
                        cygnModel.ForEach((ary) =>
                        {
                            PageModule pageModel = new PageModule(ary.JDMC, ary.JDSX, ary.JDPX);
                            model.ListFun.Add(pageModel);
                        });
                    }

                    #region 最新宣传 最新功能 有赞神厨   

                    var broadcastModel = gztModel.Where(s => s.JDPX == 4).ToList();
                    if (broadcastModel.Any())
                    {
                        broadcastModel.ForEach((ary) =>
                        {
                            FuntionsModel broadc = new FuntionsModel()
                            {
                                FunName = ary.JDMC,
                            };
                            var dapiModel = Common.GetGnglEntityByFjd(ary.ZJ);

                            dapiModel.ForEach((aty) =>
                            {
                                depictModel dapi = new depictModel()
                                {
                                    Depict = aty.JDSX,
                                };
                                broadc.ListFuntions.Add(dapi);
                            });
                            model.Listbroadcast.Add(broadc);
                        });
                    }

                    #endregion

                    //待办事项
                    foreach (KeyValuePair<string, string> t in _dicTodo)
                    {
                        TodoModel model1 = new TodoModel()
                        {
                            Items = t.Key,
                            TodeCount = new Random().Next(10, 500),
                            Todedepict = t.Value
                        };
                        Thread.Sleep(100);
                        model.ListTodo.Add(model1);
                    }
                    Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        InitChar(model);

                        GridModelList.Add(model);
                    }));

                });

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        /// <summary>
        /// 加载统计图
        /// </summary>
        /// <param name="model"></param>
        private void InitChar(WorkbenchModel model)
        {
            try
            {
                model.SeriesCollection = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = "Has sold",
                        Values = new ChartValues<double> {50, 35, 30},
                        Stroke = new SolidColorBrush(Color.FromRgb(217, 220, 225)),
                        Fill = new SolidColorBrush(Color.FromRgb(217, 220, 225)),
                         MaxColumnWidth = 10,
                        StrokeDashArray =new DoubleCollection(2)
                    },

                };

                model.SeriesCollection.Add(new ColumnSeries
                {
                    Title = "Not sold",
                    Values = new ChartValues<double> {70, 30, 42},
                    Stroke = new SolidColorBrush(Color.FromRgb(254, 71, 117)),
                    Fill = new SolidColorBrush(Color.FromRgb(254, 71, 117)),
                    MaxColumnWidth = 10,
                    Margin =new Thickness(10,0,0,0)
                });
                model.CharName = new[]
                {
                    "产品销售",
                    "服务消费",
                    "开卡充值",

                };
                model.Formatter = value => value.ToString("N");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
