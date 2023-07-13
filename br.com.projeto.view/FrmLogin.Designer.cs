namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class FrmLogin
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
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnesquecisenha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 148);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(178, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtcliente.Location = new System.Drawing.Point(128, 199);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(262, 31);
            this.txtcliente.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtemail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtemail.Location = new System.Drawing.Point(50, 202);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(78, 25);
            this.txtemail.TabIndex = 20;
            this.txtemail.Text = "E-mail:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox1.Location = new System.Drawing.Point(127, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '#';
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(262, 31);
            this.textBox1.TabIndex = 23;
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtsenha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtsenha.Location = new System.Drawing.Point(50, 250);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(80, 25);
            this.txtsenha.TabIndex = 22;
            this.txtsenha.Text = "Senha:";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnentrar.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.btnentrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnentrar.Location = new System.Drawing.Point(29, 389);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(144, 46);
            this.btnentrar.TabIndex = 32;
            this.btnentrar.Text = "Acessar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnesquecisenha
            // 
            this.btnesquecisenha.BackColor = System.Drawing.Color.Salmon;
            this.btnesquecisenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnesquecisenha.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.btnesquecisenha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnesquecisenha.Location = new System.Drawing.Point(264, 389);
            this.btnesquecisenha.Name = "btnesquecisenha";
            this.btnesquecisenha.Size = new System.Drawing.Size(181, 46);
            this.btnesquecisenha.TabIndex = 33;
            this.btnesquecisenha.Text = "Esqueci minha senha";
            this.btnesquecisenha.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 492);
            this.Controls.Add(this.btnesquecisenha);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label txtemail;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnesquecisenha;
    }
}