using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KNet.Data.Entity;
using MySql.Data.MySqlClient;

namespace ConsoleApplication2
{
    public  class Test
    {
        private static DataContext _dataContext;

        public Test()
        {
            _dataContext = new DataContext(ConfigurationManager.AppSettings["connectionString"], ProviderType.Mysql);
        }

        public void Run()
        {


            var ss = new List<com>();
            ss.Add(new com
            {
                ID = "00001",
                company_name = "10"
            });
            ss.Add(new com
            {
                ID = "00002",
                company_name = "11"
            });
            ss.Add(new com
            {
                ID = "00003",
                company_name = "13"
            });
            _dataContext.BulkWrite(ss, "company");
                
                Console.WriteLine("sddddd");
        

        }


        public void deRun()
        {


           

            var re=_dataContext.Delete<com>(s=>s.ID == "003", "company");

            Console.WriteLine("re");


        }

   



    }

    public class com
    {
        public string ID { get; set; }
        public string company_name { get; set; }
    }
}
