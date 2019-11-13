using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity;
using YC.Client.Entity.Gngl;

namespace YC.Client.Data.Gngl
{
    //uc_gngl
    [Data("YC.Client.Entity.Gngl.UcGnglEntity")]
    public partial class UcGnglDal : IUsDataDal<UcGnglEntity>
    {
        public  bool Exists(string ZJ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from uc_gngl");
            strSql.Append(" where ");
            strSql.Append(" ZJ = @ZJ  ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public  void Add(UcGnglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into uc_gngl(");
            strSql.Append("ZJ,F_FJDZJ,JDMC,JDSX,JDPX,GNLX,CJR,CJSJ,BZ,QYBZ");
            strSql.Append(") values (");
            strSql.Append("@ZJ,@F_FJDZJ,@JDMC,@JDSX,@JDPX,@GNLX,@CJR,@CJSJ,@BZ,@QYBZ");
            strSql.Append(") ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@F_FJDZJ", DbType.String) ,
                        new SQLiteParameter("@JDMC", DbType.String) ,
                        new SQLiteParameter("@JDSX", DbType.String) ,
                        new SQLiteParameter("@JDPX", DbType.Int32,8) ,
                        new SQLiteParameter("@GNLX", DbType.Int32,8) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8),
                        new SQLiteParameter("@VipType", DbType.String),


            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.F_FJDZJ;
            parameters[2].Value = model.JDMC;
            parameters[3].Value = model.JDSX;
            parameters[4].Value = model.JDPX;
            parameters[5].Value = model.GNLX;
            parameters[6].Value = model.CJR;
            parameters[7].Value = model.CJSJ;
            parameters[8].Value = model.BZ;
            parameters[9].Value = model.QYBZ;
            parameters[10].Value = model.VipType;
            DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public  bool Update(UcGnglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update uc_gngl set ");

            strSql.Append(" ZJ = @ZJ , ");
            strSql.Append(" F_FJDZJ = @F_FJDZJ , ");
            strSql.Append(" JDMC = @JDMC , ");
            strSql.Append(" JDSX = @JDSX , ");
            strSql.Append(" JDPX = @JDPX , ");
            strSql.Append(" GNLX = @GNLX , ");
            strSql.Append(" CJR = @CJR , ");
            strSql.Append(" CJSJ = @CJSJ , ");
            strSql.Append(" BZ = @BZ , ");
            strSql.Append(" QYBZ = @QYBZ  ");
            strSql.Append(" where ZJ=@ZJ  ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@F_FJDZJ", DbType.String) ,
                        new SQLiteParameter("@JDMC", DbType.String) ,
                        new SQLiteParameter("@JDSX", DbType.String) ,
                        new SQLiteParameter("@JDPX", DbType.Int32,8) ,
                        new SQLiteParameter("@GNLX", DbType.Int32,8) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8),
                         new SQLiteParameter("@VipType", DbType.String),

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.F_FJDZJ;
            parameters[2].Value = model.JDMC;
            parameters[3].Value = model.JDSX;
            parameters[4].Value = model.JDPX;
            parameters[5].Value = model.GNLX;
            parameters[6].Value = model.CJR;
            parameters[7].Value = model.CJSJ;
            parameters[8].Value = model.BZ;
            parameters[9].Value = model.QYBZ;
            parameters[10].Value = model.VipType;
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public  bool Delete(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from uc_gngl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public  UcGnglEntity GetModel(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZJ, F_FJDZJ, JDMC, JDSX, JDPX, GNLX, CJR, CJSJ, BZ, QYBZ  ");
            strSql.Append("  from uc_gngl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            UcGnglEntity model = new UcGnglEntity();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ZJ = ds.Tables[0].Rows[0]["ZJ"].ToString();
                model.F_FJDZJ = ds.Tables[0].Rows[0]["F_FJDZJ"].ToString();
                model.JDMC = ds.Tables[0].Rows[0]["JDMC"].ToString();
                model.JDSX = ds.Tables[0].Rows[0]["JDSX"].ToString();
                if (ds.Tables[0].Rows[0]["JDPX"].ToString() != "")
                {
                    model.JDPX = int.Parse(ds.Tables[0].Rows[0]["JDPX"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GNLX"].ToString() != "")
                {
                    model.GNLX = int.Parse(ds.Tables[0].Rows[0]["GNLX"].ToString());
                }
                model.CJR = ds.Tables[0].Rows[0]["CJR"].ToString();
                model.CJSJ = ds.Tables[0].Rows[0]["CJSJ"].ToString();
                model.BZ = ds.Tables[0].Rows[0]["BZ"].ToString();
                if (ds.Tables[0].Rows[0]["QYBZ"].ToString() != "")
                {
                    model.QYBZ = int.Parse(ds.Tables[0].Rows[0]["QYBZ"].ToString());
                }
                model.VipType = ds.Tables[0].Rows[0]["VipType"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public  DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM uc_gngl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public  DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM uc_gngl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQLite.Query(strSql.ToString());
        }
        /// <summary>
        /// 查询当前角色所属功能
        /// </summary>
        /// <param name="model">功能zj </param>
        /// <returns></returns>
        public DataSet Addition(UcGnglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT gngl.* from uc_jsgngl jsgn LEFT JOIN uc_jsgl jsgl ON jsgn.ZJ_JSGL=jsgl.ZJ   ");
            strSql.Append(" LEFT JOIN uc_gngl gngl on jsgn.ZJ_GNGL = gngl.ZJ WHERE ");
            string jszj = "00127A9653CF4B0B54479330511YCGLJS";
            if (!string.IsNullOrEmpty(model.ZJ))
            {
                jszj = model.ZJ;
            }
            strSql.Append(" jsgn.ZJ_JSGL ='"+ jszj + "' ");  
            return DbHelperSQLite.Query(strSql.ToString());
        }
    }
}