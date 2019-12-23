namespace COCOMO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.intermediateBTN = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.attributesBTN = new System.Windows.Forms.Button();
            this.tdevBTN = new System.Windows.Forms.Button();
            this.effortBTN = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.intermediatePanel = new COCOMO.Controls.Intermediate();
            this.homePanel = new COCOMO.Controls.Home();
            this.tdevPanel = new COCOMO.Controls.TDEV();
            this.effortPanel = new COCOMO.Controls.Effort();
            this.costDriverPanel = new COCOMO.Controls.CostDriver();
            this.teamPanel = new COCOMO.Controls.Team();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.intermediateBTN);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.attributesBTN);
            this.panel1.Controls.Add(this.tdevBTN);
            this.panel1.Controls.Add(this.effortBTN);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.homeBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 583);
            this.panel1.TabIndex = 0;
            // 
            // intermediateBTN
            // 
            this.intermediateBTN.FlatAppearance.BorderSize = 0;
            this.intermediateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intermediateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediateBTN.ForeColor = System.Drawing.Color.White;
            this.intermediateBTN.Image = ((System.Drawing.Image)(resources.GetObject("intermediateBTN.Image")));
            this.intermediateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.intermediateBTN.Location = new System.Drawing.Point(12, 351);
            this.intermediateBTN.Name = "intermediateBTN";
            this.intermediateBTN.Size = new System.Drawing.Size(197, 54);
            this.intermediateBTN.TabIndex = 5;
            this.intermediateBTN.Text = "       Intermediate Model";
            this.intermediateBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.intermediateBTN.UseVisualStyleBackColor = true;
            this.intermediateBTN.Click += new System.EventHandler(this.intermediateBTN_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 61);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // attributesBTN
            // 
            this.attributesBTN.FlatAppearance.BorderSize = 0;
            this.attributesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attributesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesBTN.ForeColor = System.Drawing.Color.White;
            this.attributesBTN.Image = ((System.Drawing.Image)(resources.GetObject("attributesBTN.Image")));
            this.attributesBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attributesBTN.Location = new System.Drawing.Point(12, 278);
            this.attributesBTN.Name = "attributesBTN";
            this.attributesBTN.Size = new System.Drawing.Size(197, 54);
            this.attributesBTN.TabIndex = 4;
            this.attributesBTN.Text = "       Cost Drivers";
            this.attributesBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.attributesBTN.UseVisualStyleBackColor = true;
            this.attributesBTN.Click += new System.EventHandler(this.attributesBTN_Click);
            // 
            // tdevBTN
            // 
            this.tdevBTN.FlatAppearance.BorderSize = 0;
            this.tdevBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tdevBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdevBTN.ForeColor = System.Drawing.Color.White;
            this.tdevBTN.Image = ((System.Drawing.Image)(resources.GetObject("tdevBTN.Image")));
            this.tdevBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tdevBTN.Location = new System.Drawing.Point(12, 205);
            this.tdevBTN.Name = "tdevBTN";
            this.tdevBTN.Size = new System.Drawing.Size(197, 54);
            this.tdevBTN.TabIndex = 4;
            this.tdevBTN.Text = "       TDEV";
            this.tdevBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tdevBTN.UseVisualStyleBackColor = true;
            this.tdevBTN.Click += new System.EventHandler(this.tdevBTN_Click);
            // 
            // effortBTN
            // 
            this.effortBTN.FlatAppearance.BorderSize = 0;
            this.effortBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effortBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effortBTN.ForeColor = System.Drawing.Color.White;
            this.effortBTN.Image = ((System.Drawing.Image)(resources.GetObject("effortBTN.Image")));
            this.effortBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.effortBTN.Location = new System.Drawing.Point(12, 132);
            this.effortBTN.Name = "effortBTN";
            this.effortBTN.Size = new System.Drawing.Size(197, 54);
            this.effortBTN.TabIndex = 4;
            this.effortBTN.Text = "       Effort";
            this.effortBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.effortBTN.UseVisualStyleBackColor = true;
            this.effortBTN.Click += new System.EventHandler(this.effortBTN_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.FlatAppearance.BorderSize = 0;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBTN.ForeColor = System.Drawing.Color.White;
            this.homeBTN.Image = ((System.Drawing.Image)(resources.GetObject("homeBTN.Image")));
            this.homeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBTN.Location = new System.Drawing.Point(12, 59);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(197, 54);
            this.homeBTN.TabIndex = 4;
            this.homeBTN.Text = "       Home";
            this.homeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBTN.UseVisualStyleBackColor = true;
            this.homeBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 20);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "COCOMO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exitBTN
            // 
            this.exitBTN.FlatAppearance.BorderSize = 0;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.ForeColor = System.Drawing.Color.White;
            this.exitBTN.Image = ((System.Drawing.Image)(resources.GetObject("exitBTN.Image")));
            this.exitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBTN.Location = new System.Drawing.Point(982, 27);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(32, 35);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // intermediatePanel
            // 
            this.intermediatePanel.Location = new System.Drawing.Point(209, 160);
            this.intermediatePanel.Name = "intermediatePanel";
            this.intermediatePanel.Size = new System.Drawing.Size(817, 423);
            this.intermediatePanel.TabIndex = 11;
            // 
            // homePanel
            // 
            this.homePanel.Location = new System.Drawing.Point(209, 160);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(817, 423);
            this.homePanel.TabIndex = 8;
            // 
            // tdevPanel
            // 
            this.tdevPanel.Location = new System.Drawing.Point(209, 160);
            this.tdevPanel.Name = "tdevPanel";
            this.tdevPanel.Size = new System.Drawing.Size(817, 423);
            this.tdevPanel.TabIndex = 7;
            // 
            // effortPanel
            // 
            this.effortPanel.Location = new System.Drawing.Point(209, 160);
            this.effortPanel.Name = "effortPanel";
            this.effortPanel.Size = new System.Drawing.Size(817, 423);
            this.effortPanel.TabIndex = 5;
            // 
            // costDriverPanel
            // 
            this.costDriverPanel.Location = new System.Drawing.Point(209, 159);
            this.costDriverPanel.Name = "costDriverPanel";
            this.costDriverPanel.Size = new System.Drawing.Size(950, 423);
            this.costDriverPanel.TabIndex = 9;
            // 
            // teamPanel
            // 
            this.teamPanel.Location = new System.Drawing.Point(209, 160);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(817, 423);
            this.teamPanel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.tdevPanel);
            this.Controls.Add(this.effortPanel);
            this.Controls.Add(this.costDriverPanel);
            this.Controls.Add(this.teamPanel);
            this.Controls.Add(this.intermediatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button attributesBTN;
        private System.Windows.Forms.Button tdevBTN;
        private System.Windows.Forms.Button effortBTN;
        private System.Windows.Forms.Button button14;
        private Controls.Effort effortPanel;
        private System.Windows.Forms.Button exitBTN;
        private Controls.TDEV tdevPanel;
        private Controls.Home homePanel;
        private Controls.CostDriver costDriverPanel;
        private Controls.Team teamPanel;
        private System.Windows.Forms.Button intermediateBTN;
        private Controls.Intermediate intermediatePanel;
    }
}

