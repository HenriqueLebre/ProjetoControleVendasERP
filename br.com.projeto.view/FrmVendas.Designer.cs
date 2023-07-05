namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnrmvitem = new System.Windows.Forms.Button();
            this.btnadditem = new System.Windows.Forms.Button();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.Produtos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qtdeitens = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpgto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Produtos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 148);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Controls.Add(this.cbuf);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtcep);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // txtcidade
            // 
            this.txtcidade.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcidade.Location = new System.Drawing.Point(71, 96);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(177, 20);
            this.txtcidade.TabIndex = 30;
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "RO",
            "BH",
            "BA",
            "RJ",
            "SP",
            "MT",
            "RS",
            "DF",
            "MG",
            "PA",
            "AM",
            "AC",
            "TO",
            "CE",
            "PB"});
            this.cbuf.Location = new System.Drawing.Point(237, 69);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(71, 21);
            this.cbuf.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(14, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cidade:";
            // 
            // txtcep
            // 
            this.txtcep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcep.Location = new System.Drawing.Point(71, 69);
            this.txtcep.Mask = "##-###-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(107, 20);
            this.txtcep.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(207, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "UF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(26, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "CEP:";
            // 
            // txtnome
            // 
            this.txtnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtnome.Location = new System.Drawing.Point(70, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(297, 20);
            this.txtnome.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcpf.Location = new System.Drawing.Point(70, 13);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(107, 20);
            this.txtcpf.TabIndex = 12;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(27, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrmvitem);
            this.groupBox2.Controls.Add(this.btnadditem);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Location = new System.Drawing.Point(13, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnrmvitem
            // 
            this.btnrmvitem.BackColor = System.Drawing.Color.DarkGray;
            this.btnrmvitem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnrmvitem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnrmvitem.Location = new System.Drawing.Point(244, 111);
            this.btnrmvitem.Name = "btnrmvitem";
            this.btnrmvitem.Size = new System.Drawing.Size(124, 30);
            this.btnrmvitem.TabIndex = 32;
            this.btnrmvitem.Text = "Remover Item";
            this.btnrmvitem.UseVisualStyleBackColor = false;
            // 
            // btnadditem
            // 
            this.btnadditem.BackColor = System.Drawing.Color.YellowGreen;
            this.btnadditem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnadditem.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnadditem.Location = new System.Drawing.Point(244, 79);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(124, 30);
            this.btnadditem.TabIndex = 30;
            this.btnadditem.Text = "Adcionar Item";
            this.btnadditem.UseVisualStyleBackColor = false;
            // 
            // txtqtd
            // 
            this.txtqtd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtqtd.Location = new System.Drawing.Point(71, 114);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(135, 20);
            this.txtqtd.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(30, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Qtde:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcodigo.Location = new System.Drawing.Point(71, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(86, 20);
            this.txtcodigo.TabIndex = 38;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtpreco
            // 
            this.txtpreco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtpreco.Location = new System.Drawing.Point(71, 83);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(135, 20);
            this.txtpreco.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(2, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Preço (R$):";
            // 
            // txtdesc
            // 
            this.txtdesc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtdesc.Location = new System.Drawing.Point(71, 53);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(297, 20);
            this.txtdesc.TabIndex = 40;
            // 
            // Produtos
            // 
            this.Produtos.AllowUserToAddRows = false;
            this.Produtos.AllowUserToDeleteRows = false;
            this.Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Produtos.Location = new System.Drawing.Point(393, 166);
            this.Produtos.Name = "Produtos";
            this.Produtos.ReadOnly = true;
            this.Produtos.Size = new System.Drawing.Size(405, 289);
            this.Produtos.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.total);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.qtdeitens);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(393, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 62);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totais";
            // 
            // total
            // 
            this.total.ForeColor = System.Drawing.SystemColors.InfoText;
            this.total.Location = new System.Drawing.Point(83, 13);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(85, 20);
            this.total.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(20, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total (R$):";
            // 
            // qtdeitens
            // 
            this.qtdeitens.ForeColor = System.Drawing.SystemColors.InfoText;
            this.qtdeitens.Location = new System.Drawing.Point(84, 39);
            this.qtdeitens.Name = "qtdeitens";
            this.qtdeitens.Size = new System.Drawing.Size(143, 20);
            this.qtdeitens.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(19, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Qtde Itens:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btncancelar.Location = new System.Drawing.Point(213, 478);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 38);
            this.btncancelar.TabIndex = 38;
            this.btncancelar.Text = "Cancelar Venda";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpgto
            // 
            this.btnpgto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnpgto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnpgto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnpgto.Location = new System.Drawing.Point(49, 478);
            this.btnpgto.Name = "btnpgto";
            this.btnpgto.Size = new System.Drawing.Size(130, 38);
            this.btnpgto.TabIndex = 37;
            this.btnpgto.Text = "Pagamento";
            this.btnpgto.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(153, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(108, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 14);
            this.label10.TabIndex = 39;
            this.label10.Text = "Data:";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 530);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnpgto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Produtos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Produtos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.Button btnrmvitem;
        private System.Windows.Forms.DataGridView Produtos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox qtdeitens;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpgto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
    }
}