namespace BibliotecaRemake
{
    partial class Consulta
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboConsulta = new System.Windows.Forms.ListBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataDeEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDeDevolucao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboConsulta
            // 
            this.lboConsulta.FormattingEnabled = true;
            this.lboConsulta.Location = new System.Drawing.Point(13, 66);
            this.lboConsulta.Name = "lboConsulta";
            this.lboConsulta.Size = new System.Drawing.Size(206, 238);
            this.lboConsulta.TabIndex = 0;
            this.lboConsulta.SelectedIndexChanged += new System.EventHandler(this.lboConsulta_SelectedIndexChanged);
            // 
            // txtLivro
            // 
            this.txtLivro.Location = new System.Drawing.Point(13, 23);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(206, 20);
            this.txtLivro.TabIndex = 1;
            this.txtLivro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um livro para consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione um livro para consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dados para consultar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(236, 66);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(236, 83);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 6;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(236, 97);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblDataDeEmprestimo
            // 
            this.lblDataDeEmprestimo.AutoSize = true;
            this.lblDataDeEmprestimo.ForeColor = System.Drawing.Color.White;
            this.lblDataDeEmprestimo.Location = new System.Drawing.Point(236, 110);
            this.lblDataDeEmprestimo.Name = "lblDataDeEmprestimo";
            this.lblDataDeEmprestimo.Size = new System.Drawing.Size(102, 13);
            this.lblDataDeEmprestimo.TabIndex = 8;
            this.lblDataDeEmprestimo.Text = "Data de Emprestimo";
            // 
            // lblDataDeDevolucao
            // 
            this.lblDataDeDevolucao.AutoSize = true;
            this.lblDataDeDevolucao.ForeColor = System.Drawing.Color.White;
            this.lblDataDeDevolucao.Location = new System.Drawing.Point(236, 124);
            this.lblDataDeDevolucao.Name = "lblDataDeDevolucao";
            this.lblDataDeDevolucao.Size = new System.Drawing.Size(100, 13);
            this.lblDataDeDevolucao.TabIndex = 9;
            this.lblDataDeDevolucao.Text = "Data de Devolução";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(236, 141);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataDeDevolucao);
            this.Controls.Add(this.lblDataDeEmprestimo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.lboConsulta);
            this.Name = "Consulta";
            this.Size = new System.Drawing.Size(415, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboConsulta;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDataDeEmprestimo;
        private System.Windows.Forms.Label lblDataDeDevolucao;
        private System.Windows.Forms.Label lblStatus;
    }
}
