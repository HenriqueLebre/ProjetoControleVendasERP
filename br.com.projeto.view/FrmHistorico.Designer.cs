namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmHistorico
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.dtfim = new System.Windows.Forms.DateTimePicker();
            this.dthistorico = new System.Windows.Forms.DataGridView();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dthistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 148);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.dtfim);
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(243, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data Fim:";
            // 
            // dtinicio
            // 
            this.dtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicio.Location = new System.Drawing.Point(93, 23);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(111, 24);
            this.dtinicio.TabIndex = 19;
            // 
            // dtfim
            // 
            this.dtfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfim.Location = new System.Drawing.Point(321, 22);
            this.dtfim.Name = "dtfim";
            this.dtfim.Size = new System.Drawing.Size(118, 24);
            this.dtfim.TabIndex = 20;
            // 
            // dthistorico
            // 
            this.dthistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dthistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colData,
            this.colCliente,
            this.colTotal,
            this.colObs});
            this.dthistorico.Location = new System.Drawing.Point(12, 262);
            this.dthistorico.Name = "dthistorico";
            this.dthistorico.Size = new System.Drawing.Size(694, 176);
            this.dthistorico.TabIndex = 5;
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.YellowGreen;
            this.btpesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btpesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btpesquisar.Location = new System.Drawing.Point(527, 45);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(124, 30);
            this.btpesquisar.TabIndex = 31;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código";
            this.colCod.Name = "colCod";
            this.colCod.Width = 50;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data da Venda";
            this.colData.Name = "colData";
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 200;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colObs
            // 
            this.colObs.HeaderText = "Observação";
            this.colObs.Name = "colObs";
            this.colObs.Width = 200;
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.dthistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistorico";
            this.Text = "Histórico de Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dthistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtfim;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dthistorico;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
    }
}