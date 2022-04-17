using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1_w1867890.DataObjects
{
    public class DbInfo
    {
        public static DataObjects.DBBudget dbInfo = new DataObjects.DBBudget();

        public static DataObjects.DBBudget dbInfoFilteredData = new DataObjects.DBBudget();

        public static DataSet dataSet = new DataSet();
    }
}
