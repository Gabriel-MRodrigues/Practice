namespace Lotto_6_49
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum1.Location = new System.Drawing.Point(12, 124);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(100, 66);
            this.lblNum1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 273);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 69);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(423, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum2.Location = new System.Drawing.Point(152, 124);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(100, 66);
            this.lblNum2.TabIndex = 3;
            // 
            // lblNum3
            // 
            this.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum3.Location = new System.Drawing.Point(286, 124);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(100, 66);
            this.lblNum3.TabIndex = 4;
            // 
            // lblNum4
            // 
            this.lblNum4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum4.Location = new System.Drawing.Point(423, 124);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(100, 66);
            this.lblNum4.TabIndex = 5;
            // 
            // lblNum5
            // 
            this.lblNum5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum5.Location = new System.Drawing.Point(562, 124);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(100, 66);
            this.lblNum5.TabIndex = 6;
            // 
            // lblNum6
            // 
            this.lblNum6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum6.Location = new System.Drawing.Point(688, 124);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(100, 66);
            this.lblNum6.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNum6);
            this.Controls.Add(this.lblNum5);
            this.Controls.Add(this.lblNum4);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum6;
    }
}

