namespace Cw1_w1867890.VC
{
    partial class CategoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCatSearch = new System.Windows.Forms.Button();
            this.btnCatNew = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategoryBudget = new System.Windows.Forms.TextBox();
            this.lblBudgetAllocation = new System.Windows.Forms.Label();
            this.cmbCategoryType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.dBBudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBudget = new Cw1_w1867890.DataObjects.DBBudget();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCatSearch
            // 
            this.btnCatSearch.Location = new System.Drawing.Point(12, 12);
            this.btnCatSearch.Name = "btnCatSearch";
            this.btnCatSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCatSearch.TabIndex = 0;
            this.btnCatSearch.Text = "Search";
            this.btnCatSearch.UseVisualStyleBackColor = true;
            this.btnCatSearch.Click += new System.EventHandler(this.SearchCategory);
            // 
            // btnCatNew
            // 
            this.btnCatNew.Location = new System.Drawing.Point(12, 42);
            this.btnCatNew.Name = "btnCatNew";
            this.btnCatNew.Size = new System.Drawing.Size(75, 23);
            this.btnCatNew.TabIndex = 1;
            this.btnCatNew.Text = "New";
            this.btnCatNew.UseVisualStyleBackColor = true;
            this.btnCatNew.Click += new System.EventHandler(this.NewCategory);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Enabled = false;
            this.btnCatDelete.Location = new System.Drawing.Point(12, 101);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCatDelete.TabIndex = 2;
            this.btnCatDelete.Text = "Delete";
            this.btnCatDelete.UseVisualStyleBackColor = true;
            this.btnCatDelete.Click += new System.EventHandler(this.DeleteCategory);
            // 
            // btnCatSave
            // 
            this.btnCatSave.Enabled = false;
            this.btnCatSave.Location = new System.Drawing.Point(12, 72);
            this.btnCatSave.Name = "btnCatSave";
            this.btnCatSave.Size = new System.Drawing.Size(75, 23);
            this.btnCatSave.TabIndex = 3;
            this.btnCatSave.Text = "Save";
            this.btnCatSave.UseVisualStyleBackColor = true;
            this.btnCatSave.Click += new System.EventHandler(this.SaveCategory);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoryBudget);
            this.groupBox1.Controls.Add(this.lblBudgetAllocation);
            this.groupBox1.Controls.Add(this.cmbCategoryType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCategoryId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(94, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Area";
            // 
            // txtCategoryBudget
            // 
            this.txtCategoryBudget.Enabled = false;
            this.txtCategoryBudget.Location = new System.Drawing.Point(379, 45);
            this.txtCategoryBudget.Name = "txtCategoryBudget";
            this.txtCategoryBudget.Size = new System.Drawing.Size(292, 20);
            this.txtCategoryBudget.TabIndex = 7;
            this.txtCategoryBudget.Visible = false;
            // 
            // lblBudgetAllocation
            // 
            this.lblBudgetAllocation.AutoSize = true;
            this.lblBudgetAllocation.Location = new System.Drawing.Point(279, 49);
            this.lblBudgetAllocation.Name = "lblBudgetAllocation";
            this.lblBudgetAllocation.Size = new System.Drawing.Size(90, 13);
            this.lblBudgetAllocation.TabIndex = 6;
            this.lblBudgetAllocation.Text = "Budget Allocation";
            this.lblBudgetAllocation.Visible = false;
            // 
            // cmbCategoryType
            // 
            this.cmbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryType.Enabled = false;
            this.cmbCategoryType.FormattingEnabled = true;
            this.cmbCategoryType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbCategoryType.Location = new System.Drawing.Point(90, 45);
            this.cmbCategoryType.Name = "cmbCategoryType";
            this.cmbCategoryType.Size = new System.Drawing.Size(162, 21);
            this.cmbCategoryType.TabIndex = 5;
            this.cmbCategoryType.SelectedIndexChanged += new System.EventHandler(this.OnCategoryTypeChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category Name";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(87, 20);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(14, 13);
            this.lblCategoryId.TabIndex = 2;
            this.lblCategoryId.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catogory ID";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Enabled = false;
            this.txtCategoryName.Location = new System.Drawing.Point(379, 16);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(292, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // dBBudgetBindingSource
            // 
            this.dBBudgetBindingSource.DataSource = this.dBBudget;
            this.dBBudgetBindingSource.Position = 0;
            // 
            // dBBudget
            // 
            this.dBBudget.DataSetName = "DBBudget";
            this.dBBudget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.dBBudgetBindingSource;
            // 
            // tblCategoryBindingSource1
            // 
            this.tblCategoryBindingSource1.DataMember = "tblCategory";
            this.tblCategoryBindingSource1.DataSource = this.dBBudgetBindingSource;
            // 
            // tblCategoryBindingSource2
            // 
            this.tblCategoryBindingSource2.DataMember = "tblCategory";
            this.tblCategoryBindingSource2.DataSource = this.dBBudget;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(94, 131);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(677, 306);
            this.dgvCategory.TabIndex = 5;
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCatSave);
            this.Controls.Add(this.btnCatDelete);
            this.Controls.Add(this.btnCatNew);
            this.Controls.Add(this.btnCatSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoryView";
            this.Text = "Category Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatSearch;
        private System.Windows.Forms.Button btnCatNew;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategoryType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryBudget;
        private System.Windows.Forms.Label lblBudgetAllocation;
        private System.Windows.Forms.BindingSource dBBudgetBindingSource;
        private DataObjects.DBBudget dBBudget;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource1;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource2;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}