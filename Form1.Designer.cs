﻿namespace projeto_tutorial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.btnVerifiq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UMA COR:";
            // 
            // txtcor
            // 
            this.txtcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcor.Location = new System.Drawing.Point(186, 110);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(148, 29);
            this.txtcor.TabIndex = 1;
            // 
            // btnVerifiq
            // 
            this.btnVerifiq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerifiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifiq.Location = new System.Drawing.Point(219, 145);
            this.btnVerifiq.Name = "btnVerifiq";
            this.btnVerifiq.Size = new System.Drawing.Size(90, 43);
            this.btnVerifiq.TabIndex = 2;
            this.btnVerifiq.Text = "verificar";
            this.btnVerifiq.UseVisualStyleBackColor = false;
            this.btnVerifiq.Click += new System.EventHandler(this.btnVerifiq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto_tutorial.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(359, 252);
            this.Controls.Add(this.btnVerifiq);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Button btnVerifiq;
    }
}

