using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Entity
{
    //uc_jsgngl
    public class UcJsgnglEntity
    {

        /// <summary>
        /// ZJ
        /// </summary>		
        private string _zj;
        public string ZJ
        {
            get { return _zj; }
            set { _zj = value; }
        }
        /// <summary>
        /// ZJ_JSGL
        /// </summary>		
        private string _zj_jsgl;
        public string ZJ_JSGL
        {
            get { return _zj_jsgl; }
            set { _zj_jsgl = value; }
        }
        /// <summary>
        /// ZJ_GNGL
        /// </summary>		
        private string _zj_gngl;
        public string ZJ_GNGL
        {
            get { return _zj_gngl; }
            set { _zj_gngl = value; }
        }
        /// <summary>
        /// GNMC
        /// </summary>		
        private string _gnmc;
        public string GNMC
        {
            get { return _gnmc; }
            set { _gnmc = value; }
        }
        /// <summary>
        /// BZ
        /// </summary>		
        private string _bz;
        public string BZ
        {
            get { return _bz; }
            set { _bz = value; }
        }
        /// <summary>
        /// QYBZ
        /// </summary>		
        private int _qybz;
        public int QYBZ
        {
            get { return _qybz; }
            set { _qybz = value; }
        }

    }
}
