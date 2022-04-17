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
    public partial class TransactionView : Form
    {
        private DataObjects.DBBudget dbInfo;
        private DataSet dataSet;
        public DataObjects.DbInfo DbInfo { get; set; }

        public TransactionView()
        {
            InitializeComponent();
            try
            {
                dbInfo = DataObjects.DbInfo.dbInfo;
                dgvTransaction.DataSource = this.dbInfo.tblTransaction;
                cmbTransactionCategory.DataSource = this.dbInfo.tblCategory;
                cmbTransactionCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveTransaction(object sender, EventArgs e)
        {
            M.TransactionModel transactionModel = new M.TransactionModel();
            if (lblTransactionId.Text == "Generating")
            {
                //
                // New transaction save code goes here
                //
                if (transactionModel.DataFieldsFilledCheck(cmbTransactionCategory.SelectedIndex, txtTransactionDescription.Text, dateTransactionDate.Value, chkTransactionRecurring.Checked, Double.Parse(txtTransactionAmount.Text)))
                {
                    DataObjects.DBBudget.tblTransactionRow row = this.dbInfo.tblTransaction.NewtblTransactionRow();
                    row.tranCatId = Int32.Parse(cmbTransactionCategory.SelectedValue.ToString());
                    row.tranDescription = txtTransactionDescription.Text;
                    row.tranDate = dateTransactionDate.Value;
                    row.tranRecurring = chkTransactionRecurring.Checked;
                    row.tranAmount = Double.Parse(txtTransactionAmount.Text);

                    this.dbInfo.tblTransaction.AddtblTransactionRow(row);
                    this.dbInfo.tblTransaction.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("Please fill all data fields.");
                }
            }
            else
            {
                //
                // Update code goes here
                //
                if (transactionModel.DataFieldsFilledCheck(cmbTransactionCategory.SelectedIndex, txtTransactionDescription.Text, dateTransactionDate.Value, chkTransactionRecurring.Checked, Double.Parse(txtTransactionAmount.Text)))
                {
                    foreach (DataRow row in dbInfo.Tables[1].Select("tranId = '" + lblTransactionId.Text + "'"))
                    {
                        row[1] = Int32.Parse(cmbTransactionCategory.SelectedValue.ToString());
                        row[2] = txtTransactionDescription.Text;
                        row[3] = dateTransactionDate.Value;
                        row[4] = chkTransactionRecurring.Checked;
                        row[5] = Double.Parse(txtTransactionAmount.Text);
                    }
                    dbInfo.Tables[0].AcceptChanges();
                }
            }
            dgvTransaction.DataSource = this.dbInfo.tblTransaction;

            lblTransactionId.Text = "~";
            cmbTransactionCategory.SelectedIndex = -1;
            txtTransactionDescription.Text = "";
            dateTransactionDate.Value = DateTime.Now;
            txtTransactionAmount.Text = "";

            cmbTransactionCategory.Enabled = false;
            txtTransactionDescription.Enabled = false;
            dateTransactionDate.Enabled = false;
            chkTransactionRecurring.Enabled = false;
            txtTransactionAmount.Enabled = false;
            btnTranSave.Enabled = false;
            btnTranNew.Enabled = true;
            btnTranDelete.Enabled = false;
            btnTranPopulate.Visible = false;
        }

        private void NewTransaction(object sender, EventArgs e)
        {
            lblTransactionId.Text = "Generating";
            cmbTransactionCategory.SelectedIndex = -1;
            txtTransactionDescription.Text = "";
            dateTransactionDate.Value = DateTime.Now;
            chkTransactionRecurring.Checked = false;
            txtTransactionAmount.Text = "";

            cmbTransactionCategory.Enabled = true;
            txtTransactionDescription.Enabled = true;
            dateTransactionDate.Enabled = true;
            chkTransactionRecurring.Enabled = true;
            txtTransactionAmount.Enabled = true;
            btnTranSave.Enabled = true;
            btnTranNew.Enabled = false;
            btnTranPopulate.Visible = false;
        }

        private void SearchTransaction(object sender, EventArgs e)
        {
            TransactionViewSearch transactionViewSearch = new TransactionViewSearch();
            transactionViewSearch.ShowDialog();

            //
            // Get data from Search Dialog
            //
            DataObjects.TransactionSearchInfo searchData = transactionViewSearch.TransactionSearchInfo;
            transactionViewSearch.Dispose();

            try
            {
                if (searchData != null)
                {
                    if (searchData.TransactionId != 0)
                    {
                        foreach (DataRow row in dbInfo.Tables[1].Select("tranId = '" + searchData.TransactionId + "'"))
                        {
                            lblTransactionId.Text = row[0].ToString();
                            cmbTransactionCategory.SelectedValue = row[1].ToString();
                            txtTransactionDescription.Text = row[2].ToString();
                            dateTransactionDate.Value = DateTime.Parse(row[3].ToString());
                            chkTransactionRecurring.Checked = Boolean.Parse(row[4].ToString());
                            txtTransactionAmount.Text = row[5].ToString();
                        }

                        if (lblTransactionId.Text != "~")
                        {
                            lblTransactionId.Enabled = true;
                            cmbTransactionCategory.Enabled = true;
                            txtTransactionDescription.Enabled = true;
                            dateTransactionDate.Enabled = true;
                            chkTransactionRecurring.Enabled = true;
                            txtTransactionAmount.Enabled = true;
                            btnTranSave.Enabled = true;
                            btnTranNew.Enabled = true;
                            btnTranDelete.Enabled = true;
                            btnTranPopulate.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("No Transaction found!");
                        }
                    }
                }

                if (transactionViewSearch.SearchTransactionFormClosed)
                {
                    lblTransactionId.Text = "~";
                    cmbTransactionCategory.SelectedIndex = -1;
                    txtTransactionDescription.Text = "";
                    dateTransactionDate.Value = DateTime.Now;
                    txtTransactionAmount.Text = "";

                    cmbTransactionCategory.Enabled = false;
                    txtTransactionDescription.Enabled = false;
                    dateTransactionDate.Enabled = false;
                    chkTransactionRecurring.Enabled = false;
                    txtTransactionAmount.Enabled = false;
                    btnTranSave.Enabled = false;
                    btnTranNew.Enabled = true;
                    btnTranDelete.Enabled = false;
                    btnTranPopulate.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnCategoryChange(object sender, EventArgs e)
        {
            if (cmbTransactionCategory.SelectedIndex != -1)
            {
                foreach (DataRow row in dbInfo.Tables[0].Select("catId = '" + cmbTransactionCategory.SelectedValue + "'"))
                {
                    lblDebitCredit.Text = row[2].ToString();
                    if(lblDebitCredit.Text == "Income")
                    {
                        lblDebitCredit.ForeColor = Color.Blue;
                    }else if (lblDebitCredit.Text == "Expense")
                    {
                        lblDebitCredit.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblDebitCredit.Text = "~";
                lblDebitCredit.ForeColor = Color.Black;
            }
        }

        private void DeleteTransaction(object sender, EventArgs e)
        {
            foreach (DataRow row in dbInfo.Tables[1].Select("tranId = '" + lblTransactionId.Text + "'"))
            {
                row.Delete();
            }
            dbInfo.Tables[0].AcceptChanges();

            lblTransactionId.Text = "~";
            cmbTransactionCategory.SelectedIndex = -1;
            txtTransactionDescription.Text = "";
            dateTransactionDate.Value = DateTime.Now;
            txtTransactionAmount.Text = "";

            cmbTransactionCategory.Enabled = false;
            txtTransactionDescription.Enabled = false;
            dateTransactionDate.Enabled = false;
            chkTransactionRecurring.Enabled = false;
            txtTransactionAmount.Enabled = false;
            btnTranSave.Enabled = false;
            btnTranNew.Enabled = true;
            btnTranDelete.Enabled = false;
            btnTranPopulate.Visible = false;
        }

        private void FilterTransaction(object sender, EventArgs e)
        {
            TransactionViewFilter transactionViewFilter = new TransactionViewFilter();
            transactionViewFilter.ShowDialog();

            if (transactionViewFilter.SearchTransactionFilterActionPerfrmed)
            {
                dataSet = DataObjects.DbInfo.dataSet;
                dgvTransaction.DataSource = dataSet.Tables[1];
                btnTranPopulate.Visible = true;
            }else if (transactionViewFilter.SearchTransactionFilterFormClosed)
            {
                dgvTransaction.DataSource = this.dbInfo.tblTransaction;
                btnTranPopulate.Visible = false;

            }

            transactionViewFilter.Dispose();
        }

        private void PopulateTransaction(object sender, EventArgs e)
        {
            dgvTransaction.DataSource = this.dbInfo.tblTransaction;            
            btnTranPopulate.Visible = false;
        }

        private void ReportTransaction(object sender, EventArgs e)
        {
            TransactionViewReport transactionViewReport = new TransactionViewReport();
            transactionViewReport.ShowDialog();
        }

        private void PredictTransaction(object sender, EventArgs e)
        {
            TransactionViewPrediction transactionViewPrediction = new TransactionViewPrediction();
            transactionViewPrediction.ShowDialog();
        }
    }
}
