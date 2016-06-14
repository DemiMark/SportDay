namespace Sport
{
    partial class Last
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
            this.lbl_site = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_site
            // 
            this.lbl_site.AutoSize = true;
            this.lbl_site.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_site.Location = new System.Drawing.Point(110, 33);
            this.lbl_site.Name = "lbl_site";
            this.lbl_site.Size = new System.Drawing.Size(93, 38);
            this.lbl_site.TabIndex = 0;
            this.lbl_site.Text = "label1";
            // 
            // btn_go
            // 
            this.btn_go.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go.Location = new System.Drawing.Point(96, 99);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(124, 34);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "GO!";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // Last
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 192);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.lbl_site);
            this.Name = "Last";
            this.Text = "Last Added";
            this.Load += new System.EventHandler(this.another_site_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_site;
        private System.Windows.Forms.Button btn_go;
    }
}