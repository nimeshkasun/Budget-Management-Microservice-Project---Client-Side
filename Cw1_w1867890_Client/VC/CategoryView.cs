using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw1_w1867890.VC
{
    public partial class CategoryView : Form
    {

        private DataObjects.DBBudget dbInfo;
        public DataObjects.DbInfo DbInfo { get; set; }

        public CategoryView()
        {
            InitializeComponent();
            try
            {
                //VC.MainView mainView = new VC.MainView();
                //dbInfo = mainView.DbInfo.dbInfoData;
                dbInfo = DataObjects.DbInfo.dbInfo;
                dgvCategory.DataSource = this.dbInfo.tblCategory;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            M.CategoryModel categoryModel = new M.CategoryModel();
            if (lblCategoryId.Text == "Generating")
            {
                //
                // New category save code goes here
                //
                if (categoryModel.DataFieldsFilledCheck(txtCategoryName.Text, cmbCategoryType.SelectedIndex, txtCategoryBudget.Text))
                {
                    DataObjects.DBBudget.tblCategoryRow row = this.dbInfo.tblCategory.NewtblCategoryRow();
                    row.catName = txtCategoryName.Text;
                    row.catType = cmbCategoryType.SelectedItem.ToString();
                    if (cmbCategoryType.SelectedItem.ToString() == "Expense")
                    {
                        row.catBudget = Double.Parse(txtCategoryBudget.Text);
                    }
                    this.dbInfo.tblCategory.AddtblCategoryRow(row);
                    this.dbInfo.tblCategory.AcceptChanges();

                    //
                    // API Call
                    //
                    dynamic dataToConvert = new ExpandoObject();
                    dataToConvert.CatName = txtCategoryName.Text;
                    dataToConvert.CatType = cmbCategoryType.SelectedItem.ToString();
                    dataToConvert.CatBudget = Double.Parse(txtCategoryBudget.Text);

                    var data = Newtonsoft.Json.JsonConvert.SerializeObject(dataToConvert);
                    Console.WriteLine(data);

                    DataObjects.ApiCall apiCall = new DataObjects.ApiCall();
                    MessageBox.Show(apiCall.ApiPOST(DataObjects.ApiCall.createCategory.ToString(), data));

                    DataObjects.DbInfo.SyncCategoryData();
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
                if (categoryModel.DataFieldsFilledCheck(txtCategoryName.Text, cmbCategoryType.SelectedIndex, txtCategoryBudget.Text))
                {
                    foreach (DataRow row in dbInfo.Tables[0].Select("catId = '" + lblCategoryId.Text + "'"))
                    {
                        row[1] = txtCategoryName.Text;
                        row[2] = cmbCategoryType.SelectedItem.ToString();
                        if (cmbCategoryType.SelectedItem.ToString() == "Expense")
                        {
                            row[3] = txtCategoryBudget.Text;
                        }
                        else if (cmbCategoryType.SelectedItem.ToString() == "Income")
                        {
                            row[3] = 0;
                        }
                    }
                    dbInfo.Tables[0].AcceptChanges();
                }
            }
            dgvCategory.DataSource = this.dbInfo.tblCategory;

            lblCategoryId.Text = "~";
            txtCategoryName.Text = "";
            cmbCategoryType.SelectedIndex = -1;
            txtCategoryBudget.Text = "";

            txtCategoryName.Enabled = false;
            cmbCategoryType.Enabled = false;
            txtCategoryBudget.Enabled = false;
            btnCatSave.Enabled = false;
            btnCatNew.Enabled = true;
            btnCatDelete.Enabled = false;
        }

        private void NewCategory(object sender, EventArgs e)
        {
            lblCategoryId.Text = "Generating";
            txtCategoryName.Text = "";
            cmbCategoryType.SelectedIndex = -1;
            txtCategoryBudget.Text = "";

            txtCategoryName.Enabled = true; 
            cmbCategoryType.Enabled = true;
            txtCategoryBudget.Enabled = true;
            btnCatSave.Enabled = true;
            btnCatNew.Enabled = false;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            CategoryViewSearch categoryViewSearch = new CategoryViewSearch();
            categoryViewSearch.ShowDialog();

            //
            // Get data from Search Dialog
            //
            DataObjects.CategorySearchInfo searchData = categoryViewSearch.CategorySearchInfo;
            categoryViewSearch.Dispose();

            try
            {
                if (searchData != null)
                {
                    if (searchData.CategoryId != 0 || searchData.CategoryName != null)
                    {
                        foreach (DataRow row in dbInfo.Tables[0].Select("catId = '" + searchData.CategoryId + "' OR catName = '" + searchData.CategoryName + "'"))
                        {
                            lblCategoryId.Text = row[0].ToString();
                            txtCategoryName.Text = row[1].ToString();
                            cmbCategoryType.SelectedItem = row[2].ToString();
                            txtCategoryBudget.Text = row[3].ToString();
                        }

                        if (lblCategoryId.Text != "~")
                        {
                            txtCategoryName.Enabled = true;
                            cmbCategoryType.Enabled = true;
                            txtCategoryBudget.Enabled = true;
                            btnCatSave.Enabled = true;
                            btnCatNew.Enabled = true;
                            btnCatDelete.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No Category found!");
                        }
                    }
                }

                if (categoryViewSearch.SearchCategoryFormClosed)
                {
                    lblCategoryId.Text = "~";
                    txtCategoryName.Text = "";
                    cmbCategoryType.SelectedIndex = -1;
                    txtCategoryBudget.Text = "";

                    txtCategoryName.Enabled = false;
                    cmbCategoryType.Enabled = false;
                    txtCategoryBudget.Enabled = false;
                    btnCatSave.Enabled = false;
                    btnCatNew.Enabled = true;
                    btnCatDelete.Enabled = false;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnCategoryTypeChange(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoryType.SelectedItem != null)
                {
                    if (cmbCategoryType.SelectedItem.ToString() == "Income")
                    {
                        lblBudgetAllocation.Visible = false;
                        txtCategoryBudget.Visible = false;
                    }
                    else if (cmbCategoryType.SelectedItem.ToString() == "Expense")
                    {
                        lblBudgetAllocation.Visible = true;
                        txtCategoryBudget.Visible = true;
                    }
                    else
                    {
                        lblBudgetAllocation.Visible = false;
                        txtCategoryBudget.Visible = false;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCategory(object sender, EventArgs e)
        {
            foreach (DataRow row in dbInfo.Tables[0].Select("catId = '" + lblCategoryId.Text + "'"))
            {
                row.Delete();
            }
            dbInfo.Tables[0].AcceptChanges();

            lblCategoryId.Text = "~";
            txtCategoryName.Text = "";
            cmbCategoryType.SelectedIndex = -1;
            txtCategoryBudget.Text = "";

            txtCategoryName.Enabled = false;
            cmbCategoryType.Enabled = false;
            txtCategoryBudget.Enabled = false;
            btnCatSave.Enabled = false;
            btnCatNew.Enabled = true;
            btnCatDelete.Enabled = false;
        }
    }
}
