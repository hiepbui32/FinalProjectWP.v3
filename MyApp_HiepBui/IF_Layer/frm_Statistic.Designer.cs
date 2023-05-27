namespace MyApp_HiepBui.IF_Layer
{
    partial class frm_Statistic
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pn1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResultQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbResultGoodsImported = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbResultItemsNeedImport = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMonthlySpending = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pn1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn1.Controls.Add(this.pictureBox1);
            this.pn1.Controls.Add(this.label3);
            this.pn1.Controls.Add(this.lbResultQuantity);
            this.pn1.Location = new System.Drawing.Point(24, 12);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(215, 160);
            this.pn1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inventory in stock";
            // 
            // lbResultQuantity
            // 
            this.lbResultQuantity.AutoSize = true;
            this.lbResultQuantity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbResultQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultQuantity.ForeColor = System.Drawing.Color.Navy;
            this.lbResultQuantity.Location = new System.Drawing.Point(3, 61);
            this.lbResultQuantity.Name = "lbResultQuantity";
            this.lbResultQuantity.Size = new System.Drawing.Size(83, 38);
            this.lbResultQuantity.TabIndex = 2;
            this.lbResultQuantity.Text = "num";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.linechart);
            this.panel1.Controls.Add(this.piechart);
            this.panel1.Location = new System.Drawing.Point(24, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 506);
            this.panel1.TabIndex = 1;
            // 
            // linechart
            // 
            this.linechart.BorderlineColor = System.Drawing.Color.Black;
            this.linechart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.linechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.linechart.Legends.Add(legend1);
            this.linechart.Location = new System.Drawing.Point(10, 29);
            this.linechart.Name = "linechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            this.linechart.Series.Add(series1);
            this.linechart.Size = new System.Drawing.Size(606, 431);
            this.linechart.TabIndex = 6;
            this.linechart.Text = "chart1";
            // 
            // piechart
            // 
            this.piechart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.piechart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.piechart.Legends.Add(legend2);
            this.piechart.Location = new System.Drawing.Point(661, 29);
            this.piechart.Name = "piechart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.piechart.Series.Add(series2);
            this.piechart.Size = new System.Drawing.Size(482, 431);
            this.piechart.TabIndex = 5;
            this.piechart.Text = "chart1";
            title1.Name = "Type of Item - Quantity";
            this.piechart.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbResultGoodsImported);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 160);
            this.panel2.TabIndex = 2;
            // 
            // lbResultGoodsImported
            // 
            this.lbResultGoodsImported.AutoSize = true;
            this.lbResultGoodsImported.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbResultGoodsImported.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultGoodsImported.ForeColor = System.Drawing.Color.Navy;
            this.lbResultGoodsImported.Location = new System.Drawing.Point(3, 61);
            this.lbResultGoodsImported.Name = "lbResultGoodsImported";
            this.lbResultGoodsImported.Size = new System.Drawing.Size(83, 38);
            this.lbResultGoodsImported.TabIndex = 4;
            this.lbResultGoodsImported.Text = "num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "this month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Goods imported";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbResultItemsNeedImport);
            this.panel3.Location = new System.Drawing.Point(523, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 160);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Items need import";
            // 
            // lbResultItemsNeedImport
            // 
            this.lbResultItemsNeedImport.AutoSize = true;
            this.lbResultItemsNeedImport.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbResultItemsNeedImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultItemsNeedImport.ForeColor = System.Drawing.Color.Navy;
            this.lbResultItemsNeedImport.Location = new System.Drawing.Point(2, 61);
            this.lbResultItemsNeedImport.Name = "lbResultItemsNeedImport";
            this.lbResultItemsNeedImport.Size = new System.Drawing.Size(109, 38);
            this.lbResultItemsNeedImport.TabIndex = 5;
            this.lbResultItemsNeedImport.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbMonthlySpending);
            this.panel4.Location = new System.Drawing.Point(765, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 160);
            this.panel4.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(3, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Monthly spending";
            // 
            // lbMonthlySpending
            // 
            this.lbMonthlySpending.AutoSize = true;
            this.lbMonthlySpending.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbMonthlySpending.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthlySpending.ForeColor = System.Drawing.Color.Navy;
            this.lbMonthlySpending.Location = new System.Drawing.Point(4, 61);
            this.lbMonthlySpending.Name = "lbMonthlySpending";
            this.lbMonthlySpending.Size = new System.Drawing.Size(109, 38);
            this.lbMonthlySpending.TabIndex = 5;
            this.lbMonthlySpending.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1047, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1047, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1047, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(8, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(9, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1209, 706);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Statistic";
            this.Load += new System.EventHandler(this.frm_Statistic_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lbResultQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultGoodsImported;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbResultItemsNeedImport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMonthlySpending;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart linechart;
    }
}