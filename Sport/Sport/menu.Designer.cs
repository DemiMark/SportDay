namespace Sport
{
    partial class menu
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.football = new System.Windows.Forms.Button();
            this.tennis = new System.Windows.Forms.Button();
            this.basketball = new System.Windows.Forms.Button();
            this.golf = new System.Windows.Forms.Button();
            this.boxing = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.footballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tennisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basketballToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.golfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.another = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.BackgroundImage = global::Sport.Properties.Resources.foot;
            this.football.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.football.FlatAppearance.BorderSize = 0;
            this.football.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.football.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.football.ForeColor = System.Drawing.Color.Transparent;
            this.football.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.football.Location = new System.Drawing.Point(161, 155);
            this.football.Margin = new System.Windows.Forms.Padding(0);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(200, 120);
            this.football.TabIndex = 0;
            this.football.Text = "Football";
            this.football.UseVisualStyleBackColor = false;
            this.football.Click += new System.EventHandler(this.football_Click);
            // 
            // tennis
            // 
            this.tennis.BackgroundImage = global::Sport.Properties.Resources.tennis;
            this.tennis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tennis.FlatAppearance.BorderSize = 0;
            this.tennis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tennis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tennis.Location = new System.Drawing.Point(41, 303);
            this.tennis.Margin = new System.Windows.Forms.Padding(0);
            this.tennis.Name = "tennis";
            this.tennis.Size = new System.Drawing.Size(200, 120);
            this.tennis.TabIndex = 1;
            this.tennis.Text = "Tennis";
            this.tennis.UseVisualStyleBackColor = true;
            this.tennis.Click += new System.EventHandler(this.tennis_Click);
            // 
            // basketball
            // 
            this.basketball.BackgroundImage = global::Sport.Properties.Resources.bb;
            this.basketball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basketball.FlatAppearance.BorderSize = 0;
            this.basketball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basketball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basketball.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.basketball.Location = new System.Drawing.Point(296, 303);
            this.basketball.Name = "basketball";
            this.basketball.Size = new System.Drawing.Size(200, 120);
            this.basketball.TabIndex = 2;
            this.basketball.Text = "Basketball";
            this.basketball.UseVisualStyleBackColor = true;
            this.basketball.Click += new System.EventHandler(this.basketball_Click);
            // 
            // golf
            // 
            this.golf.BackgroundImage = global::Sport.Properties.Resources.golf;
            this.golf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.golf.FlatAppearance.BorderSize = 0;
            this.golf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.golf.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.golf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.golf.Location = new System.Drawing.Point(549, 303);
            this.golf.Name = "golf";
            this.golf.Size = new System.Drawing.Size(200, 120);
            this.golf.TabIndex = 3;
            this.golf.Text = "Golf";
            this.golf.UseVisualStyleBackColor = true;
            this.golf.Click += new System.EventHandler(this.golf_Click);
            // 
            // boxing
            // 
            this.boxing.BackColor = System.Drawing.Color.Transparent;
            this.boxing.BackgroundImage = global::Sport.Properties.Resources.box;
            this.boxing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxing.FlatAppearance.BorderSize = 0;
            this.boxing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxing.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.boxing.Location = new System.Drawing.Point(427, 155);
            this.boxing.Margin = new System.Windows.Forms.Padding(0);
            this.boxing.Name = "boxing";
            this.boxing.Size = new System.Drawing.Size(200, 120);
            this.boxing.TabIndex = 4;
            this.boxing.Text = "Boxing";
            this.boxing.UseVisualStyleBackColor = false;
            this.boxing.Click += new System.EventHandler(this.boxing_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Font = new System.Drawing.Font("Rage Italic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(185, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(401, 120);
            this.logo.TabIndex = 5;
            this.logo.Text = "SportDay";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footballToolStripMenuItem,
            this.boxingToolStripMenuItem,
            this.tennisToolStripMenuItem,
            this.basketballToolStripMenuItem,
            this.golfToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // footballToolStripMenuItem
            // 
            this.footballToolStripMenuItem.Name = "footballToolStripMenuItem";
            this.footballToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.footballToolStripMenuItem.Text = "Football";
            this.footballToolStripMenuItem.Click += new System.EventHandler(this.footballToolStripMenuItem_Click);
            // 
            // boxingToolStripMenuItem
            // 
            this.boxingToolStripMenuItem.Name = "boxingToolStripMenuItem";
            this.boxingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boxingToolStripMenuItem.Text = "Boxing";
            this.boxingToolStripMenuItem.Click += new System.EventHandler(this.boxingToolStripMenuItem_Click);
            // 
            // tennisToolStripMenuItem
            // 
            this.tennisToolStripMenuItem.Name = "tennisToolStripMenuItem";
            this.tennisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tennisToolStripMenuItem.Text = "Tennis";
            this.tennisToolStripMenuItem.Click += new System.EventHandler(this.tennisToolStripMenuItem_Click);
            // 
            // basketballToolStripMenuItem
            // 
            this.basketballToolStripMenuItem.Name = "basketballToolStripMenuItem";
            this.basketballToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.basketballToolStripMenuItem.Text = "Basketball";
            this.basketballToolStripMenuItem.Click += new System.EventHandler(this.basketballToolStripMenuItem_Click);
            // 
            // golfToolStripMenuItem
            // 
            this.golfToolStripMenuItem.Name = "golfToolStripMenuItem";
            this.golfToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.golfToolStripMenuItem.Text = "Golf";
            this.golfToolStripMenuItem.Click += new System.EventHandler(this.golfToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // another
            // 
            this.another.AutoSize = true;
            this.another.BackColor = System.Drawing.Color.Transparent;
            this.another.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.another.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.another.Location = new System.Drawing.Point(49, 481);
            this.another.Name = "another";
            this.another.Size = new System.Drawing.Size(136, 35);
            this.another.TabIndex = 7;
            this.another.Text = "Add Sport";
            this.another.Click += new System.EventHandler(this.another_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(566, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Added";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.another);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.boxing);
            this.Controls.Add(this.golf);
            this.Controls.Add(this.basketball);
            this.Controls.Add(this.tennis);
            this.Controls.Add(this.football);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "SportDay";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button football;
        private System.Windows.Forms.Button tennis;
        private System.Windows.Forms.Button basketball;
        private System.Windows.Forms.Button golf;
        private System.Windows.Forms.Button boxing;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem footballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tennisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basketballToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem golfToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label another;
        private System.Windows.Forms.Label label1;
    }
}

