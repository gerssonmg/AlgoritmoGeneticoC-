namespace AlgoritmoGenetico
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
            this.txtIndividuo = new System.Windows.Forms.RichTextBox();
            this.btbGerar = new System.Windows.Forms.Button();
            this.txtPopulacao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtIndividuo
            // 
            this.txtIndividuo.Location = new System.Drawing.Point(12, 50);
            this.txtIndividuo.Name = "txtIndividuo";
            this.txtIndividuo.Size = new System.Drawing.Size(1440, 123);
            this.txtIndividuo.TabIndex = 0;
            this.txtIndividuo.Text = "";
            // 
            // btbGerar
            // 
            this.btbGerar.Location = new System.Drawing.Point(388, 12);
            this.btbGerar.Name = "btbGerar";
            this.btbGerar.Size = new System.Drawing.Size(89, 32);
            this.btbGerar.TabIndex = 1;
            this.btbGerar.Text = "Gerar";
            this.btbGerar.UseVisualStyleBackColor = true;
            this.btbGerar.Click += new System.EventHandler(this.btbGerar_Click);
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(12, 193);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(1440, 353);
            this.txtPopulacao.TabIndex = 2;
            this.txtPopulacao.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 558);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.btbGerar);
            this.Controls.Add(this.txtIndividuo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIndividuo;
        private System.Windows.Forms.Button btbGerar;
        private System.Windows.Forms.RichTextBox txtPopulacao;
    }
}

