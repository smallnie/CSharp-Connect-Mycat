using Pomelo.Data.MyCat;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomelo.Mycat
{
    class Program
    {
        static void Main(string[] args)
        {
            var result= ExecuteSqlByPomeloDataMyCat("insert into travelrecord(id,name) values(322,'uturtyurty')");
            Console.WriteLine(result == 1 ? "Insert Success" : "Insert Fail");
            var re = Query("select * from travelrecord");
            foreach (DataRow mDr in re.Tables[0].Rows)
            {
                foreach (DataColumn mDc in re.Tables[0].Columns)
                {
                    Console.Write(mDr[mDc].ToString());
                    Console.Write("|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlByPomeloDataMyCat(string SQLString)
        {
            using (var conn = new MyCatConnection(ConfigurationManager.AppSettings["PersonCenterConnectionString"]))
            {
                conn.Open();
                using (var cmd = new MyCatCommand(SQLString, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (MyCatConnection connection = new MyCatConnection(ConfigurationManager.AppSettings["PersonCenterConnectionString"]))
            {
                DataSet ds = new DataSet();
                connection.Open();
                MyCatDataAdapter command = new MyCatDataAdapter(SQLString, connection);
                command.Fill(ds);
                connection.Close();
                return ds;
            }
        }
    }
}
