namespace Sport
{
    partial class Add
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
            this.site = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_siteName = new System.Windows.Forms.TextBox();
            this.tb_siteURL = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // site
            // 
            this.site.AutoSize = true;
            this.site.Location = new System.Drawing.Point(33, 63);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(104, 13);
            this.site.TabIndex = 0;
            this.site.Text = "Wpisz Rodzaj sportu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz URL strony";
            // 
            // tb_siteName
            // 
            this.tb_siteName.Location = new System.Drawing.Point(169, 60);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.Size = new System.Drawing.Size(257, 20);
            this.tb_siteName.TabIndex = 2;
            this.tb_siteName.TextChanged += new System.EventHandler(this.tb_siteName_TextChanged);
            // 
            // tb_siteURL
            // 
            this.tb_siteURL.Location = new System.Drawing.Point(169, 124);
            this.tb_siteURL.Name = "tb_siteURL";
            this.tb_siteURL.Size = new System.Drawing.Size(257, 20);
            this.tb_siteURL.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(209, 187);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Zapisz";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 250);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_siteURL);
            this.Controls.Add(this.tb_siteName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.site);
            this.Name = "Add";
            this.Text = "New sport";
            this.Load += new System.EventHandler(this.another_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label site;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_siteName;
        private System.Windows.Forms.TextBox tb_siteURL;
        private System.Windows.Forms.Button btn_Save;

    }
}