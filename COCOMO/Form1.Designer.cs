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
            this.inputSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeDDL = new System.Windows.Forms.ComboBox();
            this.calculatedEffort = new System.Windows.Forms.TextBox();
            this.effortBTN = new System.Windows.Forms.Button();
            this.tdevBTN = new System.Windows.Forms.Button();
            this.actualBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSize
            // 
            this.inputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSize.Location = new System.Drawing.Point(185, 82);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(158, 26);
            this.inputSize.TabIndex = 1;
            this.inputSize.TextChanged += new System.EventHandler(this.inputSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Size:";
            // 
            // typeDDL
            // 
            this.typeDDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDDL.FormattingEnabled = true;
            this.typeDDL.Items.AddRange(new object[] {
            "Organic",
            "Semi-Detached",
            "Embeded"});
            this.typeDDL.Location = new System.Drawing.Point(185, 136);
            this.typeDDL.Name = "typeDDL";
            this.typeDDL.Size = new System.Drawing.Size(158, 28);
            this.typeDDL.TabIndex = 3;
            this.typeDDL.SelectedIndexChanged += new System.EventHandler(this.typeDDL_SelectedIndexChanged);
            // 
            // calculatedEffort
            // 
            this.calculatedEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedEffort.Location = new System.Drawing.Point(185, 184);
            this.calculatedEffort.Name = "calculatedEffort";
            this.calculatedEffort.Size = new System.Drawing.Size(158, 26);
            this.calculatedEffort.TabIndex = 5;
            // 
            // effortBTN
            // 
            this.effortBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effortBTN.Location = new System.Drawing.Point(63, 247);
            this.effortBTN.Name = "effortBTN";
            this.effortBTN.Size = new System.Drawing.Size(129, 66);
            this.effortBTN.TabIndex = 6;
            this.effortBTN.Text = "Calculate Effort";
            this.effortBTN.UseVisualStyleBackColor = true;
            this.effortBTN.Click += new System.EventHandler(this.effortBTN_Click);
            // 
            // tdevBTN
            // 
            this.tdevBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdevBTN.Location = new System.Drawing.Point(204, 247);
            this.tdevBTN.Name = "tdevBTN";
            this.tdevBTN.Size = new System.Drawing.Size(138, 66);
            this.tdevBTN.TabIndex = 7;
            this.tdevBTN.Text = "Caculate TDEV";
            this.tdevBTN.UseVisualStyleBackColor = true;
            this.tdevBTN.Click += new System.EventHandler(this.tdevBTN_Click);
            // 
            // actualBTN
            // 
            this.actualBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualBTN.Location = new System.Drawing.Point(348, 247);
            this.actualBTN.Name = "actualBTN";
            this.actualBTN.Size = new System.Drawing.Size(138, 66);
            this.actualBTN.TabIndex = 8;
            this.actualBTN.Text = "Calculate Actual Effort";
            this.actualBTN.UseVisualStyleBackColor = true;
            this.actualBTN.Click += new System.EventHandler(this.actualBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 382);
            this.Controls.Add(this.actualBTN);
            this.Controls.Add(this.tdevBTN);
            this.Controls.Add(this.effortBTN);
            this.Controls.Add(this.calculatedEffort);
            this.Controls.Add(this.typeDDL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSize);
            this.Name = "Form1";
            this.Text = "==";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeDDL;
        private System.Windows.Forms.TextBox calculatedEffort;
        private System.Windows.Forms.Button effortBTN;
        private System.Windows.Forms.Button tdevBTN;
        private System.Windows.Forms.Button actualBTN;
    }
}

