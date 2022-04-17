namespace Cw1_w1867890.VC
{
    partial class TransactionViewPrediction
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
            this.dateSelectedPredictionFutureDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPredictedIncome = new System.Windows.Forms.Label();
            this.lblPredictedExpense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Future Date for Prediction";
            // 
            // dateSelectedPredictionFutureDate
            // 
            this.dateSelectedPredictionFutureDate.Location = new System.Drawing.Point(207, 13);
            this.dateSelectedPredictionFutureDate.Name = "dateSelectedPredictionFutureDate";
            this.dateSelectedPredictionFutureDate.Size = new System.Drawing.Size(239, 20);
            this.dateSelectedPredictionFutureDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predicated Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Predicted Expense";
            // 
            // lblPredictedIncome
            // 
            this.lblPredictedIncome.AutoSize = true;
            this.lblPredictedIncome.Location = new System.Drawing.Point(207, 46);
            this.lblPredictedIncome.Name = "lblPredictedIncome";
            this.lblPredictedIncome.Size = new System.Drawing.Size(49, 13);
            this.lblPredictedIncome.TabIndex = 4;
            this.lblPredictedIncome.Text = "{income}";
            // 
            // lblPredictedExpense
            // 
            this.lblPredictedExpense.AutoSize = true;
            this.lblPredictedExpense.Location = new System.Drawing.Point(207, 76);
            this.lblPredictedExpense.Name = "lblPredictedExpense";
            this.lblPredictedExpense.Size = new System.Drawing.Size(55, 13);
            this.lblPredictedExpense.TabIndex = 5;
            this.lblPredictedExpense.Text = "{expense}";
            // 
            // TransactionViewPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 154);
            this.Controls.Add(this.lblPredictedExpense);
            this.Controls.Add(this.lblPredictedIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateSelectedPredictionFutureDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransactionViewPrediction";
            this.Text = "Transaction Prediction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSelectedPredictionFutureDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPredictedIncome;
        private System.Windows.Forms.Label lblPredictedExpense;
    }
}