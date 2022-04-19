using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public static void SyncCategoryData()
        {
            dbInfo.tblCategory.Clear();

            DataObjects.ApiCall apiCall = new DataObjects.ApiCall();
            String jsonArray = apiCall.ApiGET(DataObjects.ApiCall.readAllCategory.ToString());

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonArray, (typeof(DataTable)));
            DataObjects.DBBudget.tblCategoryRow row = dbInfo.tblCategory.NewtblCategoryRow();

            foreach (DataRow dr in dt.Rows)
            {
                row = dbInfo.tblCategory.NewtblCategoryRow();
                row.catId = Int32.Parse(dr["catId"].ToString());
                row.catName = dr["catName"].ToString();
                row.catType = dr["catType"].ToString();
                row.catBudget = Double.Parse(dr["catBudget"].ToString());
                dbInfo.tblCategory.AddtblCategoryRow(row);
                dbInfo.tblCategory.AcceptChanges();
            }

        }

        public static void SyncTransactionData()
        {
            dbInfo.tblTransaction.Clear();

            DataObjects.ApiCall apiCall = new DataObjects.ApiCall();
            String jsonArray = apiCall.ApiGET(DataObjects.ApiCall.readAllCategory.ToString());

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonArray, (typeof(DataTable)));
            DataObjects.DBBudget.tblCategoryRow row = dbInfo.tblCategory.NewtblCategoryRow();

            foreach (DataRow dr in dt.Rows)
            {
                row = dbInfo.tblCategory.NewtblCategoryRow();
                row.catId = Int32.Parse(dr["catId"].ToString());
                row.catName = dr["catName"].ToString();
                row.catType = dr["catType"].ToString();
                row.catBudget = Double.Parse(dr["catBudget"].ToString());
                dbInfo.tblCategory.AddtblCategoryRow(row);
                dbInfo.tblCategory.AcceptChanges();
            }

        }
    }
}
