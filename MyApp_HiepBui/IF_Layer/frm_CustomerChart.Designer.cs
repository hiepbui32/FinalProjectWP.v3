namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_CustomerChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCustomer
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea1);
            this.chartCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCustomer.Legends.Add(legend1);
            this.chartCustomer.Location = new System.Drawing.Point(0, 0);
            this.chartCustomer.Name = "chartCustomer";
            this.chartCustomer.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Number of Members";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartCustomer.Series.Add(series1);
            this.chartCustomer.Size = new System.Drawing.Size(1355, 737);
            this.chartCustomer.TabIndex = 0;
            this.chartCustomer.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "The number of Members in a year";
            title1.Text = "The number of Members in a year";
            this.chartCustomer.Titles.Add(title1);
            // 
            // frm_CustomerChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartCustomer);
            this.Name = "frm_CustomerChart";
            this.Size = new System.Drawing.Size(1355, 737);
            this.Load += new System.EventHandler(this.frm_CustomerChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
    }
}
