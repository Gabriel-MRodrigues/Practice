namespace Joe_s_Automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLube = new System.Windows.Forms.CheckBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTransmission = new System.Windows.Forms.CheckBox();
            this.chkRadiator = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.chkMuffler = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalFeesOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblPartsOutput = new System.Windows.Forms.Label();
            this.lblServiceLaborOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLube);
            this.groupBox1.Controls.Add(this.chkOilChange);
            this.groupBox1.Location = new System.Drawing.Point(91, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // chkLube
            // 
            this.chkLube.AutoSize = true;
            this.chkLube.Location = new System.Drawing.Point(21, 59);
            this.chkLube.Name = "chkLube";
            this.chkLube.Size = new System.Drawing.Size(130, 20);
            this.chkLube.TabIndex = 1;
            this.chkLube.Text = "Lube job ($18.00)";
            this.chkLube.UseVisualStyleBackColor = true;
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(21, 33);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(144, 20);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "Oil Change ($26.00)";
            this.chkOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTransmission);
            this.groupBox2.Controls.Add(this.chkRadiator);
            this.groupBox2.Location = new System.Drawing.Point(382, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // chkTransmission
            // 
            this.chkTransmission.AutoSize = true;
            this.chkTransmission.Location = new System.Drawing.Point(20, 59);
            this.chkTransmission.Name = "chkTransmission";
            this.chkTransmission.Size = new System.Drawing.Size(194, 20);
            this.chkTransmission.TabIndex = 1;
            this.chkTransmission.Text = "Transmission Flush ($80.00)";
            this.chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkRadiator
            // 
            this.chkRadiator.AutoSize = true;
            this.chkRadiator.Location = new System.Drawing.Point(20, 33);
            this.chkRadiator.Name = "chkRadiator";
            this.chkRadiator.Size = new System.Drawing.Size(165, 20);
            this.chkRadiator.TabIndex = 0;
            this.chkRadiator.Text = "Radiator Flush ($30.00)";
            this.chkRadiator.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTireRotation);
            this.groupBox3.Controls.Add(this.chkMuffler);
            this.groupBox3.Controls.Add(this.chkInspection);
            this.groupBox3.Location = new System.Drawing.Point(91, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(21, 106);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(155, 20);
            this.chkTireRotation.TabIndex = 2;
            this.chkTireRotation.Text = "Tire Rotation ($20.00)";
            this.chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // chkMuffler
            // 
            this.chkMuffler.AutoSize = true;
            this.chkMuffler.Location = new System.Drawing.Point(21, 68);
            this.chkMuffler.Name = "chkMuffler";
            this.chkMuffler.Size = new System.Drawing.Size(179, 20);
            this.chkMuffler.TabIndex = 1;
            this.chkMuffler.Text = "Replace Muffler ($100.00)";
            this.chkMuffler.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(21, 32);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(139, 20);
            this.chkInspection.TabIndex = 0;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLabor);
            this.groupBox4.Controls.Add(this.txtParts);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(382, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 132);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(124, 83);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(100, 22);
            this.txtLabor.TabIndex = 3;
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(124, 41);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(100, 22);
            this.txtParts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalFeesOutput);
            this.groupBox5.Controls.Add(this.lblTaxOutput);
            this.groupBox5.Controls.Add(this.lblPartsOutput);
            this.groupBox5.Controls.Add(this.lblServiceLaborOutput);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(91, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 219);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lblTotalFeesOutput
            // 
            this.lblTotalFeesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFeesOutput.Location = new System.Drawing.Point(248, 164);
            this.lblTotalFeesOutput.Name = "lblTotalFeesOutput";
            this.lblTotalFeesOutput.Size = new System.Drawing.Size(186, 26);
            this.lblTotalFeesOutput.TabIndex = 7;
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxOutput.Location = new System.Drawing.Point(248, 119);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(186, 26);
            this.lblTaxOutput.TabIndex = 6;
            // 
            // lblPartsOutput
            // 
            this.lblPartsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartsOutput.Location = new System.Drawing.Point(248, 80);
            this.lblPartsOutput.Name = "lblPartsOutput";
            this.lblPartsOutput.Size = new System.Drawing.Size(186, 26);
            this.lblPartsOutput.TabIndex = 5;
            // 
            // lblServiceLaborOutput
            // 
            this.lblServiceLaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServiceLaborOutput.Location = new System.Drawing.Point(248, 39);
            this.lblServiceLaborOutput.Name = "lblServiceLaborOutput";
            this.lblServiceLaborOutput.Size = new System.Drawing.Size(186, 26);
            this.lblServiceLaborOutput.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax (on parts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Service and Labor";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(126, 629);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(311, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(506, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkLube;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkTransmission;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkTireRotation;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFeesOutput;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblPartsOutput;
        private System.Windows.Forms.Label lblServiceLaborOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

