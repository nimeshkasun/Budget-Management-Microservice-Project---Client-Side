namespace Cw1_w1867890.VC
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBudget = new Cw1_w1867890.DataObjects.DBBudget();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.lblSystemDateTime = new System.Windows.Forms.Label();
            this.serviceStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.synchronizeDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // synchronizeDataToolStripMenuItem
            // 
            this.synchronizeDataToolStripMenuItem.Name = "synchronizeDataToolStripMenuItem";
            this.synchronizeDataToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.synchronizeDataToolStripMenuItem.Text = "Synchronize Data";
            this.synchronizeDataToolStripMenuItem.Click += new System.EventHandler(this.SynchronizeDataManually);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCategoryToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.categoryToolStripMenuItem.Text = "Edit";
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newCategoryToolStripMenuItem.Text = "Category";
            this.newCategoryToolStripMenuItem.Click += new System.EventHandler(this.RunCategoryView);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.updateToolStripMenuItem.Text = "Transaction";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.RunTransactionView);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceStatusToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(12, 64);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(334, 291);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateSystemTime);
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
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToOrderColumns = true;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(362, 64);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.Size = new System.Drawing.Size(689, 291);
            this.dgvTransaction.TabIndex = 2;
            this.dgvTransaction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateSystemTime);
            // 
            // lblSystemDateTime
            // 
            this.lblSystemDateTime.AutoSize = true;
            this.lblSystemDateTime.Location = new System.Drawing.Point(869, 5);
            this.lblSystemDateTime.Name = "lblSystemDateTime";
            this.lblSystemDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSystemDateTime.Size = new System.Drawing.Size(99, 13);
            this.lblSystemDateTime.TabIndex = 3;
            this.lblSystemDateTime.Text = "<SystemDateTime>";
            // 
            // serviceStatusToolStripMenuItem
            // 
            this.serviceStatusToolStripMenuItem.Name = "serviceStatusToolStripMenuItem";
            this.serviceStatusToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.serviceStatusToolStripMenuItem.Text = "Service Health Check";
            this.serviceStatusToolStripMenuItem.Click += new System.EventHandler(this.RunServiceHealthCheckView);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 388);
            this.Controls.Add(this.lblSystemDateTime);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.UpdateSystemTime);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateSystemTime);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private DataObjects.DBBudget dBBudget;
        private System.Windows.Forms.ToolStripMenuItem synchronizeDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblSystemDateTime;
        private System.Windows.Forms.ToolStripMenuItem serviceStatusToolStripMenuItem;
    }
}

