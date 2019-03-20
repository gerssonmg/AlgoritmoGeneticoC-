namespace AlgoritmoGenetico
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.zedPopulacao = new ZedGraph.ZedGraphControl();
            this.zedMediaPopulacao = new ZedGraph.ZedGraphControl();
            this.txtMelhoresInd = new System.Windows.Forms.RichTextBox();
            this.txtPioresInd = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtIteracoes = new System.Windows.Forms.MaskedTextBox();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.btnIniciarAG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedPopulacao
            // 
            this.zedPopulacao.Location = new System.Drawing.Point(13, 99);
            this.zedPopulacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedPopulacao.Name = "zedPopulacao";
            this.zedPopulacao.ScrollGrace = 0D;
            this.zedPopulacao.ScrollMaxX = 0D;
            this.zedPopulacao.ScrollMaxY = 0D;
            this.zedPopulacao.ScrollMaxY2 = 0D;
            this.zedPopulacao.ScrollMinX = 0D;
            this.zedPopulacao.ScrollMinY = 0D;
            this.zedPopulacao.ScrollMinY2 = 0D;
            this.zedPopulacao.Size = new System.Drawing.Size(737, 431);
            this.zedPopulacao.TabIndex = 0;
            // 
            // zedMediaPopulacao
            // 
            this.zedMediaPopulacao.Location = new System.Drawing.Point(758, 99);
            this.zedMediaPopulacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedMediaPopulacao.Name = "zedMediaPopulacao";
            this.zedMediaPopulacao.ScrollGrace = 0D;
            this.zedMediaPopulacao.ScrollMaxX = 0D;
            this.zedMediaPopulacao.ScrollMaxY = 0D;
            this.zedMediaPopulacao.ScrollMaxY2 = 0D;
            this.zedMediaPopulacao.ScrollMinX = 0D;
            this.zedMediaPopulacao.ScrollMinY = 0D;
            this.zedMediaPopulacao.ScrollMinY2 = 0D;
            this.zedMediaPopulacao.Size = new System.Drawing.Size(712, 431);
            this.zedMediaPopulacao.TabIndex = 1;
            // 
            // txtMelhoresInd
            // 
            this.txtMelhoresInd.Location = new System.Drawing.Point(12, 575);
            this.txtMelhoresInd.Name = "txtMelhoresInd";
            this.txtMelhoresInd.Size = new System.Drawing.Size(738, 151);
            this.txtMelhoresInd.TabIndex = 2;
            this.txtMelhoresInd.Text = "";
            // 
            // txtPioresInd
            // 
            this.txtPioresInd.Location = new System.Drawing.Point(758, 575);
            this.txtPioresInd.Name = "txtPioresInd";
            this.txtPioresInd.Size = new System.Drawing.Size(712, 151);
            this.txtPioresInd.TabIndex = 3;
            this.txtPioresInd.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Melhores Indivíduos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piores Indivíduos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa de Crossover:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa de Mutação:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evoluções:";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(149, 4);
            this.txtTaxaCrossover.Mask = "0.00";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(50, 22);
            this.txtTaxaCrossover.TabIndex = 9;
            this.txtTaxaCrossover.Text = "080";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(149, 32);
            this.txtTaxaMutacao.Mask = "0.00";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(50, 22);
            this.txtTaxaMutacao.TabIndex = 10;
            this.txtTaxaMutacao.Text = "001";
            this.txtTaxaMutacao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtIteracoes
            // 
            this.txtIteracoes.Location = new System.Drawing.Point(149, 64);
            this.txtIteracoes.Mask = "00000";
            this.txtIteracoes.Name = "txtIteracoes";
            this.txtIteracoes.Size = new System.Drawing.Size(50, 22);
            this.txtIteracoes.TabIndex = 11;
            this.txtIteracoes.Text = "100";
            this.txtIteracoes.ValidatingType = typeof(int);
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Location = new System.Drawing.Point(232, 1);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(131, 46);
            this.btnCriarPop.TabIndex = 12;
            this.btnCriarPop.Text = "Criar População";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // btnIniciarAG
            // 
            this.btnIniciarAG.Location = new System.Drawing.Point(232, 51);
            this.btnIniciarAG.Name = "btnIniciarAG";
            this.btnIniciarAG.Size = new System.Drawing.Size(130, 45);
            this.btnIniciarAG.TabIndex = 13;
            this.btnIniciarAG.Text = "Executar AG";
            this.btnIniciarAG.UseVisualStyleBackColor = true;
            this.btnIniciarAG.Click += new System.EventHandler(this.btnIniciarAG_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 738);
            this.Controls.Add(this.btnIniciarAG);
            this.Controls.Add(this.btnCriarPop);
            this.Controls.Add(this.txtIteracoes);
            this.Controls.Add(this.txtTaxaMutacao);
            this.Controls.Add(this.txtTaxaCrossover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPioresInd);
            this.Controls.Add(this.txtMelhoresInd);
            this.Controls.Add(this.zedMediaPopulacao);
            this.Controls.Add(this.zedPopulacao);
            this.Name = "TelaPrincipal";
            this.Text = "Execução do Algoritmo Genético";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPopulacao;
        private ZedGraph.ZedGraphControl zedMediaPopulacao;
        private System.Windows.Forms.RichTextBox txtMelhoresInd;
        private System.Windows.Forms.RichTextBox txtPioresInd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtIteracoes;
        private System.Windows.Forms.Button btnCriarPop;
        private System.Windows.Forms.Button btnIniciarAG;
    }
}