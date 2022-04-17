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
    public partial class TransactionViewFilter : Form
    {
        private DataSet dataSet;

        public Boolean SearchTransactionFilterActionPerfrmed = false;
        public Boolean SearchTransactionFilterFormClosed = false;

        public DataObjects.DbInfo DbInfo { get; set; }

        public TransactionViewFilter()
        {
            InitializeComponent();
            DataObjects.DbInfo.dataSet = DataObjects.DbInfo.dbInfo;
            dataSet = DataObjects.DbInfo.dataSet.Copy();
            cmbTransactionCategoryFilter.DataSource = this.dataSet.Tables[0];
            cmbTransactionCategoryFilter.SelectedIndex = -1;
        }

        private void TransactionFilter(object sender, EventArgs e)
        {
            String SelectedValue;
            DateTime DateFrom, DateTo = DateTime.Now;

            if(cmbTransactionCategoryFilter.SelectedValue != null){
                SelectedValue = cmbTransactionCategoryFilter.SelectedValue.ToString();
            } else
            {
                SelectedValue = "";
            }

            if (chkDateFilter.Checked)
            {
                DateFrom = dateFromFilter.Value;
                DateTo = dateToFilter.Value;
            }
            else
            {
                DateFrom = new DateTime(1900, 1, 1);
                DateTo = new DateTime(1900, 1, 1);
            }

            M.TransactionModel transactionModel = new M.TransactionModel();
            dataSet.Tables[1].DefaultView.RowFilter = transactionModel.DataFieldsFilledCheckFilter(
                txtTransactionIDFilter.Text, 
                cmbTransactionCategoryFilter.SelectedIndex,
                SelectedValue,
                DateFrom, DateTo
                );
            
            dataSet.AcceptChanges();
            DataObjects.DbInfo.dataSet = dataSet;
            SearchTransactionFilterActionPerfrmed = true;
            this.Hide();
        }

        private void OnTransactionFilterFormClosed(object sender, FormClosedEventArgs e)
        {
            SearchTransactionFilterFormClosed = true;
        }

        private void OnCategoryChangeFilter(object sender, EventArgs e)
        {
            if (cmbTransactionCategoryFilter.SelectedIndex != -1)
            {
                foreach (DataRow row in dataSet.Tables[0].Select("catId = '" + cmbTransactionCategoryFilter.SelectedValue + "'"))
                {
                    lblDebitCreditFilter.Text = row[2].ToString();
                    if (lblDebitCreditFilter.Text == "Income")
                    {
                        lblDebitCreditFilter.ForeColor = Color.Blue;
                    }
                    else if (lblDebitCreditFilter.Text == "Expense")
                    {
                        lblDebitCreditFilter.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblDebitCreditFilter.Text = "~";
                lblDebitCreditFilter.ForeColor = Color.Black;
            }
        }

        private void OnFilterByDateCheckStateChange(object sender, EventArgs e)
        {
            if (chkDateFilter.Checked)
            {
                dateFromFilter.Enabled = true;
                dateToFilter.Enabled = true;
            }
            else
            {
                dateFromFilter.Enabled = false;
                dateToFilter.Enabled = false;
            }
            
        }
    }
}
