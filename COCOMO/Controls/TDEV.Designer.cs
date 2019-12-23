namespace COCOMO.Controls
{
    partial class TDEV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculatedTDEV = new System.Windows.Forms.TextBox();
            this.typeDDL = new System.Windows.Forms.ComboBox();
            this.inputSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(176, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(176, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Project Type";
            // 
            // calculatedTDEV
            // 
            this.calculatedTDEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedTDEV.Location = new System.Drawing.Point(415, 236);
            this.calculatedTDEV.Name = "calculatedTDEV";
            this.calculatedTDEV.Size = new System.Drawing.Size(195, 31);
            this.calculatedTDEV.TabIndex = 19;
            // 
            // typeDDL
            // 
            this.typeDDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDDL.FormattingEnabled = true;
            this.typeDDL.Items.AddRange(new object[] {
            "Organic",
            "Semi-Detached",
            "Embeded"});
            this.typeDDL.Location = new System.Drawing.Point(415, 184);
            this.typeDDL.Name = "typeDDL";
            this.typeDDL.Size = new System.Drawing.Size(195, 33);
            this.typeDDL.TabIndex = 18;
            this.typeDDL.SelectedIndexChanged += new System.EventHandler(this.typeDDL_SelectedIndexChanged);
            // 
            // inputSize
            // 
            this.inputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSize.Location = new System.Drawing.Point(415, 134);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(195, 31);
            this.inputSize.TabIndex = 17;
            this.inputSize.TextChanged += new System.EventHandler(this.inputSize_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(176, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Input Size";
            // 
            // calcBTN
            // 
            this.calcBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.calcBTN.FlatAppearance.BorderSize = 0;
            this.calcBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBTN.ForeColor = System.Drawing.Color.White;
            this.calcBTN.Location = new System.Drawing.Point(271, 321);
            this.calcBTN.Name = "calcBTN";
            this.calcBTN.Size = new System.Drawing.Size(245, 43);
            this.calcBTN.TabIndex = 22;
            this.calcBTN.Text = "Calculate";
            this.calcBTN.UseVisualStyleBackColor = false;
            this.calcBTN.Click += new System.EventHandler(this.calcBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(250, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 49);
            this.label3.TabIndex = 23;
            this.label3.Text = "Calcualte TDEV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(177, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Please enter KLOC and select project type\r\n";
            // 
            // TDEV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculatedTDEV);
            this.Controls.Add(this.typeDDL);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.label4);
            this.Name = "TDEV";
            this.Size = new System.Drawing.Size(817, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox calculatedTDEV;
        private System.Windows.Forms.ComboBox typeDDL;
        private System.Windows.Forms.TextBox inputSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
