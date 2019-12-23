namespace COCOMO.Controls
{
    partial class Intermediate
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
            this.actualEffortBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tdevBOX = new System.Windows.Forms.TextBox();
            this.eafBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actualEffortBox
            // 
            this.actualEffortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualEffortBox.Location = new System.Drawing.Point(430, 208);
            this.actualEffortBox.Name = "actualEffortBox";
            this.actualEffortBox.ReadOnly = true;
            this.actualEffortBox.Size = new System.Drawing.Size(195, 31);
            this.actualEffortBox.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(88)))), ((int)(((byte)(172)))));
            this.label5.Location = new System.Drawing.Point(192, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Calculating Actual Effort and TDEV depending on EAF!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(187, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 49);
            this.label3.TabIndex = 43;
            this.label3.Text = "Intermediate COCOMO";
            // 
            // calculateBTN
            // 
            this.calculateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.calculateBTN.FlatAppearance.BorderSize = 0;
            this.calculateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBTN.ForeColor = System.Drawing.Color.White;
            this.calculateBTN.Location = new System.Drawing.Point(286, 321);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(245, 43);
            this.calculateBTN.TabIndex = 42;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = false;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(191, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 40;
            this.label6.Text = "TDEV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(191, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Actual Effort";
            // 
            // tdevBOX
            // 
            this.tdevBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdevBOX.Location = new System.Drawing.Point(430, 264);
            this.tdevBOX.Name = "tdevBOX";
            this.tdevBOX.ReadOnly = true;
            this.tdevBOX.Size = new System.Drawing.Size(195, 31);
            this.tdevBOX.TabIndex = 38;
            // 
            // eafBOX
            // 
            this.eafBOX.AccessibleName = "";
            this.eafBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eafBOX.Location = new System.Drawing.Point(430, 152);
            this.eafBOX.Name = "eafBOX";
            this.eafBOX.ReadOnly = true;
            this.eafBOX.Size = new System.Drawing.Size(195, 31);
            this.eafBOX.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(78)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(191, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "EAF";
            // 
            // Intermediate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actualEffortBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tdevBOX);
            this.Controls.Add(this.eafBOX);
            this.Controls.Add(this.label4);
            this.Name = "Intermediate";
            this.Size = new System.Drawing.Size(817, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox actualEffortBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tdevBOX;
        public System.Windows.Forms.TextBox eafBOX;
        private System.Windows.Forms.Label label4;
    }
}
