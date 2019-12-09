# 欢迎使用 YC.Marketing

** YC.Marketing  提供

## 提供功能

* 提供数据统计
* 提供功能权限控制
* 提供数据导出、导入功能

## 采用技术

* C#
* WPF
* MVVM
* LiveCharts
* MaterialDesign

> 将会引入Win32Api  正在开发中


###  关于

* QQ：29579895

* blogs：<https://www.cnblogs.com/Yangrx/>
* 邮箱地址自动链接  29579895@qq.com

* 因为自己的爱好，和给同行带来帮助，在平时空闲的时候来逐步完成此项目
* 如果有意向一同开发 可以联系

* 赞助
  [![](http://chuantu.xyz/t6/703/1575893689x1033347913.png "YANGCONG")

#### Style
 >  YC.Client.UI.Resources >themes >OverallStyle.xaml
 > 资源引入    YC.ClientView >Acceptance > InitMain()

    <?c#
         System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(
                    "pack://application:,,,/YC.Client.UI.Resources;component/themes/OverallStyle.xaml",
                    UriKind.RelativeOrAbsolute)
            });
    ?>


#### Run
* 反射出主程序
```c#
 var clientAssbly = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");
            Activator.CreateInstance(clientAssbly.GetType("YC.ClientView.Acceptance"));
            if (Application.Current!=null)
            {
                Application.Current.Shutdown(0);
            }
```
* 登录账号随便输入
* 登录成功 通过对应Entity 查询出功能数据源 （加载Win32API 保存程序句柄 正在开发）
```c#
      LoginResultData.TheMainConfig = DataRequest<UcGnglEntity>.Addition(new UcGnglEntity());
```
* 进行功能对应操作
```c#
 MainGroups = new ObservableCollection<MainModel>();
            MainModel model = new MainModel
            {
                UserInfo = new LoginUserInfo()
                {
                    UserName = "洋葱",
                    UserIcon = "HaderIcon",
                }
            };
            var tabFun = LoginResultData.TheMainConfig.Where(s => s.GNLX == 1).OrderBy(s => s.JDPX).ToList();
            if (tabFun.Any())
            {
                tabFun.ForEach((ary) =>
                {
                    PageModule pageModel = new PageModule(ary.JDMC, ary.JDSX, ary.JDPX);
                    model.Modules.Add(pageModel);
                });
            }

            //初始化模块
            Open(model.Modules.First());
            MainGroups.Add(model);
            GC.Collect();
```

### 打开对应功能
* View 建立静态属性 给静态属性赋值 来改变界面  YC.ClientView>  MainEmbed.xaml
```c#
   <ContentControl  Grid.Row="1" FocusVisualStyle="{x:Null}" Margin="15" Content="{Binding Path=(commons:RefreshCommon.SelectMenuGroup)}" />
```
* ViewModel 通过对应的Model  打开窗体  YC.ViewModel> MainViewModel > open()
```c#
  RefreshCommon.IndexName = model.FunName;
                var polymorphismAssbly =
                    Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + "\\YC.ClientView.dll");
                if (string.IsNullOrEmpty(model.OpenSpace))
                {
                    RefreshCommon.SelectMenuGroup = Common.GetUserControl("YC.ClientView.DefaultViewPage");
                    return;
                }
            
                var log = polymorphismAssbly.CreateInstance(model.OpenSpace) is IModel;
                if (log)
                {
                    var dialog = polymorphismAssbly.CreateInstance(model.OpenSpace) as IModel;
                    dialog?.BindDefaultModel();
                    if (dialog != null) RefreshCommon.SelectMenuGroup = dialog.GetView();
                }
```


> 目前采用依赖注入 后续会改为反射

### 功能部分截图

![工作区](http://chuantu.xyz/t6/703/1575894654x1033347913.png "工作区")

### 感谢 以下项目不区分排行
lvcharts 地址：https://lvcharts.net/
ZFC 地址:https://www.cnblogs.com/zh7791/p/11456132.html
MaterialDesign 地址: https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit

### End
