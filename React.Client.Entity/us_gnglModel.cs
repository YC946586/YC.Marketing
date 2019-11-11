using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Entity
{
    //us_gngl
    public class us_gnglModel
    {

        /// <summary>
        /// 主键
        /// </summary>		
        private string _zj;
        public string ZJ
        {
            get { return _zj; }
            set { _zj = value; }
        }
        /// <summary>
        /// 节点名称，目前仅对分组节点和树节点生效
        /// </summary>		
        private string _jdmc;
        public string JDMC
        {
            get { return _jdmc; }
            set { _jdmc = value; }
        }
        /// <summary>
        /// 父节点主键
        /// </summary>		
        private string _f_fjdzj;
        public string F_FJDZJ
        {
            get { return _f_fjdzj; }
            set { _f_fjdzj = value; }
        }
        /// <summary>
        /// 等级（树节点的层级）
        /// </summary>		
        private decimal _dj;
        public decimal DJ
        {
            get { return _dj; }
            set { _dj = value; }
        }
        /// <summary>
        /// 节点排序
        /// </summary>		
        private decimal _jdpx;
        public decimal JDPX
        {
            get { return _jdpx; }
            set { _jdpx = value; }
        }
        /// <summary>
        /// （未使用）功能标志（0：正常；1：公共；2：公共，但在登录之后才能使用）
        /// </summary>		
        private decimal _gnbz;
        public decimal GNBZ
        {
            get { return _gnbz; }
            set { _gnbz = value; }
        }
        /// <summary>
        /// 节点类型：1表示这是一个工具栏按钮（首页上方）；3表示这是一个分组（例如首页左边）；
        /// </summary>		
        private string _jdlx;
        public string JDLX
        {
            get { return _jdlx; }
            set { _jdlx = value; }
        }
        /// <summary>
        /// 属性（多属性，类似于Style描述）Open 打开方式: 1表示这是一个打开用户控件（填写DLL名称和UserControl名称）;5表达打开一个网页（data里填写URL）;6表示打开一个exe 
        /// </summary>		
        private string _jdsx;
        public string JDSX
        {
            get { return _jdsx; }
            set { _jdsx = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _remark;
        public string REMARK
        {
            get { return _remark; }
            set { _remark = value; }
        }
        /// <summary>
        /// 启用标志（0：未启用，1：启用,当前只能有一条数据是启用状态，默认只有最新版本能用）
        /// </summary>		
        private decimal _qybz;
        public decimal QYBZ
        {
            get { return _qybz; }
            set { _qybz = value; }
        }
        /// <summary>
        /// 更新人的登录id
        /// </summary>		
        private string _gxr;
        public string GXR
        {
            get { return _gxr; }
            set { _gxr = value; }
        }
        /// <summary>
        /// 创建人的登录id
        /// </summary>		
        private string _cjr;
        public string CJR
        {
            get { return _cjr; }
            set { _cjr = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>		
        private DateTime _gxsj;
        public DateTime GXSJ
        {
            get { return _gxsj; }
            set { _gxsj = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private DateTime _cjsj;
        public DateTime CJSJ
        {
            get { return _cjsj; }
            set { _cjsj = value; }
        }
        /// <summary>
        /// 3青橘，5总分 13:青橘PLUS 14:汇算清缴会员
        /// </summary>		
        private int _viptype;
        public int VIPTYPE
        {
            get { return _viptype; }
            set { _viptype = value; }
        }

    }
}

