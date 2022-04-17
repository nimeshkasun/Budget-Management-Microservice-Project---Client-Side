using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1_w1867890.M
{
    public class TransactionModel
    {
        public Boolean DataFieldsFilledCheck(int tranCategoryIndex, String tranDescription, DateTime tranDate, Boolean tranRecurring, Double tranAmount)
        {
            if (tranCategoryIndex != -1 && tranDescription != "" && tranAmount.ToString() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String DataFieldsFilledCheckFilter(String transactionId, int tranCategoryIndex, String tranCategoryValue, DateTime dateFrom, DateTime dateTo)
        {
            String tranFilterQuery = "";

            if (transactionId != "")
            {
                tranFilterQuery = "tranId = " + "'" + transactionId + "'";
            }
            if (tranCategoryIndex != -1)
            {
                tranFilterQuery = "tranCatId = " + "'" + tranCategoryValue + "'";
            }
            if(dateFrom != new DateTime(1900, 1, 1) && dateTo != new DateTime(1900, 1, 1))
            {
                tranFilterQuery = "tranDate >= " + "'" + dateFrom + "' AND tranDate <= '" + dateTo + "'";
            }
            if (transactionId != "" && tranCategoryIndex != -1)
            {
                tranFilterQuery = "tranId = " + "'" + transactionId + "'" + " AND tranCatId = " + "'" + tranCategoryValue + "'";
            }
            if(transactionId != "" && dateFrom != new DateTime(1900, 1, 1) && dateTo != new DateTime(1900, 1, 1))
            {
                tranFilterQuery = "tranId = " + "'" + transactionId + "'" + " AND (tranDate >= " + "'" + dateFrom + "' AND tranDate <= '" + dateTo + "')";
            }
            if(tranCategoryIndex != -1 && dateFrom != new DateTime(1900, 1, 1) && dateTo != new DateTime(1900, 1, 1))
            {
                tranFilterQuery = "tranCatId = " + "'" + tranCategoryValue + "'" + " AND (tranDate >= " + "'" + dateFrom + "' AND tranDate <= '" + dateTo + "')";
            }
            if(transactionId != "" && tranCategoryIndex != -1 && dateFrom != new DateTime(1900, 1, 1) && dateTo != new DateTime(1900, 1, 1))
            {
                tranFilterQuery = "tranId = " + "'" + transactionId + "'" + " AND tranCatId = " + "'" + tranCategoryValue + "'" + " AND (tranDate >= " + "'" + dateFrom + "' AND tranDate <= '" + dateTo + "')";
            }

            return tranFilterQuery;
        }

        public String StringForReport(DateTime dateFrom, DateTime dateTo)
        {
            String tranFilterQuery = "";

            if (dateFrom != new DateTime(1900, 1, 1) && dateTo != new DateTime(1900, 1, 1))
            {
                tranFilterQuery = "tranDate >= " + "'" + dateFrom + "' AND tranDate <= '" + dateTo + "'";
            }

            return tranFilterQuery;
        }
    }
}
