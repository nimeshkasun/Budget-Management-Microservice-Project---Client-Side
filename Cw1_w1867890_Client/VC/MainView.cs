using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            
            dataGridView1.DataSource = dbInfo.tblCategory;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RunCategoryView(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            categoryView.ShowDialog();

            dataGridView1.DataSource = dbInfo.tblCategory;
        }

        private void RunTransactionView(object sender, EventArgs e)
        {
            TransactionView transactionView = new TransactionView();
            transactionView.ShowDialog();
        }

        public DataObjects.DBBudget DB()
        {
            return dbInfo;
        }

        private void AddTemp(object sender, EventArgs e)
        {
            var data = @"{
  ""CategoryName"": ""JSONCat"",
  ""CategoryType"": ""TestJSON"",
  ""CategoryBudget"": 18.00
}";
            DataObjects.ApiCall apiCall = new DataObjects.ApiCall();
            MessageBox.Show(apiCall.ApiPOST(DataObjects.ApiCall.createCategory.ToString(), data));


        }
    }
}
