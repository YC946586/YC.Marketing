using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace YC.Model.Adhibition
{
   public  class AdhibitionModel: ViewModelBase
    {
        private string _title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }
        private string _titleDepict;
        /// <summary>
        /// 标题描述
        /// </summary>
        public string TitleDepict
        {
            get { return _titleDepict; }
            set
            {
                _titleDepict = value;
                RaisePropertyChanged();
            }
        }

        private List<AdhibitionToolModel> _toolModesList=new List<AdhibitionToolModel>();

        public List<AdhibitionToolModel> ToolModesList
        {
            get { return _toolModesList; }
            set
            {
                _toolModesList = value;
                RaisePropertyChanged();
            }
        }
    }

    public  class AdhibitionToolModel : ViewModelBase
    {
        private string _funName;
        /// <summary>
        /// 节点名称
        /// </summary>
        public string FunName
        {
            get { return _funName; }
            set
            {
                _funName = value;
                RaisePropertyChanged();
            }
        }

        private string _depict;
        /// <summary>
        /// 节点描述
        /// </summary>
        public string Depict
        {
            get { return _depict; }
            set
            {
                _depict = value;
                RaisePropertyChanged();
            }
        }

        private int _brushsPatht;
        /// <summary>
        /// 节点颜色
        /// </summary>
        public int BrushsPath
        {
            get { return _brushsPatht; }
            set
            {
                _brushsPatht = value;
                RaisePropertyChanged();
            }
        }
    }
}
