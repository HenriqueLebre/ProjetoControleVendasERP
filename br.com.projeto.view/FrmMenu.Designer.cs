namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProdutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.horaatual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.MenuFuncionarios,
            this.MenuFornecedores,
            this.MenuProdutos,
            this.MenuVendas,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCliente
            // 
            this.MenuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.consultaDeClientesToolStripMenuItem});
            this.MenuCliente.Image = global::ProjetoControleVendas.Properties.Resources.clientes;
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(77, 20);
            this.MenuCliente.Text = "Clientes";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaDeClientesToolStripMenuItem.Text = "Consulta de Clientes";
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFuncionáriosToolStripMenuItem,
            this.consultaDeFuncionáriosToolStripMenuItem});
            this.MenuFuncionarios.Image = global::ProjetoControleVendas.Properties.Resources.funcionarios;
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(103, 20);
            this.MenuFuncionarios.Text = "Funcionários";
            // 
            // cadastroDeFuncionáriosToolStripMenuItem
            // 
            this.cadastroDeFuncionáriosToolStripMenuItem.Name = "cadastroDeFuncionáriosToolStripMenuItem";
            this.cadastroDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de funcionários";
            // 
            // consultaDeFuncionáriosToolStripMenuItem
            // 
            this.consultaDeFuncionáriosToolStripMenuItem.Name = "consultaDeFuncionáriosToolStripMenuItem";
            this.consultaDeFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.consultaDeFuncionáriosToolStripMenuItem.Text = "Consulta de funcionários";
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFornecedoresToolStripMenuItem,
            this.consultaDeFornecedoresToolStripMenuItem});
            this.MenuFornecedores.Image = global::ProjetoControleVendas.Properties.Resources.entregador;
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(106, 20);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de fornecedores";
            // 
            // consultaDeFornecedoresToolStripMenuItem
            // 
            this.consultaDeFornecedoresToolStripMenuItem.Name = "consultaDeFornecedoresToolStripMenuItem";
            this.consultaDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultaDeFornecedoresToolStripMenuItem.Text = "Consulta de fornecedores";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeProdutosToolStripMenuItem,
            this.consultaDeProdutosToolStripMenuItem1});
            this.MenuProdutos.Image = global::ProjetoControleVendas.Properties.Resources.produtos;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(83, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // consultaDeProdutosToolStripMenuItem
            // 
            this.consultaDeProdutosToolStripMenuItem.Name = "consultaDeProdutosToolStripMenuItem";
            this.consultaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultaDeProdutosToolStripMenuItem.Text = "Cadastro de produtos";
            this.consultaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProdutosToolStripMenuItem_Click);
            // 
            // consultaDeProdutosToolStripMenuItem1
            // 
            this.consultaDeProdutosToolStripMenuItem1.Name = "consultaDeProdutosToolStripMenuItem1";
            this.consultaDeProdutosToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.consultaDeProdutosToolStripMenuItem1.Text = "Consulta de produtos";
            // 
            // MenuVendas
            // 
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.históricoDeVendasToolStripMenuItem});
            this.MenuVendas.Image = global::ProjetoControleVendas.Properties.Resources.vendas;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(72, 20);
            this.MenuVendas.Text = "Vendas";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova venda";
            // 
            // históricoDeVendasToolStripMenuItem
            // 
            this.históricoDeVendasToolStripMenuItem.Name = "históricoDeVendasToolStripMenuItem";
            this.históricoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.históricoDeVendasToolStripMenuItem.Text = "Histórico de vendas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarUsuárioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Image = global::ProjetoControleVendas.Properties.Resources.configuracoes;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trocarUsuárioToolStripMenuItem.Text = "Trocar usuário";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.horaatual,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel1.Text = "Data Atual";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(127, 17);
            this.txtdata.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel3.Text = "Hora atual";
            // 
            // horaatual
            // 
            this.horaatual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaatual.Name = "horaatual";
            this.horaatual.Size = new System.Drawing.Size(127, 17);
            this.horaatual.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel5.Text = "Usuário:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(127, 17);
            this.txtusuario.Text = "toolStripStatusLabel6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoControleVendas.Properties.Resources.icons8_lebre_48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(601, 533);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProdutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        public System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionáriosToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        public System.Windows.Forms.ToolStripStatusLabel horaatual;
        public System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.Timer timer1;
    }
}