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
    public partial class TransactionViewPrediction : Form
    {
        private DataSet dataSet;
        DataTable dataTable = new DataTable();

        public DataObjects.DbInfo DbInfo { get; set; }

        public TransactionViewPrediction()
        {
            InitializeComponent();
            DataObjects.DbInfo.dataSet = DataObjects.DbInfo.dbInfo;
            dataSet = DataObjects.DbInfo.dataSet.Copy();            
        }

        private int SetLastMonthData(DateTime selectedDateOfPrediction)
        {
            //DateTime DateFrom, DateTo = DateTime.Now;

            //DateFrom = dateSelectedPredictionFutureDate.Value;
            //DateFrom.Month;
            //DateTo = dateToReport.Value;


            //M.TransactionModel transactionModel = new M.TransactionModel();
            //dataSet.Tables[1].DefaultView.RowFilter = "tranDate >= " + dateSelectedPredictionFutureDate.Value; //transactionModel.StringForReport(DateFrom, DateTo);

            

            var thisMonthRows = dataSet.Tables[1].AsEnumerable()
                .Where(r => r.Field<DateTime>("tranDate").Year == selectedDateOfPrediction.Year
                          && r.Field<DateTime>("tranDate").Month == selectedDateOfPrediction.Month-1);

            try
            {
                dataTable = thisMonthRows.CopyToDataTable();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            //dataSet.Tables[1].Equals(thisMonthRows);

            dataSet.AcceptChanges();
            DataObjects.DbInfo.dataSet = dataSet;

            return DateTime.DaysInMonth(year: selectedDateOfPrediction.Year, month: selectedDateOfPrediction.Month - 1);
        }

        private void PredictIncomeExpense(object sender, EventArgs e)
        {
            DateTime selectedDateOfPrediction = dateSelectedPredictionFutureDate.Value;
                   
            Double lastMonthTotalIncome = 0;
            Double lastMonthTotalExpense = 0;

            Double lastMonthIncomePerDay = 0;
            Double lastMonthExpensePerDay = 0;

            Double predictedIncome = 0;
            Double predictedExpense = 0;

            int lastMonthDayCount = SetLastMonthData(selectedDateOfPrediction);

            //DateTime dateTime = dateSelectedPredictionFutureDate.Value;

            foreach (DataRow rowT in dataTable.Select())
            {
                foreach (DataRow rowC in dataSet.Tables[0].Select("catId = '" + rowT[1].ToString() + "'"))
                {

                    if (rowC[2].ToString() == "Income")
                    {
                        lastMonthTotalIncome += Double.Parse(rowT[5].ToString());
                    }
                    else if (rowC[2].ToString() == "Expense")
                    {
                        lastMonthTotalExpense += Double.Parse(rowT[5].ToString());
                    }
                }
            }

            //
            // Prediction Algorithm
            //
            lastMonthIncomePerDay = lastMonthTotalIncome / lastMonthDayCount;
            lastMonthExpensePerDay = lastMonthTotalExpense / lastMonthDayCount;

            predictedIncome = Math.Round(lastMonthIncomePerDay * selectedDateOfPrediction.Day, 2);
            predictedExpense = Math.Round(lastMonthExpensePerDay * selectedDateOfPrediction.Day, 2);

            //Console.WriteLine("----");
            //Console.WriteLine("lastMonthTotalIncome: "+lastMonthTotalIncome+"  lastMonthDayCount: "+lastMonthDayCount);
            //Console.WriteLine("lastMonthIncomePerDay: "+lastMonthIncomePerDay+"  selectedDateOfPrediction.Day: "+selectedDateOfPrediction.Day);

            //Console.WriteLine("lastMonthTotalExpense: " + lastMonthTotalExpense + "  lastMonthDayCount: " + lastMonthDayCount);
            //Console.WriteLine("lastMonthExpensePerDay: " + lastMonthExpensePerDay + "  selectedDateOfPrediction.Day: " + selectedDateOfPrediction.Day);

            lblPredictedIncome.Text = predictedIncome.ToString();
            lblPredictedExpense.Text = predictedExpense.ToString();
        }
    }
}
