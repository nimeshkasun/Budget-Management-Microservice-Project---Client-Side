using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cw1_w1867890.VC
{
    public partial class MainView : Form
    {
        private DataObjects.DBBudget dbInfo = DataObjects.DbInfo.dbInfo;

        public MainView()
        {
            InitializeComponent();
            DataObjects.DbInfo.SyncCategoryData();
            DataObjects.DbInfo.SyncTransactionData();

            dgvCategory.DataSource = dbInfo.tblCategory;
            dgvCategory.Columns["catId"].Visible = false;
            dgvCategory.Columns["catBudget"].Visible = false;
            dgvCategory.Columns["catName"].HeaderCell.Value = "Category Name";
            dgvCategory.Columns["catType"].HeaderCell.Value = "Category Type";


            dgvTransaction.DataSource = dbInfo.tblTransaction;
            dgvTransaction.Columns["tranCatId"].Visible = false;
            dgvTransaction.Columns["tranId"].HeaderCell.Value = "Transaction ID";
            dgvTransaction.Columns["tranDescription"].HeaderCell.Value = "Transaction Description";
            dgvTransaction.Columns["tranDate"].HeaderCell.Value = "Recurring";
            dgvTransaction.Columns["tranRecurring"].HeaderCell.Value = "Recurring";
            dgvTransaction.Columns["tranAmount"].HeaderCell.Value = "Amount";

        }

        private void ExitApplication(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RunCategoryView(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            categoryView.ShowDialog();

            dgvCategory.DataSource = dbInfo.tblCategory;
        }

        private void RunTransactionView(object sender, EventArgs e)
        {
            TransactionView transactionView = new TransactionView();
            transactionView.ShowDialog();
        }

        private void RunServiceHealthCheckView(object sender, EventArgs e)
        {
            ServiceHealthCheckView serviceHealthCheckView = new ServiceHealthCheckView();
            serviceHealthCheckView.ShowDialog();
        }

        public DataObjects.DBBudget DB()
        {
            return dbInfo;
        }

        private void SynchronizeDataManually(object sender, EventArgs e)
        {
            DataObjects.DbInfo.SyncCategoryData();
            DataObjects.DbInfo.SyncTransactionData();
        }

        private void UpdateSystemTime(object sender, EventArgs e)
        {
            lblSystemDateTime.Text = "System Date: " + DateTime.Now.ToString();
        }

    }
}
