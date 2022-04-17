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
    public partial class CategoryViewSearch : Form
    {
        public DataObjects.CategorySearchInfo CategorySearchInfo { get; set; }

        public Boolean SearchCategoryFormClosed = false;

        public CategoryViewSearch()
        {
            InitializeComponent();
        }

        private void CategorySearch(object sender, EventArgs e)
        {
            this.CategorySearchInfo = new DataObjects.CategorySearchInfo();

            if (txtCategoryIDSearch.Text != "")
            {
                this.CategorySearchInfo.CategoryId = Int32.Parse(txtCategoryIDSearch.Text);
            }
            if (txtCaegoryNameSearch.Text != null)
            {
                this.CategorySearchInfo.CategoryName = txtCaegoryNameSearch.Text;
            }

            this.Hide();
        }

        private void OnSearchCategoryFormClose(object sender, FormClosedEventArgs e)
        {
            this.SearchCategoryFormClosed = true;
        }
    }
}
