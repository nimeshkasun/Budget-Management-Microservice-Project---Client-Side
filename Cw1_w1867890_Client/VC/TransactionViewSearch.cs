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
    public partial class TransactionViewSearch : Form
    {
        public DataObjects.TransactionSearchInfo TransactionSearchInfo { get; set; }

        public Boolean SearchTransactionFormClosed = false;

        public TransactionViewSearch()
        {
            InitializeComponent();
        }

        private void TransactionSearch(object sender, EventArgs e)
        {
            this.TransactionSearchInfo = new DataObjects.TransactionSearchInfo();

            if (txtTransactionIDSearch.Text != "")
            {
                this.TransactionSearchInfo.TransactionId = Int32.Parse(txtTransactionIDSearch.Text);
            }

            this.Hide();
        }

        private void OnSearchTransactionFormClose(object sender, FormClosedEventArgs e)
        {
            this.SearchTransactionFormClosed = true;
        }

    }
}
