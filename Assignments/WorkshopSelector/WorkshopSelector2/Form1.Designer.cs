namespace WorkshopSelector2
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
            this.lblDays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLodg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxWorkshop = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDays.Location = new System.Drawing.Point(677, 265);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(86, 23);
            this.lblDays.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Days";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(216, 359);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 39);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Select a Workshop and Location to see the pricing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(627, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pricing";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(677, 312);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 23);
            this.lblTotal.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            // 
            // lblLodg
            // 
            this.lblLodg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLodg.Location = new System.Drawing.Point(677, 213);
            this.lblLodg.Name = "lblLodg";
            this.lblLodg.Size = new System.Drawing.Size(86, 23);
            this.lblLodg.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lodging";
            // 
            // lblRegis
            // 
            this.lblRegis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegis.Location = new System.Drawing.Point(677, 162);
            this.lblRegis.Name = "lblRegis";
            this.lblRegis.Size = new System.Drawing.Size(86, 23);
            this.lblRegis.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Registration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxLocation);
            this.groupBox2.Location = new System.Drawing.Point(314, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.ItemHeight = 16;
            this.listBoxLocation.Items.AddRange(new object[] {
            "Moncton",
            "Saint John",
            "Chicago",
            "Orlando",
            "New York"});
            this.listBoxLocation.Location = new System.Drawing.Point(17, 36);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(150, 132);
            this.listBoxLocation.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxWorkshop);
            this.groupBox1.Location = new System.Drawing.Point(38, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workshop";
            // 
            // listBoxWorkshop
            // 
            this.listBoxWorkshop.FormattingEnabled = true;
            this.listBoxWorkshop.ItemHeight = 16;
            this.listBoxWorkshop.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.listBoxWorkshop.Location = new System.Drawing.Point(22, 36);
            this.listBoxWorkshop.Name = "listBoxWorkshop";
            this.listBoxWorkshop.Size = new System.Drawing.Size(146, 132);
            this.listBoxWorkshop.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(630, 359);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLodg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLodg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxWorkshop;
        private System.Windows.Forms.Button btnClear;
    }
}

