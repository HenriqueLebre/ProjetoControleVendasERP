namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmFornecedores
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
            this.tabfornecedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnpesquisarcep = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabelafornecedor = new System.Windows.Forms.DataGridView();
            this.btnpesquisarCliente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtnomepesquisar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabfornecedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.tabfornecedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 442);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // tabfornecedor
            // 
            this.tabfornecedor.Controls.Add(this.tabPage1);
            this.tabfornecedor.Controls.Add(this.tabPage2);
            this.tabfornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabfornecedor.Location = new System.Drawing.Point(3, 127);
            this.tabfornecedor.Name = "tabfornecedor";
            this.tabfornecedor.SelectedIndex = 0;
            this.tabfornecedor.Size = new System.Drawing.Size(899, 312);
            this.tabfornecedor.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnpesquisarcep);
            this.tabPage1.Controls.Add(this.btneditar);
            this.tabPage1.Controls.Add(this.btnexcluir);
            this.tabPage1.Controls.Add(this.btnsalvar);
            this.tabPage1.Controls.Add(this.btnnovo);
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtcnpj);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnpesquisarcep
            // 
            this.btnpesquisarcep.BackColor = System.Drawing.Color.YellowGreen;
            this.btnpesquisarcep.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnpesquisarcep.Location = new System.Drawing.Point(671, 9);
            this.btnpesquisarcep.Name = "btnpesquisarcep";
            this.btnpesquisarcep.Size = new System.Drawing.Size(107, 31);
            this.btnpesquisarcep.TabIndex = 33;
            this.btnpesquisarcep.Text = "Pesquisar";
            this.btnpesquisarcep.UseVisualStyleBackColor = false;
            this.btnpesquisarcep.Click += new System.EventHandler(this.btnpesquisarcep_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Moccasin;
            this.btneditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btneditar.Location = new System.Drawing.Point(808, 238);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 30);
            this.btneditar.TabIndex = 32;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.DarkGray;
            this.btnexcluir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnexcluir.Location = new System.Drawing.Point(720, 238);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 30);
            this.btnexcluir.TabIndex = 31;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsalvar.Location = new System.Drawing.Point(618, 238);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 30);
            this.btnsalvar.TabIndex = 30;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnnovo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnnovo.Location = new System.Drawing.Point(514, 238);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 30);
            this.btnnovo.TabIndex = 29;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
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
            this.cbuf.Location = new System.Drawing.Point(548, 144);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(71, 25);
            this.cbuf.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(516, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcidade.Location = new System.Drawing.Point(702, 144);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(177, 23);
            this.txtcidade.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(635, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cidade:";
            // 
            // txtbairro
            // 
            this.txtbairro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtbairro.Location = new System.Drawing.Point(548, 112);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(331, 23);
            this.txtbairro.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(494, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Bairro:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcomplemento.Location = new System.Drawing.Point(702, 81);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(177, 23);
            this.txtcomplemento.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(588, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Complemento:";
            // 
            // txtnumero
            // 
            this.txtnumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtnumero.Location = new System.Drawing.Point(548, 81);
            this.txtnumero.Mask = "0000";
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(34, 23);
            this.txtnumero.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(478, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Número:";
            // 
            // txtendereco
            // 
            this.txtendereco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtendereco.Location = new System.Drawing.Point(548, 47);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(331, 23);
            this.txtendereco.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(469, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Endereço:";
            // 
            // txtcep
            // 
            this.txtcep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcep.Location = new System.Drawing.Point(548, 14);
            this.txtcep.Mask = "##-###-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(107, 23);
            this.txtcep.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(504, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "CEP:";
            // 
            // txtcelular
            // 
            this.txtcelular.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcelular.Location = new System.Drawing.Point(280, 149);
            this.txtcelular.Mask = "(00) 0 0000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(105, 23);
            this.txtcelular.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(219, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txttelefone.Location = new System.Drawing.Point(88, 149);
            this.txttelefone.Mask = "(00) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(107, 23);
            this.txttelefone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(10, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone:";
            // 
            // txtcnpj
            // 
            this.txtcnpj.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtcnpj.Location = new System.Drawing.Point(89, 115);
            this.txtcnpj.Mask = "##,###,###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(128, 23);
            this.txtcnpj.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(28, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNPJ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtemail.Location = new System.Drawing.Point(88, 85);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(297, 23);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(24, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txtnome
            // 
            this.txtnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtnome.Location = new System.Drawing.Point(88, 47);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(297, 23);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(23, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcodigo.Location = new System.Drawing.Point(88, 14);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(86, 23);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabelafornecedor);
            this.tabPage2.Controls.Add(this.btnpesquisarCliente);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.txtnomepesquisar);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabelafornecedor
            // 
            this.tabelafornecedor.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabelafornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelafornecedor.Location = new System.Drawing.Point(9, 47);
            this.tabelafornecedor.Name = "tabelafornecedor";
            this.tabelafornecedor.Size = new System.Drawing.Size(886, 240);
            this.tabelafornecedor.TabIndex = 38;
            this.tabelafornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelafornecedor_CellContentClick);
            // 
            // btnpesquisarCliente
            // 
            this.btnpesquisarCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnpesquisarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnpesquisarCliente.Location = new System.Drawing.Point(383, 9);
            this.btnpesquisarCliente.Name = "btnpesquisarCliente";
            this.btnpesquisarCliente.Size = new System.Drawing.Size(96, 32);
            this.btnpesquisarCliente.TabIndex = 37;
            this.btnpesquisarCliente.Text = "Pesquisar";
            this.btnpesquisarCliente.UseVisualStyleBackColor = false;
            this.btnpesquisarCliente.Click += new System.EventHandler(this.btnpesquisarCliente_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Moccasin;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(893, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 36;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Location = new System.Drawing.Point(805, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 35;
            this.button6.Text = "Excluir";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(703, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 32);
            this.button7.TabIndex = 34;
            this.button7.Text = "Salvar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.Location = new System.Drawing.Point(599, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 33;
            this.button8.Text = "Novo";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // txtnomepesquisar
            // 
            this.txtnomepesquisar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtnomepesquisar.Location = new System.Drawing.Point(71, 12);
            this.txtnomepesquisar.Name = "txtnomepesquisar";
            this.txtnomepesquisar.Size = new System.Drawing.Size(297, 27);
            this.txtnomepesquisar.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 21);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // FrmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 442);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFornecedores";
            this.Text = "Cadastro de Fornecedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabfornecedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelafornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabfornecedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnpesquisarcep;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tabelafornecedor;
        private System.Windows.Forms.Button btnpesquisarCliente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtnomepesquisar;
        private System.Windows.Forms.Label label16;
    }
}