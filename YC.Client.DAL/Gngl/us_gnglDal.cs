using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using YC.Client.DAL;
using YC.Client.Entity;

namespace YC.Client.Data.Gngl
{
    //功能管理
    public class UsGnglDal : IUsDataDal<us_gnglModel>
    {
        public bool Exists(string ZJ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from us_gngl");
            strSql.Append(" where ");
            strSql.Append(" ZJ = @ZJ  ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)           };
            parameters[0].Value = ZJ;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(us_gnglModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into us_gngl(");
            strSql.Append("ZJ,JDMC,F_FJDZJ,DJ,JDPX,GNBZ,JDLX,JDSX,REMARK,QYBZ,GXR,CJR,GXSJ,CJSJ,VIPTYPE");
            strSql.Append(") values (");
            strSql.Append("@ZJ,@JDMC,@F_FJDZJ,@DJ,@JDPX,@GNBZ,@JDLX,@JDSX,@REMARK,@QYBZ,@GXR,@CJR,@GXSJ,@CJSJ,@VIPTYPE");
            strSql.Append(") ");

            MySqlParameter[] parameters = {
                        new MySqlParameter("@ZJ", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@JDMC", MySqlDbType.VarChar,100) ,
                        new MySqlParameter("@F_FJDZJ", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@DJ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@JDPX", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@GNBZ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@JDLX", MySqlDbType.VarChar,20) ,
                        new MySqlParameter("@JDSX", MySqlDbType.Text) ,
                        new MySqlParameter("@REMARK", MySqlDbType.VarChar,200) ,
                        new MySqlParameter("@QYBZ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@GXR", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@CJR", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@GXSJ", MySqlDbType.DateTime) ,
                        new MySqlParameter("@CJSJ", MySqlDbType.DateTime) ,
                        new MySqlParameter("@VIPTYPE", MySqlDbType.Int32,11)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.JDMC;
            parameters[2].Value = model.F_FJDZJ;
            parameters[3].Value = model.DJ;
            parameters[4].Value = model.JDPX;
            parameters[5].Value = model.GNBZ;
            parameters[6].Value = model.JDLX;
            parameters[7].Value = model.JDSX;
            parameters[8].Value = model.REMARK;
            parameters[9].Value = model.QYBZ;
            parameters[10].Value = model.GXR;
            parameters[11].Value = model.CJR;
            parameters[12].Value = model.GXSJ;
            parameters[13].Value = model.CJSJ;
            parameters[14].Value = model.VIPTYPE;
            DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(us_gnglModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update us_gngl set ");

            strSql.Append(" ZJ = @ZJ , ");
            strSql.Append(" JDMC = @JDMC , ");
            strSql.Append(" F_FJDZJ = @F_FJDZJ , ");
            strSql.Append(" DJ = @DJ , ");
            strSql.Append(" JDPX = @JDPX , ");
            strSql.Append(" GNBZ = @GNBZ , ");
            strSql.Append(" JDLX = @JDLX , ");
            strSql.Append(" JDSX = @JDSX , ");
            strSql.Append(" REMARK = @REMARK , ");
            strSql.Append(" QYBZ = @QYBZ , ");
            strSql.Append(" GXR = @GXR , ");
            strSql.Append(" CJR = @CJR , ");
            strSql.Append(" GXSJ = @GXSJ , ");
            strSql.Append(" CJSJ = @CJSJ , ");
            strSql.Append(" VIPTYPE = @VIPTYPE  ");
            strSql.Append(" where ZJ=@ZJ  ");

            MySqlParameter[] parameters = {
                        new MySqlParameter("@ZJ", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@JDMC", MySqlDbType.VarChar,100) ,
                        new MySqlParameter("@F_FJDZJ", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@DJ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@JDPX", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@GNBZ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@JDLX", MySqlDbType.VarChar,20) ,
                        new MySqlParameter("@JDSX", MySqlDbType.Text) ,
                        new MySqlParameter("@REMARK", MySqlDbType.VarChar,200) ,
                        new MySqlParameter("@QYBZ", MySqlDbType.Decimal,3) ,
                        new MySqlParameter("@GXR", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@CJR", MySqlDbType.VarChar,32) ,
                        new MySqlParameter("@GXSJ", MySqlDbType.DateTime) ,
                        new MySqlParameter("@CJSJ", MySqlDbType.DateTime) ,
                        new MySqlParameter("@VIPTYPE", MySqlDbType.Int32,11)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.JDMC;
            parameters[2].Value = model.F_FJDZJ;
            parameters[3].Value = model.DJ;
            parameters[4].Value = model.JDPX;
            parameters[5].Value = model.GNBZ;
            parameters[6].Value = model.JDLX;
            parameters[7].Value = model.JDSX;
            parameters[8].Value = model.REMARK;
            parameters[9].Value = model.QYBZ;
            parameters[10].Value = model.GXR;
            parameters[11].Value = model.CJR;
            parameters[12].Value = model.GXSJ;
            parameters[13].Value = model.CJSJ;
            parameters[14].Value = model.VIPTYPE;
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from us_gngl ");
            strSql.Append(" where ZJ=@ZJ ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)           };
            parameters[0].Value = ZJ;


            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public us_gnglModel GetModel(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZJ, JDMC, F_FJDZJ, DJ, JDPX, GNBZ, JDLX, JDSX, REMARK, QYBZ, GXR, CJR, GXSJ, CJSJ, VIPTYPE  ");
            strSql.Append("  from us_gngl ");
            strSql.Append(" where ZJ=@ZJ ");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@ZJ", MySqlDbType.VarChar,32)           };
            parameters[0].Value = ZJ;


            us_gnglModel model = new us_gnglModel();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ZJ = ds.Tables[0].Rows[0]["ZJ"].ToString();
                model.JDMC = ds.Tables[0].Rows[0]["JDMC"].ToString();
                model.F_FJDZJ = ds.Tables[0].Rows[0]["F_FJDZJ"].ToString();
                if (ds.Tables[0].Rows[0]["DJ"].ToString() != "")
                {
                    model.DJ = decimal.Parse(ds.Tables[0].Rows[0]["DJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JDPX"].ToString() != "")
                {
                    model.JDPX = decimal.Parse(ds.Tables[0].Rows[0]["JDPX"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GNBZ"].ToString() != "")
                {
                    model.GNBZ = decimal.Parse(ds.Tables[0].Rows[0]["GNBZ"].ToString());
                }
                model.JDLX = ds.Tables[0].Rows[0]["JDLX"].ToString();
                model.JDSX = ds.Tables[0].Rows[0]["JDSX"].ToString();
                model.REMARK = ds.Tables[0].Rows[0]["REMARK"].ToString();
                if (ds.Tables[0].Rows[0]["QYBZ"].ToString() != "")
                {
                    model.QYBZ = decimal.Parse(ds.Tables[0].Rows[0]["QYBZ"].ToString());
                }
                model.GXR = ds.Tables[0].Rows[0]["GXR"].ToString();
                model.CJR = ds.Tables[0].Rows[0]["CJR"].ToString();
                if (ds.Tables[0].Rows[0]["GXSJ"].ToString() != "")
                {
                    model.GXSJ = DateTime.Parse(ds.Tables[0].Rows[0]["GXSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CJSJ"].ToString() != "")
                {
                    model.CJSJ = DateTime.Parse(ds.Tables[0].Rows[0]["CJSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VIPTYPE"].ToString() != "")
                {
                    model.VIPTYPE = int.Parse(ds.Tables[0].Rows[0]["VIPTYPE"].ToString());
                }

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
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM us_gngl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM us_gngl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperMySQL.Query(strSql.ToString());
        }


    }
}
