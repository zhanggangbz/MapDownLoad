using CYQ.Data;
using CYQ.Data.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class DBHelper
    {
        private static string ConnectStr = "Data Source=dt.db;failifmissing=false";

        public static void SetDBPath(string name,string path)
        {
            ConnectStr = "Data Source=" + path + name + ".db;failifmissing=false";
        }
        /// <summary>
        /// 检查目录下是否存在同名数据库，如不存在则创建，如存在则清空之前的数据
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool CheckDB(string name,string path)
        {
            SetDBPath(name, path);

            string sql = "DROP TABLE IF EXISTS \"dt\";CREATE TABLE \"dt\" (\"id\"  TEXT NOT NULL,\"z\"  INTEGER DEFAULT 0,\"x\"  INTEGER DEFAULT 0,\"y\"  INTEGER DEFAULT 0,\"d\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); ";

            using (MProc proc = new MProc(sql, ConnectStr))
            {
                int result = proc.ExeNonQuery();

                return result >= 0;
            }
        }

        /// <summary>
        /// 批量向数据库写入瓦片数据xyz信息
        /// </summary>
        /// <param name="listdata"></param>
        /// <returns></returns>
        public static bool insertDatas(List<DiTu_DB> listdata)
        {
            using(MDataTable dt2 = MDataTable.CreateFrom(listdata))
            {
                dt2.TableName = TableNames.dt.ToString();

                dt2.Conn = ConnectStr;

                return dt2.AcceptChanges(AcceptOp.InsertWithID);
            }
        }

        /// <summary>
        /// 批量更新瓦片数据
        /// </summary>
        /// <param name="listdata"></param>
        /// <returns></returns>
        public static bool updateDatas(List<DiTu_DB> listdata)
        {
            using (MDataTable dt2 = MDataTable.CreateFrom(listdata))
            {
                dt2.SetState(2);

                dt2.TableName = TableNames.dt.ToString();

                dt2.Conn = ConnectStr;

                return dt2.AcceptChanges(AcceptOp.Update);
            }
        }

        /// <summary>
        /// 更新某一个瓦片数据的标记位
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool updateItem(int x,int y,int z,int d)
        {
            using (MAction action = new MAction(TableNames.dt, ConnectStr))
            {
                action.Set(dt.d, d);
                string whereStr = "x=" + x + " and y=" + y + " and z=" + z;
                return action.Update(whereStr);
            }
        }

        /// <summary>
        /// 根据标记位从库中获取一定数量的数据
        /// </summary>
        /// <param name="count"></param>
        /// <param name="dataflag"></param>
        /// <returns></returns>
        public static List<DiTu_DB> GetData(int count,int dataflag)
        {
            using (MAction action = new MAction(TableNames.dt, ConnectStr))
            {
                string whereStr = "d=" + dataflag + " LIMIT " + count;
                MDataTable rs = action.Select(whereStr);

                return rs.ToList<DiTu_DB>();
            }
        }

        /// <summary>
        /// 库中未处理的数据的数量
        /// </summary>
        /// <param name="fm"></param>
        /// <param name="dataflag"></param>
        /// <returns></returns>
        public static int isComplate(Form1 fm, int dataflag)
        {
            string sql = "SELECT count(*) FROM dt WHERE d=" + dataflag;

            using (MProc proc = new MProc(sql, ConnectStr))
            {
                int result = proc.ExeScalar<int>();
                if (fm != null)
                {
                    fm.showLable4(result.ToString());
                }
                return result;
            }
        }
    }
}
