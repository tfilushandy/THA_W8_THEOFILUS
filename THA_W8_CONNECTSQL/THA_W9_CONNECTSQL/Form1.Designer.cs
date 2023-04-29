namespace THA_W9_CONNECTSQL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboboxteam = new System.Windows.Forms.ComboBox();
            this.comboboxplayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.comboboxteam2 = new System.Windows.Forms.ComboBox();
            this.comboboxmatch = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // comboboxteam
            // 
            this.comboboxteam.FormattingEnabled = true;
            this.comboboxteam.Location = new System.Drawing.Point(100, 49);
            this.comboboxteam.Name = "comboboxteam";
            this.comboboxteam.Size = new System.Drawing.Size(121, 21);
            this.comboboxteam.TabIndex = 1;
            this.comboboxteam.SelectedIndexChanged += new System.EventHandler(this.comboboxteam_SelectedIndexChanged);
            // 
            // comboboxplayer
            // 
            this.comboboxplayer.FormattingEnabled = true;
            this.comboboxplayer.Location = new System.Drawing.Point(314, 49);
            this.comboboxplayer.Name = "comboboxplayer";
            this.comboboxplayer.Size = new System.Drawing.Size(138, 21);
            this.comboboxplayer.TabIndex = 2;
            this.comboboxplayer.SelectedIndexChanged += new System.EventHandler(this.comboboxplayer_SelectedIndexChanged);
            this.comboboxplayer.SelectionChangeCommitted += new System.EventHandler(this.comboboxplayer_SelectionChangeCommitted);
            this.comboboxplayer.SelectedValueChanged += new System.EventHandler(this.comboboxplayer_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEAM NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PLAYER NAME";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(23, 94);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 33);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl2.Location = new System.Drawing.Point(23, 126);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 33);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "*";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl3.Location = new System.Drawing.Point(23, 165);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 33);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl4.Location = new System.Drawing.Point(23, 207);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(25, 33);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "*";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl5.Location = new System.Drawing.Point(23, 247);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(25, 33);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "*";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl6.Location = new System.Drawing.Point(23, 286);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(25, 33);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "*";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl7.Location = new System.Drawing.Point(23, 328);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(25, 33);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "*";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl8.Location = new System.Drawing.Point(23, 364);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(25, 33);
            this.lbl8.TabIndex = 12;
            this.lbl8.Text = "*";
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dgv);
            this.pnl.Controls.Add(this.comboboxmatch);
            this.pnl.Controls.Add(this.comboboxteam2);
            this.pnl.Location = new System.Drawing.Point(0, 27);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(800, 426);
            this.pnl.TabIndex = 13;
            // 
            // comboboxteam2
            // 
            this.comboboxteam2.FormattingEnabled = true;
            this.comboboxteam2.Location = new System.Drawing.Point(26, 22);
            this.comboboxteam2.Name = "comboboxteam2";
            this.comboboxteam2.Size = new System.Drawing.Size(121, 21);
            this.comboboxteam2.TabIndex = 0;
            this.comboboxteam2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboboxteam2.SelectedValueChanged += new System.EventHandler(this.comboboxteam2_SelectedValueChanged);
            // 
            // comboboxmatch
            // 
            this.comboboxmatch.FormattingEnabled = true;
            this.comboboxmatch.Location = new System.Drawing.Point(227, 22);
            this.comboboxmatch.Name = "comboboxmatch";
            this.comboboxmatch.Size = new System.Drawing.Size(121, 21);
            this.comboboxmatch.TabIndex = 1;
            this.comboboxmatch.SelectedIndexChanged += new System.EventHandler(this.comboboxmatch_SelectedIndexChanged);
            this.comboboxmatch.SelectionChangeCommitted += new System.EventHandler(this.comboboxmatch_SelectionChangeCommitted);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(26, 67);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(575, 240);
            this.dgv.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxplayer);
            this.Controls.Add(this.comboboxteam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboboxteam;
        private System.Windows.Forms.ComboBox comboboxplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox comboboxmatch;
        private System.Windows.Forms.ComboBox comboboxteam2;
        private System.Windows.Forms.DataGridView dgv;
    }
}

