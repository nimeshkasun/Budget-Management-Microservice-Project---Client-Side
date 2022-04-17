namespace Cw1_w1867890.VC
{
    partial class TransactionView
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDebitCredit = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTransactionRecurring = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransactionDescription = new System.Windows.Forms.TextBox();
            this.cmbTransactionCategory = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBudget = new Cw1_w1867890.DataObjects.DBBudget();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTranSave = new System.Windows.Forms.Button();
            this.btnTranDelete = new System.Windows.Forms.Button();
            this.btnTranNew = new System.Windows.Forms.Button();
            this.btnTranSearch = new System.Windows.Forms.Button();
            this.btnTranFilter = new System.Windows.Forms.Button();
            this.btnTranReport = new System.Windows.Forms.Button();
            this.btnTranPopulate = new System.Windows.Forms.Button();
            this.btnTransPredict = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(94, 131);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.Size = new System.Drawing.Size(677, 306);
            this.dgvTransaction.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDebitCredit);
            this.groupBox1.Controls.Add(this.txtTransactionAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkTransactionRecurring);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTransactionDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTransactionDescription);
            this.groupBox1.Controls.Add(this.cmbTransactionCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTransactionId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Area";
            // 
            // lblDebitCredit
            // 
            this.lblDebitCredit.AutoSize = true;
            this.lblDebitCredit.Location = new System.Drawing.Point(322, 20);
            this.lblDebitCredit.Name = "lblDebitCredit";
            this.lblDebitCredit.Size = new System.Drawing.Size(14, 13);
            this.lblDebitCredit.TabIndex = 14;
            this.lblDebitCredit.Text = "~";
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Enabled = false;
            this.txtTransactionAmount.Location = new System.Drawing.Point(505, 75);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(166, 20);
            this.txtTransactionAmount.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount";
            // 
            // chkTransactionRecurring
            // 
            this.chkTransactionRecurring.AutoSize = true;
            this.chkTransactionRecurring.Enabled = false;
            this.chkTransactionRecurring.Location = new System.Drawing.Point(422, 78);
            this.chkTransactionRecurring.Name = "chkTransactionRecurring";
            this.chkTransactionRecurring.Size = new System.Drawing.Size(15, 14);
            this.chkTransactionRecurring.TabIndex = 11;
            this.chkTransactionRecurring.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Recurring?";
            // 
            // dateTransactionDate
            // 
            this.dateTransactionDate.Enabled = false;
            this.dateTransactionDate.Location = new System.Drawing.Point(132, 75);
            this.dateTransactionDate.Name = "dateTransactionDate";
            this.dateTransactionDate.Size = new System.Drawing.Size(210, 20);
            this.dateTransactionDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transaction Date";
            // 
            // txtTransactionDescription
            // 
            this.txtTransactionDescription.Enabled = false;
            this.txtTransactionDescription.Location = new System.Drawing.Point(132, 45);
            this.txtTransactionDescription.Name = "txtTransactionDescription";
            this.txtTransactionDescription.Size = new System.Drawing.Size(539, 20);
            this.txtTransactionDescription.TabIndex = 7;
            // 
            // cmbTransactionCategory
            // 
            this.cmbTransactionCategory.DataSource = this.tblCategoryBindingSource;
            this.cmbTransactionCategory.DisplayMember = "catName";
            this.cmbTransactionCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionCategory.Enabled = false;
            this.cmbTransactionCategory.FormattingEnabled = true;
            this.cmbTransactionCategory.Location = new System.Drawing.Point(379, 16);
            this.cmbTransactionCategory.Name = "cmbTransactionCategory";
            this.cmbTransactionCategory.Size = new System.Drawing.Size(292, 21);
            this.cmbTransactionCategory.TabIndex = 5;
            this.cmbTransactionCategory.ValueMember = "catId";
            this.cmbTransactionCategory.SelectedIndexChanged += new System.EventHandler(this.OnCategoryChange);
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "tblCategory";
            this.tblCategoryBindingSource.DataSource = this.dBBudget;
            // 
            // dBBudget
            // 
            this.dBBudget.DataSetName = "DBBudget";
            this.dBBudget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaction Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Location = new System.Drawing.Point(132, 20);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(14, 13);
            this.lblTransactionId.TabIndex = 2;
            this.lblTransactionId.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction ID";
            // 
            // btnTranSave
            // 
            this.btnTranSave.Enabled = false;
            this.btnTranSave.Location = new System.Drawing.Point(12, 72);
            this.btnTranSave.Name = "btnTranSave";
            this.btnTranSave.Size = new System.Drawing.Size(75, 23);
            this.btnTranSave.TabIndex = 9;
            this.btnTranSave.Text = "Save";
            this.btnTranSave.UseVisualStyleBackColor = true;
            this.btnTranSave.Click += new System.EventHandler(this.SaveTransaction);
            // 
            // btnTranDelete
            // 
            this.btnTranDelete.Enabled = false;
            this.btnTranDelete.Location = new System.Drawing.Point(12, 101);
            this.btnTranDelete.Name = "btnTranDelete";
            this.btnTranDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTranDelete.TabIndex = 8;
            this.btnTranDelete.Text = "Delete";
            this.btnTranDelete.UseVisualStyleBackColor = true;
            this.btnTranDelete.Click += new System.EventHandler(this.DeleteTransaction);
            // 
            // btnTranNew
            // 
            this.btnTranNew.Location = new System.Drawing.Point(12, 42);
            this.btnTranNew.Name = "btnTranNew";
            this.btnTranNew.Size = new System.Drawing.Size(75, 23);
            this.btnTranNew.TabIndex = 7;
            this.btnTranNew.Text = "New";
            this.btnTranNew.UseVisualStyleBackColor = true;
            this.btnTranNew.Click += new System.EventHandler(this.NewTransaction);
            // 
            // btnTranSearch
            // 
            this.btnTranSearch.Location = new System.Drawing.Point(12, 12);
            this.btnTranSearch.Name = "btnTranSearch";
            this.btnTranSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTranSearch.TabIndex = 6;
            this.btnTranSearch.Text = "Search";
            this.btnTranSearch.UseVisualStyleBackColor = true;
            this.btnTranSearch.Click += new System.EventHandler(this.SearchTransaction);
            // 
            // btnTranFilter
            // 
            this.btnTranFilter.Location = new System.Drawing.Point(13, 356);
            this.btnTranFilter.Name = "btnTranFilter";
            this.btnTranFilter.Size = new System.Drawing.Size(75, 23);
            this.btnTranFilter.TabIndex = 12;
            this.btnTranFilter.Text = "FIlter";
            this.btnTranFilter.UseVisualStyleBackColor = true;
            this.btnTranFilter.Click += new System.EventHandler(this.FilterTransaction);
            // 
            // btnTranReport
            // 
            this.btnTranReport.Location = new System.Drawing.Point(13, 385);
            this.btnTranReport.Name = "btnTranReport";
            this.btnTranReport.Size = new System.Drawing.Size(75, 23);
            this.btnTranReport.TabIndex = 13;
            this.btnTranReport.Text = "Report";
            this.btnTranReport.UseVisualStyleBackColor = true;
            this.btnTranReport.Click += new System.EventHandler(this.ReportTransaction);
            // 
            // btnTranPopulate
            // 
            this.btnTranPopulate.Location = new System.Drawing.Point(13, 327);
            this.btnTranPopulate.Name = "btnTranPopulate";
            this.btnTranPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnTranPopulate.TabIndex = 14;
            this.btnTranPopulate.Text = "Populate";
            this.btnTranPopulate.UseVisualStyleBackColor = true;
            this.btnTranPopulate.Visible = false;
            this.btnTranPopulate.Click += new System.EventHandler(this.PopulateTransaction);
            // 
            // btnTransPredict
            // 
            this.btnTransPredict.Location = new System.Drawing.Point(12, 414);
            this.btnTransPredict.Name = "btnTransPredict";
            this.btnTransPredict.Size = new System.Drawing.Size(75, 23);
            this.btnTransPredict.TabIndex = 15;
            this.btnTransPredict.Text = "Predict";
            this.btnTransPredict.UseVisualStyleBackColor = true;
            this.btnTransPredict.Click += new System.EventHandler(this.PredictTransaction);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransPredict);
            this.Controls.Add(this.btnTranPopulate);
            this.Controls.Add(this.btnTranReport);
            this.Controls.Add(this.btnTranFilter);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTranSave);
            this.Controls.Add(this.btnTranDelete);
            this.Controls.Add(this.btnTranNew);
            this.Controls.Add(this.btnTranSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransactionView";
            this.Text = "Transaction Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransactionDescription;
        private System.Windows.Forms.ComboBox cmbTransactionCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTranSave;
        private System.Windows.Forms.Button btnTranDelete;
        private System.Windows.Forms.Button btnTranNew;
        private System.Windows.Forms.Button btnTranSearch;
        private System.Windows.Forms.DateTimePicker dateTransactionDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTransactionRecurring;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Label label6;
        private DataObjects.DBBudget dBBudget;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private System.Windows.Forms.Label lblDebitCredit;
        private System.Windows.Forms.Button btnTranFilter;
        private System.Windows.Forms.Button btnTranReport;
        private System.Windows.Forms.Button btnTranPopulate;
        private System.Windows.Forms.Button btnTransPredict;
    }
}