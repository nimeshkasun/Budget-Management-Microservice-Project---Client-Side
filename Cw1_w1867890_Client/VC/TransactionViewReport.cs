using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw1_w1867890.VC
{
    public partial class TransactionViewReport : Form
    {
        private DataSet dataSet;

        public DataObjects.DbInfo DbInfo { get; set; }

        public TransactionViewReport()
        {
            InitializeComponent();
            DataObjects.DbInfo.dataSet = DataObjects.DbInfo.dbInfo;
            dataSet = DataObjects.DbInfo.dataSet.Copy();
            
        }

        private void SetChartData()
        {
            //
            // Total Income Vs Total Expense
            //
            Double totalIncome = 0;
            Double totalExpense = 0;

            foreach (DataRow rowT in dataSet.Tables[1].Select())
            {
                foreach (DataRow rowC in dataSet.Tables[0].Select("catId = '" + rowT[1].ToString() + "'"))
                {
                    
                    if(rowC[2].ToString() == "Income")
                    {                        
                        totalIncome += Double.Parse(rowT[5].ToString());
                    }else if(rowC[2].ToString() == "Expense")
                    {
                        totalExpense += Double.Parse(rowT[5].ToString());
                    }
                }
            }
            chrtIncomeVsExpense.Series.Add("IncomeVsExpense");
            chrtIncomeVsExpense.Series["IncomeVsExpense"].Points.AddXY("Total Income", totalIncome);
            chrtIncomeVsExpense.Series["IncomeVsExpense"].Points.AddXY("Total Expense", totalExpense);
            chrtIncomeVsExpense.Titles.Add("Total Income Vs Total Expense");

            //
            // Total Income category-wise
            //
            String[] catName = new String[0];
            Double[] catCost = new Double[0];
            
            foreach (DataRow rowT in dataSet.Tables[1].Select())
            {
                foreach (DataRow rowC in dataSet.Tables[0].Select("catId = '" + rowT[1].ToString() + "'"))
                {
                    if (rowC[2].ToString() == "Income")
                    {
                        

                        if (!(catName.Contains(rowC[1].ToString())))
                        {
                            Array.Resize(ref catName, catName.Length + 1);
                            catName[catName.Length - 1] = rowC[1].ToString();
                            Array.Resize(ref catCost, catCost.Length + 1);
                            catCost[catCost.Length - 1] = Double.Parse(rowT[5].ToString());
                        }
                        else if (catName.Contains(rowC[1].ToString()))
                        {
                            int indexOfArray = Array.IndexOf(catName, rowC[1].ToString());
                            catCost[indexOfArray] = catCost[indexOfArray] + Double.Parse(rowT[5].ToString());
                        }
                    }
                }
            }
            foreach (string i in catName)
            {
                chrtIncomeCategoryWise.Series.Add(i);
                int indexOfArray = Array.IndexOf(catName, i);
                chrtIncomeCategoryWise.Series[i].Points.AddXY(i, catCost[indexOfArray]);
            }
            chrtIncomeCategoryWise.Titles.Add("Total Income Category-wise");

            //
            // Total Expense category-wise
            //
            String[] catNameEx = new String[0];
            Double[] catCostEx = new Double[0];

            foreach (DataRow rowT in dataSet.Tables[1].Select())
            {
                foreach (DataRow rowC in dataSet.Tables[0].Select("catId = '" + rowT[1].ToString() + "'"))
                {
                    if (rowC[2].ToString() == "Expense")
                    {


                        if (!(catNameEx.Contains(rowC[1].ToString())))
                        {
                            Array.Resize(ref catNameEx, catNameEx.Length + 1);
                            catNameEx[catNameEx.Length - 1] = rowC[1].ToString();
                            Array.Resize(ref catCostEx, catCostEx.Length + 1);
                            catCostEx[catCostEx.Length - 1] = Double.Parse(rowT[5].ToString());
                        }
                        else if (catNameEx.Contains(rowC[1].ToString()))
                        {
                            int indexOfArray = Array.IndexOf(catNameEx, rowC[1].ToString());
                            catCostEx[indexOfArray] = catCostEx[indexOfArray] + Double.Parse(rowT[5].ToString());
                        }
                    }
                }
            }
            foreach (string i in catNameEx)
            {
                chrtExpenseCategoryWise.Series.Add(i);
                int indexOfArray = Array.IndexOf(catNameEx, i);
                chrtExpenseCategoryWise.Series[i].Points.AddXY(i, catCostEx[indexOfArray]);
            }
            chrtExpenseCategoryWise.Titles.Add("Total Expense Category-wise");

        }

        private void SetData()
        {
            DateTime DateFrom, DateTo = DateTime.Now;

            DateFrom = dateFromReport.Value;
            DateTo = dateToReport.Value;
            

            M.TransactionModel transactionModel = new M.TransactionModel();
            dataSet.Tables[1].DefaultView.RowFilter = transactionModel.StringForReport(DateFrom, DateTo);

            dataSet.AcceptChanges();
            DataObjects.DbInfo.dataSet = dataSet;
        }

        private void GenerateReport(object sender, EventArgs e)
        {
            SetData();
            chrtIncomeVsExpense.Series.Clear();
            chrtIncomeCategoryWise.Series.Clear();
            chrtExpenseCategoryWise.Series.Clear();
            SetChartData();
        }
    }
}
