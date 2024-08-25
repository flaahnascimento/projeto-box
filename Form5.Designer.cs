namespace projeto_tutorial
{
    partial class Form5
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
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.cbcidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnescolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbestado
            // 
            this.cbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "sao pauo",
            "rio de janeiro",
            "salvador"});
            this.cbestado.Location = new System.Drawing.Point(146, 134);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(139, 32);
            this.cbestado.TabIndex = 0;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // cbcidade
            // 
            this.cbcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcidade.FormattingEnabled = true;
            this.cbcidade.Items.AddRange(new object[] {
            "ferraz de vasconcelos",
            "poa",
            "niteroi",
            "nova iguaçu",
            "itaparica",
            "vera cruz"});
            this.cbcidade.Location = new System.Drawing.Point(146, 194);
            this.cbcidade.Name = "cbcidade";
            this.cbcidade.Size = new System.Drawing.Size(142, 32);
            this.cbcidade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "CIDADE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "ESTADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Combobox";
            // 
            // btnescolha
            // 
            this.btnescolha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnescolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnescolha.Location = new System.Drawing.Point(291, 162);
            this.btnescolha.Name = "btnescolha";
            this.btnescolha.Size = new System.Drawing.Size(123, 32);
            this.btnescolha.TabIndex = 35;
            this.btnescolha.Text = "ESCOLHER";
            this.btnescolha.UseVisualStyleBackColor = false;
            this.btnescolha.Click += new System.EventHandler(this.btnescolha_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto_tutorial.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(417, 256);
            this.Controls.Add(this.btnescolha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbcidade);
            this.Controls.Add(this.cbestado);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ComboBox cbcidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnescolha;
    }
}