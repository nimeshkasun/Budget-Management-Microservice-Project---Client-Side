namespace Cw1_w1867890.VC
{
    partial class ServiceHealthCheckView
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
            this.lblStatusAllServices = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pbStatusAllServices = new System.Windows.Forms.PictureBox();
            this.pbStatusAPIGateway = new System.Windows.Forms.PictureBox();
            this.lblStatusAPIGateway = new System.Windows.Forms.Label();
            this.pbStatusAPIGatewayCategory = new System.Windows.Forms.PictureBox();
            this.lblStatusAPIGatewayCategory = new System.Windows.Forms.Label();
            this.pbStatusAPIGatewayTransaction = new System.Windows.Forms.PictureBox();
            this.lblStatusAPIGatewayTransaction = new System.Windows.Forms.Label();
            this.pbStatusServiceCategory = new System.Windows.Forms.PictureBox();
            this.lblStatusServiceCategory = new System.Windows.Forms.Label();
            this.pbStatusServiceTransaction = new System.Windows.Forms.PictureBox();
            this.lblStatusServiceTransaction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAllServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGateway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGatewayCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGatewayTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServiceCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServiceTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusAllServices
            // 
            this.lblStatusAllServices.AutoSize = true;
            this.lblStatusAllServices.Location = new System.Drawing.Point(38, 71);
            this.lblStatusAllServices.Name = "lblStatusAllServices";
            this.lblStatusAllServices.Size = new System.Drawing.Size(61, 13);
            this.lblStatusAllServices.TabIndex = 5;
            this.lblStatusAllServices.Text = "Checking...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh Health";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnRefreshHealth);
            // 
            // pbStatusAllServices
            // 
            this.pbStatusAllServices.Location = new System.Drawing.Point(12, 67);
            this.pbStatusAllServices.Name = "pbStatusAllServices";
            this.pbStatusAllServices.Size = new System.Drawing.Size(20, 20);
            this.pbStatusAllServices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusAllServices.TabIndex = 7;
            this.pbStatusAllServices.TabStop = false;
            // 
            // pbStatusAPIGateway
            // 
            this.pbStatusAPIGateway.Location = new System.Drawing.Point(34, 93);
            this.pbStatusAPIGateway.Name = "pbStatusAPIGateway";
            this.pbStatusAPIGateway.Size = new System.Drawing.Size(20, 20);
            this.pbStatusAPIGateway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusAPIGateway.TabIndex = 9;
            this.pbStatusAPIGateway.TabStop = false;
            // 
            // lblStatusAPIGateway
            // 
            this.lblStatusAPIGateway.AutoSize = true;
            this.lblStatusAPIGateway.Location = new System.Drawing.Point(60, 97);
            this.lblStatusAPIGateway.Name = "lblStatusAPIGateway";
            this.lblStatusAPIGateway.Size = new System.Drawing.Size(61, 13);
            this.lblStatusAPIGateway.TabIndex = 8;
            this.lblStatusAPIGateway.Text = "Checking...";
            // 
            // pbStatusAPIGatewayCategory
            // 
            this.pbStatusAPIGatewayCategory.Location = new System.Drawing.Point(57, 119);
            this.pbStatusAPIGatewayCategory.Name = "pbStatusAPIGatewayCategory";
            this.pbStatusAPIGatewayCategory.Size = new System.Drawing.Size(20, 20);
            this.pbStatusAPIGatewayCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusAPIGatewayCategory.TabIndex = 11;
            this.pbStatusAPIGatewayCategory.TabStop = false;
            // 
            // lblStatusAPIGatewayCategory
            // 
            this.lblStatusAPIGatewayCategory.AutoSize = true;
            this.lblStatusAPIGatewayCategory.Location = new System.Drawing.Point(83, 123);
            this.lblStatusAPIGatewayCategory.Name = "lblStatusAPIGatewayCategory";
            this.lblStatusAPIGatewayCategory.Size = new System.Drawing.Size(61, 13);
            this.lblStatusAPIGatewayCategory.TabIndex = 10;
            this.lblStatusAPIGatewayCategory.Text = "Checking...";
            // 
            // pbStatusAPIGatewayTransaction
            // 
            this.pbStatusAPIGatewayTransaction.Location = new System.Drawing.Point(57, 145);
            this.pbStatusAPIGatewayTransaction.Name = "pbStatusAPIGatewayTransaction";
            this.pbStatusAPIGatewayTransaction.Size = new System.Drawing.Size(20, 20);
            this.pbStatusAPIGatewayTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusAPIGatewayTransaction.TabIndex = 13;
            this.pbStatusAPIGatewayTransaction.TabStop = false;
            // 
            // lblStatusAPIGatewayTransaction
            // 
            this.lblStatusAPIGatewayTransaction.AutoSize = true;
            this.lblStatusAPIGatewayTransaction.Location = new System.Drawing.Point(83, 149);
            this.lblStatusAPIGatewayTransaction.Name = "lblStatusAPIGatewayTransaction";
            this.lblStatusAPIGatewayTransaction.Size = new System.Drawing.Size(61, 13);
            this.lblStatusAPIGatewayTransaction.TabIndex = 12;
            this.lblStatusAPIGatewayTransaction.Text = "Checking...";
            // 
            // pbStatusServiceCategory
            // 
            this.pbStatusServiceCategory.Location = new System.Drawing.Point(34, 173);
            this.pbStatusServiceCategory.Name = "pbStatusServiceCategory";
            this.pbStatusServiceCategory.Size = new System.Drawing.Size(20, 20);
            this.pbStatusServiceCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusServiceCategory.TabIndex = 15;
            this.pbStatusServiceCategory.TabStop = false;
            // 
            // lblStatusServiceCategory
            // 
            this.lblStatusServiceCategory.AutoSize = true;
            this.lblStatusServiceCategory.Location = new System.Drawing.Point(60, 177);
            this.lblStatusServiceCategory.Name = "lblStatusServiceCategory";
            this.lblStatusServiceCategory.Size = new System.Drawing.Size(61, 13);
            this.lblStatusServiceCategory.TabIndex = 14;
            this.lblStatusServiceCategory.Text = "Checking...";
            // 
            // pbStatusServiceTransaction
            // 
            this.pbStatusServiceTransaction.Location = new System.Drawing.Point(34, 201);
            this.pbStatusServiceTransaction.Name = "pbStatusServiceTransaction";
            this.pbStatusServiceTransaction.Size = new System.Drawing.Size(20, 20);
            this.pbStatusServiceTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatusServiceTransaction.TabIndex = 17;
            this.pbStatusServiceTransaction.TabStop = false;
            // 
            // lblStatusServiceTransaction
            // 
            this.lblStatusServiceTransaction.AutoSize = true;
            this.lblStatusServiceTransaction.Location = new System.Drawing.Point(60, 205);
            this.lblStatusServiceTransaction.Name = "lblStatusServiceTransaction";
            this.lblStatusServiceTransaction.Size = new System.Drawing.Size(61, 13);
            this.lblStatusServiceTransaction.TabIndex = 16;
            this.lblStatusServiceTransaction.Text = "Checking...";
            // 
            // ServiceHealthCheckView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(362, 274);
            this.Controls.Add(this.pbStatusServiceTransaction);
            this.Controls.Add(this.lblStatusServiceTransaction);
            this.Controls.Add(this.pbStatusServiceCategory);
            this.Controls.Add(this.lblStatusServiceCategory);
            this.Controls.Add(this.pbStatusAPIGatewayTransaction);
            this.Controls.Add(this.lblStatusAPIGatewayTransaction);
            this.Controls.Add(this.pbStatusAPIGatewayCategory);
            this.Controls.Add(this.lblStatusAPIGatewayCategory);
            this.Controls.Add(this.pbStatusAPIGateway);
            this.Controls.Add(this.lblStatusAPIGateway);
            this.Controls.Add(this.pbStatusAllServices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStatusAllServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceHealthCheckView";
            this.Text = "Service Status";
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAllServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGateway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGatewayCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusAPIGatewayTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServiceCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatusServiceTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatusAllServices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbStatusAllServices;
        private System.Windows.Forms.PictureBox pbStatusAPIGateway;
        private System.Windows.Forms.Label lblStatusAPIGateway;
        private System.Windows.Forms.PictureBox pbStatusAPIGatewayCategory;
        private System.Windows.Forms.Label lblStatusAPIGatewayCategory;
        private System.Windows.Forms.PictureBox pbStatusAPIGatewayTransaction;
        private System.Windows.Forms.Label lblStatusAPIGatewayTransaction;
        private System.Windows.Forms.PictureBox pbStatusServiceCategory;
        private System.Windows.Forms.Label lblStatusServiceCategory;
        private System.Windows.Forms.PictureBox pbStatusServiceTransaction;
        private System.Windows.Forms.Label lblStatusServiceTransaction;
    }
}