namespace Miles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            endMi = new NumericUpDown();
            startMi = new NumericUpDown();
            CalcBtn = new Button();
            Total = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)endMi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startMi).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(132, 181);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 17;
            button1.Text = "Display Miles";
            button1.UseVisualStyleBackColor = true;
            // 
            // endMi
            // 
            endMi.Location = new Point(132, 101);
            endMi.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            endMi.Name = "endMi";
            endMi.Size = new Size(118, 27);
            endMi.TabIndex = 16;
            // 
            // startMi
            // 
            startMi.Location = new Point(132, 61);
            startMi.Maximum = new decimal(new int[] { 9998, 0, 0, 0 });
            startMi.Name = "startMi";
            startMi.Size = new Size(118, 27);
            startMi.TabIndex = 15;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(12, 181);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(108, 29);
            CalcBtn.TabIndex = 14;
            CalcBtn.Text = "Calc";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(132, 149);
            Total.Name = "Total";
            Total.Size = new Size(42, 20);
            Total.TabIndex = 13;
            Total.Text = "Total";
            // 
            // label4
            // 
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 12;
            label4.Text = "Amount Owed:";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 11;
            label3.Text = "Ending Milage:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 10;
            label2.Text = "Starting Milage:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 45);
            label1.TabIndex = 9;
            label1.Text = "Milage Claculator:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(endMi);
            Controls.Add(startMi);
            Controls.Add(CalcBtn);
            Controls.Add(Total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)endMi).EndInit();
            ((System.ComponentModel.ISupportInitialize)startMi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown endMi;
        private NumericUpDown startMi;
        private Button CalcBtn;
        private Label Total;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}