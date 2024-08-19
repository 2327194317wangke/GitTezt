using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL温度风速测试器
{
    public class SQLServer
    {
        private static SQLServer single = null;

        public static SQLServer  Single
        {
            get
            {
                if (single == null)
                {
                    single = new SQLServer();
                }
                return single;
            }

        }
        private SQLServer()
        {
            
        }




    }
}
