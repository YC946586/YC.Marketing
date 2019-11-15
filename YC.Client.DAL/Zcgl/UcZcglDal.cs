using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YC.Client.Entity.Zcgl;

namespace YC.Client.Data.Zcgl
{
    //uc_zcgl
    [Data("YC.Client.Entity.Zcgl.UcZcglEntity")]
    public partial class UcZcglDal : IUsDataDal<UcZcglEntity>
    {

        public bool Exists(string ZJ)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from uc_zcgl");
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
        public void Add(UcZcglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into uc_zcgl(");
            strSql.Append("ZJ,ZCLX,ZCMC,JE,ZHMC,ZHYE,NAME,PHONE,CJR,CJSJ,BZ,QYBZ");
            strSql.Append(") values (");
            strSql.Append("@ZJ,@ZCLX,@ZCMC,@JE,@ZHMC,@ZHYE,@NAME,@PHONE,@CJR,@CJSJ,@BZ,@QYBZ");
            strSql.Append(") ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@ZCLX", DbType.String) ,
                        new SQLiteParameter("@ZCMC", DbType.String) ,
                        new SQLiteParameter("@JE", DbType.String) ,
                        new SQLiteParameter("@ZHMC", DbType.String) ,
                        new SQLiteParameter("@ZHYE", DbType.String) ,
                        new SQLiteParameter("@NAME", DbType.String) ,
                        new SQLiteParameter("@PHONE", DbType.String) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.ZCLX;
            parameters[2].Value = model.ZCMC;
            parameters[3].Value = model.JE;
            parameters[4].Value = model.ZHMC;
            parameters[5].Value = model.ZHYE;
            parameters[6].Value = model.NAME;
            parameters[7].Value = model.PHONE;
            parameters[8].Value = model.CJR;
            parameters[9].Value = model.CJSJ;
            parameters[10].Value = model.BZ;
            parameters[11].Value = model.QYBZ;
            DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(UcZcglEntity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update uc_zcgl set ");

            strSql.Append(" ZJ = @ZJ , ");
            strSql.Append(" ZCLX = @ZCLX , ");
            strSql.Append(" ZCMC = @ZCMC , ");
            strSql.Append(" JE = @JE , ");
            strSql.Append(" ZHMC = @ZHMC , ");
            strSql.Append(" ZHYE = @ZHYE , ");
            strSql.Append(" NAME = @NAME , ");
            strSql.Append(" PHONE = @PHONE , ");
            strSql.Append(" CJR = @CJR , ");
            strSql.Append(" CJSJ = @CJSJ , ");
            strSql.Append(" BZ = @BZ , ");
            strSql.Append(" QYBZ = @QYBZ  ");
            strSql.Append(" where ZJ=@ZJ  ");

            SQLiteParameter[] parameters = {
                        new SQLiteParameter("@ZJ", DbType.String) ,
                        new SQLiteParameter("@ZCLX", DbType.String) ,
                        new SQLiteParameter("@ZCMC", DbType.String) ,
                        new SQLiteParameter("@JE", DbType.String) ,
                        new SQLiteParameter("@ZHMC", DbType.String) ,
                        new SQLiteParameter("@ZHYE", DbType.String) ,
                        new SQLiteParameter("@NAME", DbType.String) ,
                        new SQLiteParameter("@PHONE", DbType.String) ,
                        new SQLiteParameter("@CJR", DbType.String) ,
                        new SQLiteParameter("@CJSJ", DbType.String) ,
                        new SQLiteParameter("@BZ", DbType.String) ,
                        new SQLiteParameter("@QYBZ", DbType.Int32,8)

            };

            parameters[0].Value = model.ZJ;
            parameters[1].Value = model.ZCLX;
            parameters[2].Value = model.ZCMC;
            parameters[3].Value = model.JE;
            parameters[4].Value = model.ZHMC;
            parameters[5].Value = model.ZHYE;
            parameters[6].Value = model.NAME;
            parameters[7].Value = model.PHONE;
            parameters[8].Value = model.CJR;
            parameters[9].Value = model.CJSJ;
            parameters[10].Value = model.BZ;
            parameters[11].Value = model.QYBZ;
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
        public bool Delete(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from uc_zcgl ");
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
        public UcZcglEntity GetModel(string ZJ)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ZJ, ZCLX, ZCMC, JE, ZHMC, ZHYE, NAME, PHONE, CJR, CJSJ, BZ, QYBZ  ");
            strSql.Append("  from uc_zcgl ");
            strSql.Append(" where ZJ=@ZJ ");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@ZJ", DbType.String)           };
            parameters[0].Value = ZJ;


            UcZcglEntity model = new UcZcglEntity();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ZJ = ds.Tables[0].Rows[0]["ZJ"].ToString();
                model.ZCLX = ds.Tables[0].Rows[0]["ZCLX"].ToString();
                model.ZCMC = ds.Tables[0].Rows[0]["ZCMC"].ToString();
                model.JE = ds.Tables[0].Rows[0]["JE"].ToString();
                model.ZHMC = ds.Tables[0].Rows[0]["ZHMC"].ToString();
                model.ZHYE = ds.Tables[0].Rows[0]["ZHYE"].ToString();
                model.NAME = ds.Tables[0].Rows[0]["NAME"].ToString();
                model.PHONE = ds.Tables[0].Rows[0]["PHONE"].ToString();
                model.CJR = ds.Tables[0].Rows[0]["CJR"].ToString();
                model.CJSJ = ds.Tables[0].Rows[0]["CJSJ"].ToString();
                model.BZ = ds.Tables[0].Rows[0]["BZ"].ToString();
                if (ds.Tables[0].Rows[0]["QYBZ"].ToString() != "")
                {
                    model.QYBZ = int.Parse(ds.Tables[0].Rows[0]["QYBZ"].ToString());
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
            strSql.Append(" FROM uc_zcgl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
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
            strSql.Append(" FROM uc_zcgl ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQLite.Query(strSql.ToString());
        }

        public DataSet Addition(UcZcglEntity model)
        {
            throw new NotImplementedException();
        }
    }
}

