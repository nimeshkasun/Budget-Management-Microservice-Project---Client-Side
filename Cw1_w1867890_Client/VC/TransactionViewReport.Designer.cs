namespace Cw1_w1867890.VC
{
    partial class TransactionViewReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtIncomeVsExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dBBudget = new Cw1_w1867890.DataObjects.DBBudget();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dateToReport = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFromReport = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chrtIncomeCategoryWise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtExpenseCategoryWise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeVsExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeCategoryWise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtExpenseCategoryWise)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtIncomeVsExpense
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtIncomeVsExpense.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtIncomeVsExpense.Legends.Add(legend1);
            this.chrtIncomeVsExpense.Location = new System.Drawing.Point(27, 154);
            this.chrtIncomeVsExpense.Name = "chrtIncomeVsExpense";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "IncomeVsExpense";
            this.chrtIncomeVsExpense.Series.Add(series1);
            this.chrtIncomeVsExpense.Size = new System.Drawing.Size(300, 300);
            this.chrtIncomeVsExpense.TabIndex = 0;
            this.chrtIncomeVsExpense.Text = "chart1";
            // 
            // dBBudget
            // 
            this.dBBudget.DataSetName = "DBBudget";
            this.dBBudget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateReport);
            this.groupBox1.Controls.Add(this.dateToReport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateFromReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 105);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Range";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(415, 64);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.GenerateReport);
            // 
            // dateToReport
            // 
            this.dateToReport.Location = new System.Drawing.Point(109, 65);
            this.dateToReport.Name = "dateToReport";
            this.dateToReport.Size = new System.Drawing.Size(275, 20);
            this.dateToReport.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // dateFromReport
            // 
            this.dateFromReport.Location = new System.Drawing.Point(109, 30);
            this.dateFromReport.Name = "dateFromReport";
            this.dateFromReport.Size = new System.Drawing.Size(275, 20);
            this.dateFromReport.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "From";
            // 
            // chrtIncomeCategoryWise
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtIncomeCategoryWise.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtIncomeCategoryWise.Legends.Add(legend2);
            this.chrtIncomeCategoryWise.Location = new System.Drawing.Point(353, 154);
            this.chrtIncomeCategoryWise.Name = "chrtIncomeCategoryWise";
            this.chrtIncomeCategoryWise.Size = new System.Drawing.Size(300, 300);
            this.chrtIncomeCategoryWise.TabIndex = 20;
            this.chrtIncomeCategoryWise.Text = "chart1";
            // 
            // chrtExpenseCategoryWise
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtExpenseCategoryWise.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtExpenseCategoryWise.Legends.Add(legend3);
            this.chrtExpenseCategoryWise.Location = new System.Drawing.Point(676, 154);
            this.chrtExpenseCategoryWise.Name = "chrtExpenseCategoryWise";
            this.chrtExpenseCategoryWise.Size = new System.Drawing.Size(300, 300);
            this.chrtExpenseCategoryWise.TabIndex = 21;
            this.chrtExpenseCategoryWise.Text = "chart1";
            // 
            // TransactionViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 484);
            this.Controls.Add(this.chrtExpenseCategoryWise);
            this.Controls.Add(this.chrtIncomeCategoryWise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chrtIncomeVsExpense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransactionViewReport";
            this.Text = "Transaction Report";
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeVsExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBudget)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncomeCategoryWise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtExpenseCategoryWise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncomeVsExpense;
        private DataObjects.DBBudget dBBudget;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateToReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFromReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncomeCategoryWise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtExpenseCategoryWise;
    }
}