namespace NameSearch
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
            this.txtBoyName = new System.Windows.Forms.TextBox();
            this.txtGirlName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type in a name and click SEARCH to see if it is one of the popular given to boys " +
    "or girls from 2000 to 2009";
            // 
            // txtBoyName
            // 
            this.txtBoyName.Location = new System.Drawing.Point(142, 237);
            this.txtBoyName.Name = "txtBoyName";
            this.txtBoyName.Size = new System.Drawing.Size(156, 22);
            this.txtBoyName.TabIndex = 1;
            // 
            // txtGirlName
            // 
            this.txtGirlName.Location = new System.Drawing.Point(436, 237);
            this.txtGirlName.Name = "txtGirlName";
            this.txtGirlName.Size = new System.Drawing.Size(156, 22);
            this.txtGirlName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Girl";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 50);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGirlName);
            this.Controls.Add(this.txtBoyName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Search - Gabriel Rodrigues";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoyName;
        private System.Windows.Forms.TextBox txtGirlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
    }
}

