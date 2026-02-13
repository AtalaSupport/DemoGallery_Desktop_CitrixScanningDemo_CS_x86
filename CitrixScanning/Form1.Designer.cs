namespace CitrixScanning
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(32, 29);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(101, 31);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Device";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(157, 29);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(101, 31);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 88);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Citrix Scanning with DotTwain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnScan;
    }
}

