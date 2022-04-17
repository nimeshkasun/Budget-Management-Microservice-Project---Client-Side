namespace Cw1_w1867890.VC
{
    partial class CategoryViewSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryIDSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaegoryNameSearch = new System.Windows.Forms.TextBox();
            this.btnCategorySearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID";
            // 
            // txtCategoryIDSearch
            // 
            this.txtCategoryIDSearch.Location = new System.Drawing.Point(116, 14);
            this.txtCategoryIDSearch.Name = "txtCategoryIDSearch";
            this.txtCategoryIDSearch.Size = new System.Drawing.Size(225, 20);
            this.txtCategoryIDSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Name";
            // 
            // txtCaegoryNameSearch
            // 
            this.txtCaegoryNameSearch.Location = new System.Drawing.Point(116, 47);
            this.txtCaegoryNameSearch.Name = "txtCaegoryNameSearch";
            this.txtCaegoryNameSearch.Size = new System.Drawing.Size(225, 20);
            this.txtCaegoryNameSearch.TabIndex = 3;
            // 
            // btnCategorySearch
            // 
            this.btnCategorySearch.Location = new System.Drawing.Point(265, 84);
            this.btnCategorySearch.Name = "btnCategorySearch";
            this.btnCategorySearch.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySearch.TabIndex = 4;
            this.btnCategorySearch.Text = "Search";
            this.btnCategorySearch.UseVisualStyleBackColor = true;
            this.btnCategorySearch.Click += new System.EventHandler(this.CategorySearch);
            // 
            // CategoryViewSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 133);
            this.Controls.Add(this.btnCategorySearch);
            this.Controls.Add(this.txtCaegoryNameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryIDSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CategoryViewSearch";
            this.Text = "Category Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnSearchCategoryFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryIDSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaegoryNameSearch;
        private System.Windows.Forms.Button btnCategorySearch;
    }
}