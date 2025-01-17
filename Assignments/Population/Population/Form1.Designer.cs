namespace Population
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartingNumber = new System.Windows.Forms.TextBox();
            this.txtDailyIncrease = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daily increase (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of days:";
            // 
            // txtStartingNumber
            // 
            this.txtStartingNumber.Location = new System.Drawing.Point(353, 26);
            this.txtStartingNumber.Name = "txtStartingNumber";
            this.txtStartingNumber.Size = new System.Drawing.Size(100, 22);
            this.txtStartingNumber.TabIndex = 0;
            // 
            // txtDailyIncrease
            // 
            this.txtDailyIncrease.Location = new System.Drawing.Point(353, 72);
            this.txtDailyIncrease.Name = "txtDailyIncrease";
            this.txtDailyIncrease.Size = new System.Drawing.Size(100, 22);
            this.txtDailyIncrease.TabIndex = 1;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(353, 123);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 2;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(198, 179);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(213, 228);
            this.lstOutput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(548, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 67);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(548, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 57);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtDailyIncrease);
            this.Controls.Add(this.txtStartingNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartingNumber;
        private System.Windows.Forms.TextBox txtDailyIncrease;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

