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
            this.solveBTN = new System.Windows.Forms.Button();
            this.inputSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeDDL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // solveBTN
            // 
            this.solveBTN.Location = new System.Drawing.Point(248, 241);
            this.solveBTN.Name = "solveBTN";
            this.solveBTN.Size = new System.Drawing.Size(75, 23);
            this.solveBTN.TabIndex = 0;
            this.solveBTN.Text = "OK";
            this.solveBTN.UseVisualStyleBackColor = true;
            this.solveBTN.Click += new System.EventHandler(this.solveBTN_Click);
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(238, 123);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(100, 20);
            this.inputSize.TabIndex = 1;
            this.inputSize.TextChanged += new System.EventHandler(this.inputSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Size:";
            // 
            // typeDDL
            // 
            this.typeDDL.FormattingEnabled = true;
            this.typeDDL.Items.AddRange(new object[] {
            "Organic",
            "Semi-Detached",
            "Embeded"});
            this.typeDDL.Location = new System.Drawing.Point(229, 175);
            this.typeDDL.Name = "typeDDL";
            this.typeDDL.Size = new System.Drawing.Size(121, 21);
            this.typeDDL.TabIndex = 3;
            this.typeDDL.SelectedIndexChanged += new System.EventHandler(this.typeDDL_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 382);
            this.Controls.Add(this.typeDDL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.solveBTN);
            this.Name = "Form1";
            this.Text = "==";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solveBTN;
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeDDL;
    }
}

