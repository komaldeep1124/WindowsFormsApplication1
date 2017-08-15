namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.HeightUnits = new System.Windows.Forms.Label();
            this.WeightUnits = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.BMIResults = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Metric, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Height, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Weight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightUnits, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightUnits, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Calculate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.result, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BMIResults, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Metric.Location = new System.Drawing.Point(3, 3);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(86, 29);
            this.Metric.TabIndex = 0;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Imperial, 2);
            this.Imperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imperial.Location = new System.Drawing.Point(95, 3);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(101, 29);
            this.Imperial.TabIndex = 1;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(3, 66);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(68, 50);
            this.Height.TabIndex = 2;
            this.Height.Text = "My Height";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(95, 69);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(86, 45);
            this.HeightText.TabIndex = 3;
            this.HeightText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(95, 135);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(86, 45);
            this.WeightText.TabIndex = 4;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(3, 132);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(61, 40);
            this.Weight.TabIndex = 5;
            this.Weight.Text = "My Weight";
            // 
            // HeightUnits
            // 
            this.HeightUnits.AutoSize = true;
            this.HeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnits.Location = new System.Drawing.Point(187, 66);
            this.HeightUnits.Name = "HeightUnits";
            this.HeightUnits.Size = new System.Drawing.Size(70, 25);
            this.HeightUnits.TabIndex = 6;
            this.HeightUnits.Text = "Inches";
            this.HeightUnits.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WeightUnits
            // 
            this.WeightUnits.AutoSize = true;
            this.WeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnits.Location = new System.Drawing.Point(187, 132);
            this.WeightUnits.Name = "WeightUnits";
            this.WeightUnits.Size = new System.Drawing.Size(79, 25);
            this.WeightUnits.TabIndex = 7;
            this.WeightUnits.Text = "Pounds";
            this.WeightUnits.Click += new System.EventHandler(this.weight_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel1.SetColumnSpan(this.Calculate, 3);
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(3, 201);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(272, 49);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "CalculateBMI";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // BMIResults
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BMIResults, 3);
            this.BMIResults.Location = new System.Drawing.Point(3, 267);
            this.BMIResults.Name = "BMIResults";
            this.BMIResults.ReadOnly = true;
            this.BMIResults.Size = new System.Drawing.Size(272, 45);
            this.BMIResults.TabIndex = 9;
            // 
            // result
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.result, 3);
            this.result.Location = new System.Drawing.Point(3, 333);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(272, 45);
            this.result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label HeightUnits;
        private System.Windows.Forms.Label WeightUnits;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox BMIResults;
        private System.Windows.Forms.TextBox result;
    }
}

