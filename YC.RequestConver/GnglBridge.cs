﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.BLL;
using YC.Client.Entity;

namespace YC.RequestConver
{
    public class GnglBridge
    {
        public static void GetModel(us_gnglModel obju)
        {
            UsGnglBll<us_gnglModel> bll=new UsGnglBll<us_gnglModel>();
             var cc = bll.GetModel("00127A9653CF4B0B5447933DCKhxx001");
        }
    }
}