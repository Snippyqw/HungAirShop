namespace TermekKezelo
{
    partial class FormTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTK));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dTGVF = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cB_tip = new System.Windows.Forms.ComboBox();
            this.b_szurF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_newF = new System.Windows.Forms.Button();
            this.b_editF = new System.Windows.Forms.Button();
            this.b_delF = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_newR = new System.Windows.Forms.Button();
            this.b_editR = new System.Windows.Forms.Button();
            this.b_delR = new System.Windows.Forms.Button();
            this.dTGVR = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.betöltésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripDropDownButton();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTGVF)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTGVR)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dTGVF);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fegyverek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dTGVF
            // 
            this.dTGVF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTGVF.Location = new System.Drawing.Point(6, 6);
            this.dTGVF.Name = "dTGVF";
            this.dTGVF.Size = new System.Drawing.Size(638, 354);
            this.dTGVF.TabIndex = 9;
            this.dTGVF.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTGVF_CellValueChanged);
            this.dTGVF.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dTGVF_DefaultValuesNeeded);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cB_tip);
            this.groupBox2.Controls.Add(this.b_szurF);
            this.groupBox2.Location = new System.Drawing.Point(650, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adat szűrés";
            // 
            // cB_tip
            // 
            this.cB_tip.FormattingEnabled = true;
            this.cB_tip.Location = new System.Drawing.Point(6, 45);
            this.cB_tip.Name = "cB_tip";
            this.cB_tip.Size = new System.Drawing.Size(188, 21);
            this.cB_tip.TabIndex = 4;
            // 
            // b_szurF
            // 
            this.b_szurF.Location = new System.Drawing.Point(6, 220);
            this.b_szurF.Name = "b_szurF";
            this.b_szurF.Size = new System.Drawing.Size(82, 23);
            this.b_szurF.TabIndex = 3;
            this.b_szurF.Text = "Szűrés";
            this.b_szurF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_newF);
            this.groupBox1.Controls.Add(this.b_editF);
            this.groupBox1.Controls.Add(this.b_delF);
            this.groupBox1.Location = new System.Drawing.Point(650, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adat szerkesztés";
            // 
            // b_newF
            // 
            this.b_newF.Location = new System.Drawing.Point(6, 19);
            this.b_newF.Name = "b_newF";
            this.b_newF.Size = new System.Drawing.Size(82, 23);
            this.b_newF.TabIndex = 3;
            this.b_newF.Text = "Új";
            this.b_newF.UseVisualStyleBackColor = true;
            this.b_newF.Click += new System.EventHandler(this.b_newF_Click);
            // 
            // b_editF
            // 
            this.b_editF.Location = new System.Drawing.Point(112, 19);
            this.b_editF.Name = "b_editF";
            this.b_editF.Size = new System.Drawing.Size(82, 23);
            this.b_editF.TabIndex = 4;
            this.b_editF.Text = "Szerkesztés";
            this.b_editF.UseVisualStyleBackColor = true;
            this.b_editF.Click += new System.EventHandler(this.b_editF_Click);
            // 
            // b_delF
            // 
            this.b_delF.Location = new System.Drawing.Point(6, 48);
            this.b_delF.Name = "b_delF";
            this.b_delF.Size = new System.Drawing.Size(82, 23);
            this.b_delF.TabIndex = 5;
            this.b_delF.Text = "Törlés";
            this.b_delF.UseVisualStyleBackColor = true;
            this.b_delF.Click += new System.EventHandler(this.b_delF_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dTGVR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ruhák";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_newR);
            this.groupBox3.Controls.Add(this.b_editR);
            this.groupBox3.Controls.Add(this.b_delR);
            this.groupBox3.Location = new System.Drawing.Point(650, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 83);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adat szerkesztés";
            // 
            // b_newR
            // 
            this.b_newR.Location = new System.Drawing.Point(6, 19);
            this.b_newR.Name = "b_newR";
            this.b_newR.Size = new System.Drawing.Size(82, 23);
            this.b_newR.TabIndex = 3;
            this.b_newR.Text = "Új";
            this.b_newR.UseVisualStyleBackColor = true;
            // 
            // b_editR
            // 
            this.b_editR.Location = new System.Drawing.Point(112, 19);
            this.b_editR.Name = "b_editR";
            this.b_editR.Size = new System.Drawing.Size(82, 23);
            this.b_editR.TabIndex = 4;
            this.b_editR.Text = "Szerkesztés";
            this.b_editR.UseVisualStyleBackColor = true;
            // 
            // b_delR
            // 
            this.b_delR.Location = new System.Drawing.Point(6, 48);
            this.b_delR.Name = "b_delR";
            this.b_delR.Size = new System.Drawing.Size(82, 23);
            this.b_delR.TabIndex = 5;
            this.b_delR.Text = "Törlés";
            this.b_delR.UseVisualStyleBackColor = true;
            // 
            // dTGVR
            // 
            this.dTGVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTGVR.Location = new System.Drawing.Point(6, 6);
            this.dTGVR.Name = "dTGVR";
            this.dTGVR.Size = new System.Drawing.Size(638, 354);
            this.dTGVR.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(856, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Felszerelés";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.exit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betöltésToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // betöltésToolStripMenuItem
            // 
            this.betöltésToolStripMenuItem.Name = "betöltésToolStripMenuItem";
            this.betöltésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.betöltésToolStripMenuItem.Text = "Betöltés";
            this.betöltésToolStripMenuItem.Click += new System.EventHandler(this.betöltésToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // exit
            // 
            this.exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 20);
            this.exit.Text = "Kilépés";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Visszavonás";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // FormTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTK";
            this.Text = "Termék kezelő";
            this.Load += new System.EventHandler(this.FormTK_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTGVF)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTGVR)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem betöltésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.Button b_newF;
        private System.Windows.Forms.Button b_editF;
        private System.Windows.Forms.Button b_delF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cB_tip;
        private System.Windows.Forms.Button b_szurF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dTGVF;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_newR;
        private System.Windows.Forms.Button b_editR;
        private System.Windows.Forms.Button b_delR;
        private System.Windows.Forms.DataGridView dTGVR;
        private System.Windows.Forms.ToolStripDropDownButton exit;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}

