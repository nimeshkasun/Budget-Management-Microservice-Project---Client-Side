namespace Cw1_w1867890.VC
{
    partial class TransactionViewSearch
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
            this.btnCategorySearch = new System.Windows.Forms.Button();
            this.txtTransactionIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCategorySearch
            // 
            this.btnCategorySearch.Location = new System.Drawing.Point(265, 85);
            this.btnCategorySearch.Name = "btnCategorySearch";
            this.btnCategorySearch.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySearch.TabIndex = 9;
            this.btnCategorySearch.Text = "Search";
            this.btnCategorySearch.UseVisualStyleBackColor = true;
            this.btnCategorySearch.Click += new System.EventHandler(this.TransactionSearch);
            // 
            // txtTransactionIDSearch
            // 
            this.txtTransactionIDSearch.Location = new System.Drawing.Point(116, 15);
            this.txtTransactionIDSearch.Name = "txtTransactionIDSearch";
            this.txtTransactionIDSearch.Size = new System.Drawing.Size(225, 20);
            this.txtTransactionIDSearch.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transaction ID";
            // 
            // TransactionViewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 133);
            this.Controls.Add(this.btnCategorySearch);
            this.Controls.Add(this.txtTransactionIDSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionViewSearch";
            this.Text = "Transaction Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnSearchTransactionFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorySearch;
        private System.Windows.Forms.TextBox txtTransactionIDSearch;
        private System.Windows.Forms.Label label1;
    }
}