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
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MyWeight = new System.Windows.Forms.Label();
            this.InputHeight = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Height, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MyWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputHeight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.weight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMI, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 4);
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
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.Location = new System.Drawing.Point(3, 3);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(86, 29);
            this.MetricButton.TabIndex = 0;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(95, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(80, 22);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 45);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 45);
            this.textBox2.TabIndex = 4;
            // 
            // MyWeight
            // 
            this.MyWeight.AutoSize = true;
            this.MyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeight.Location = new System.Drawing.Point(3, 132);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(61, 40);
            this.MyWeight.TabIndex = 5;
            this.MyWeight.Text = "My Weight";
            // 
            // InputHeight
            // 
            this.InputHeight.AutoSize = true;
            this.InputHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHeight.Location = new System.Drawing.Point(187, 66);
            this.InputHeight.Name = "InputHeight";
            this.InputHeight.Size = new System.Drawing.Size(76, 50);
            this.InputHeight.TabIndex = 6;
            this.InputHeight.Text = "Inches/Metres";
            this.InputHeight.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(187, 132);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(83, 34);
            this.weight.TabIndex = 7;
            this.weight.Text = "Pounds/Kilograms";
            // 
            // CalculateBMI
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMI, 3);
            this.CalculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.Location = new System.Drawing.Point(3, 201);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(272, 49);
            this.CalculateBMI.TabIndex = 8;
            this.CalculateBMI.Text = "CalculateBMI";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 3);
            this.textBox3.Location = new System.Drawing.Point(3, 267);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 45);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox4, 3);
            this.textBox4.Location = new System.Drawing.Point(3, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 45);
            this.textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.Label InputHeight;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

