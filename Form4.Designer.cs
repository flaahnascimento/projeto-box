namespace projeto_tutorial
{
    partial class Form4
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
            this.rbrefri = new System.Windows.Forms.RadioButton();
            this.rbborda = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btncalcule = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbrefri
            // 
            this.rbrefri.AutoSize = true;
            this.rbrefri.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbrefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbrefri.Location = new System.Drawing.Point(69, 176);
            this.rbrefri.Name = "rbrefri";
            this.rbrefri.Size = new System.Drawing.Size(147, 20);
            this.rbrefri.TabIndex = 29;
            this.rbrefri.TabStop = true;
            this.rbrefri.Text = "PEPSI OU DOLLY";
            this.rbrefri.UseVisualStyleBackColor = false;
            // 
            // rbborda
            // 
            this.rbborda.AutoSize = true;
            this.rbborda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbborda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbborda.Location = new System.Drawing.Point(69, 150);
            this.rbborda.Name = "rbborda";
            this.rbborda.Size = new System.Drawing.Size(195, 20);
            this.rbborda.TabIndex = 28;
            this.rbborda.TabStop = true;
            this.rbborda.Text = "BORDA COM CATUPIRY";
            this.rbborda.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Checkbox";
            // 
            // btncalcule
            // 
            this.btncalcule.BackColor = System.Drawing.SystemColors.Info;
            this.btncalcule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcule.Location = new System.Drawing.Point(95, 218);
            this.btncalcule.Name = "btncalcule";
            this.btncalcule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btncalcule.Size = new System.Drawing.Size(121, 33);
            this.btncalcule.TabIndex = 25;
            this.btncalcule.Text = "CALCULE";
            this.btncalcule.UseVisualStyleBackColor = false;
            this.btncalcule.Click += new System.EventHandler(this.btncalcule_Click);
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(187, 96);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(75, 22);
            this.txtresult.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "PREÇO TOTAL";
            // 
            // txtpizza
            // 
            this.txtpizza.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpizza.Location = new System.Drawing.Point(47, 94);
            this.txtpizza.Name = "txtpizza";
            this.txtpizza.Size = new System.Drawing.Size(75, 22);
            this.txtpizza.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "PREÇO PIZZA";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpizza);
            this.Controls.Add(this.rbrefri);
            this.Controls.Add(this.rbborda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalcule);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbrefri;
        private System.Windows.Forms.RadioButton rbborda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncalcule;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpizza;
        private System.Windows.Forms.Label label2;
    }
}