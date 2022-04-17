namespace Cw1_w1867890.VC
{
    partial class TransactionViewFilter
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
            this.btnTransactionFilter = new System.Windows.Forms.Button();
            this.txtTransactionIDFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebitCreditFilter = new System.Windows.Forms.Label();
            this.cmbTransactionCategoryFilter = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBudget = new Cw1_w1867890.DataObjects.DBBudget();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFromFilter = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateToFilter = new System.Windows.Forms.DateTimePicker();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransactionFilter
            // 
            this.btnTransactionFilter.Location = new System.Drawing.Point(351, 224);
            this.btnTransactionFilter.Name = "btnTransactionFilter";
            this.btnTransactionFilter.Size = new System.Drawing.Size(75, 23);
            this.btnTransactionFilter.TabIndex = 12;
            this.btnTransactionFilter.Text = "Filter";
            this.btnTransactionFilter.UseVisualStyleBackColor = true;
            this.btnTransactionFilter.Click += new System.EventHandler(this.TransactionFilter);
            // 
            // txtTransactionIDFilter
            // 
            this.txtTransactionIDFilter.Location = new System.Drawing.Point(134, 14);
            this.txtTransactionIDFilter.Name = "txtTransactionIDFilter";
            this.txtTransactionIDFilter.Size = new System.Drawing.Size(292, 20);
            this.txtTransactionIDFilter.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transaction ID";
            // 
            // lblDebitCreditFilter
            // 
            this.lblDebitCreditFilter.AutoSize = true;
            this.lblDebitCreditFilter.Location = new System.Drawing.Point(77, 47);
            this.lblDebitCreditFilter.Name = "lblDebitCreditFilter";
            this.lblDebitCreditFilter.Size = new System.Drawing.Size(14, 13);
            this.lblDebitCreditFilter.TabIndex = 17;
            this.lblDebitCreditFilter.Text = "~";
            // 
            // cmbTransactionCategoryFilter
            // 
            this.cmbTransactionCategoryFilter.DataSource = this.tblCategoryBindingSource;
            this.cmbTransactionCategoryFilter.DisplayMember = "catName";
            this.cmbTransactionCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionCategoryFilter.FormattingEnabled = true;
            this.cmbTransactionCategoryFilter.Location = new System.Drawing.Point(134, 43);
            this.cmbTransactionCategoryFilter.Name = "cmbTransactionCategoryFilter";
            this.cmbTransactionCategoryFilter.Size = new System.Drawing.Size(292, 21);
            this.cmbTransactionCategoryFilter.TabIndex = 16;
            this.cmbTransactionCategoryFilter.ValueMember = "catId";
            this.cmbTransactionCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.OnCategoryChangeFilter);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Category";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDateFilter);
            this.groupBox1.Controls.Add(this.dateToFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateFromFilter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 129);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // dateFromFilter
            // 
            this.dateFromFilter.Enabled = false;
            this.dateFromFilter.Location = new System.Drawing.Point(109, 55);
            this.dateFromFilter.Name = "dateFromFilter";
            this.dateFromFilter.Size = new System.Drawing.Size(275, 20);
            this.dateFromFilter.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // dateToFilter
            // 
            this.dateToFilter.Enabled = false;
            this.dateToFilter.Location = new System.Drawing.Point(109, 90);
            this.dateToFilter.Name = "dateToFilter";
            this.dateToFilter.Size = new System.Drawing.Size(275, 20);
            this.dateToFilter.TabIndex = 3;
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(16, 28);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(92, 17);
            this.chkDateFilter.TabIndex = 4;
            this.chkDateFilter.Text = "Filter by date?";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.OnFilterByDateCheckStateChange);
            // 
            // TransactionViewFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDebitCreditFilter);
            this.Controls.Add(this.cmbTransactionCategoryFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransactionFilter);
            this.Controls.Add(this.txtTransactionIDFilter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransactionViewFilter";
            this.Text = "Transaction Filter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnTransactionFilterFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransactionFilter;
        private System.Windows.Forms.TextBox txtTransactionIDFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebitCreditFilter;
        private System.Windows.Forms.ComboBox cmbTransactionCategoryFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private DataObjects.DBBudget dBBudget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateToFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFromFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDateFilter;
    }
}