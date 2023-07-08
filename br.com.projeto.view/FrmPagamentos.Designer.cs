namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmPagamentos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textdinheiro = new System.Windows.Forms.TextBox();
            this.txtdinheiro = new System.Windows.Forms.Label();
            this.textCartao = new System.Windows.Forms.TextBox();
            this.txtcartao = new System.Windows.Forms.Label();
            this.textpix = new System.Windows.Forms.TextBox();
            this.txtpix = new System.Windows.Forms.Label();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Obs = new System.Windows.Forms.GroupBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.Obs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 148);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // textdinheiro
            // 
            this.textdinheiro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textdinheiro.Location = new System.Drawing.Point(115, 170);
            this.textdinheiro.Name = "textdinheiro";
            this.textdinheiro.Size = new System.Drawing.Size(135, 20);
            this.textdinheiro.TabIndex = 44;
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.AutoSize = true;
            this.txtdinheiro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdinheiro.Location = new System.Drawing.Point(37, 173);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(72, 13);
            this.txtdinheiro.TabIndex = 43;
            this.txtdinheiro.Text = "Dinheiro (R$):";
            // 
            // textCartao
            // 
            this.textCartao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textCartao.Location = new System.Drawing.Point(115, 209);
            this.textCartao.Name = "textCartao";
            this.textCartao.Size = new System.Drawing.Size(135, 20);
            this.textCartao.TabIndex = 46;
            // 
            // txtcartao
            // 
            this.txtcartao.AutoSize = true;
            this.txtcartao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtcartao.Location = new System.Drawing.Point(37, 212);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(64, 13);
            this.txtcartao.TabIndex = 45;
            this.txtcartao.Text = "Cartão (R$):";
            // 
            // textpix
            // 
            this.textpix.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textpix.Location = new System.Drawing.Point(115, 251);
            this.textpix.Name = "textpix";
            this.textpix.Size = new System.Drawing.Size(135, 20);
            this.textpix.TabIndex = 48;
            // 
            // txtpix
            // 
            this.txtpix.AutoSize = true;
            this.txtpix.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtpix.Location = new System.Drawing.Point(54, 254);
            this.txtpix.Name = "txtpix";
            this.txtpix.Size = new System.Drawing.Size(47, 13);
            this.txtpix.TabIndex = 47;
            this.txtpix.Text = "Pix (R$):";
            // 
            // texttotal
            // 
            this.texttotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.texttotal.Location = new System.Drawing.Point(115, 343);
            this.texttotal.Name = "texttotal";
            this.texttotal.ReadOnly = true;
            this.texttotal.Size = new System.Drawing.Size(135, 20);
            this.texttotal.TabIndex = 50;
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txttotal.Location = new System.Drawing.Point(54, 346);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(57, 13);
            this.txttotal.TabIndex = 49;
            this.txttotal.Text = "Total (R$):";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnfinalizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnfinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnfinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfinalizar.Location = new System.Drawing.Point(12, 511);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(314, 38);
            this.btnfinalizar.TabIndex = 51;
            this.btnfinalizar.Text = "Finalizar Pagamento";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // txttroco
            // 
            this.txttroco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttroco.Location = new System.Drawing.Point(115, 292);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(135, 20);
            this.txttroco.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(54, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Troco:";
            // 
            // Obs
            // 
            this.Obs.Controls.Add(this.txtobs);
            this.Obs.Location = new System.Drawing.Point(13, 369);
            this.Obs.Name = "Obs";
            this.Obs.Size = new System.Drawing.Size(313, 136);
            this.Obs.TabIndex = 54;
            this.Obs.TabStop = false;
            this.Obs.Text = "Observações";
            // 
            // txtobs
            // 
            this.txtobs.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtobs.Location = new System.Drawing.Point(6, 18);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(301, 112);
            this.txtobs.TabIndex = 45;
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 561);
            this.Controls.Add(this.Obs);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.textpix);
            this.Controls.Add(this.txtpix);
            this.Controls.Add(this.textCartao);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.textdinheiro);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPagamentos";
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FrmPagamentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Obs.ResumeLayout(false);
            this.Obs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textdinheiro;
        private System.Windows.Forms.Label txtdinheiro;
        private System.Windows.Forms.TextBox textCartao;
        private System.Windows.Forms.Label txtcartao;
        private System.Windows.Forms.TextBox textpix;
        private System.Windows.Forms.Label txtpix;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.GroupBox Obs;
        private System.Windows.Forms.TextBox txtobs;
    }
}