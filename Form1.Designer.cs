namespace BibliotecaRemake
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuario = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEmprestimo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFuncionario = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLivro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnPrincipal = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLivro = new System.Windows.Forms.TabPage();
            this.tpFuncionario = new System.Windows.Forms.TabPage();
            this.tpEmprestimo = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tcControle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnUsuario, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEmprestimo, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFuncionario, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLivro, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrincipal, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Animated = true;
            this.btnUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(619, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(148, 20);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "😀Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Animated = true;
            this.btnEmprestimo.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmprestimo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnEmprestimo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmprestimo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmprestimo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEmprestimo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimo.Location = new System.Drawing.Point(465, 3);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(148, 20);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.Text = "✔️ Emprestimo";
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Animated = true;
            this.btnFuncionario.BorderColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnFuncionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFuncionario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFuncionario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Location = new System.Drawing.Point(311, 3);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(148, 20);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "🙍Funcionário";
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Animated = true;
            this.btnLivro.BorderColor = System.Drawing.Color.Transparent;
            this.btnLivro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLivro.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnLivro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLivro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLivro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLivro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLivro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLivro.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLivro.ForeColor = System.Drawing.Color.White;
            this.btnLivro.Location = new System.Drawing.Point(157, 3);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(148, 20);
            this.btnLivro.TabIndex = 2;
            this.btnLivro.Text = "📔 Livros";
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Animated = true;
            this.btnPrincipal.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrincipal.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnPrincipal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrincipal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrincipal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrincipal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrincipal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnPrincipal.ForeColor = System.Drawing.Color.Black;
            this.btnPrincipal.Location = new System.Drawing.Point(3, 3);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(148, 20);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "🏠 Home";
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.tpTelaPrincipal);
            this.tcControle.Controls.Add(this.tpLivro);
            this.tcControle.Controls.Add(this.tpFuncionario);
            this.tcControle.Controls.Add(this.tpEmprestimo);
            this.tcControle.Controls.Add(this.tpUsuarios);
            this.tcControle.Depth = 0;
            this.tcControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControle.Location = new System.Drawing.Point(3, 35);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(770, 460);
            this.tcControle.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpTelaPrincipal.Controls.Add(this.panel1);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 25);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(762, 431);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 425);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 425);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja bem-vindo ao NossaBiblioteca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpLivro
            // 
            this.tpLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpLivro.Location = new System.Drawing.Point(4, 25);
            this.tpLivro.Name = "tpLivro";
            this.tpLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivro.Size = new System.Drawing.Size(762, 431);
            this.tpLivro.TabIndex = 2;
            this.tpLivro.Text = "Livro";
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpFuncionario.Location = new System.Drawing.Point(4, 25);
            this.tpFuncionario.Name = "tpFuncionario";
            this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionario.Size = new System.Drawing.Size(762, 431);
            this.tpFuncionario.TabIndex = 3;
            this.tpFuncionario.Text = "Funcionario";
            // 
            // tpEmprestimo
            // 
            this.tpEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpEmprestimo.Location = new System.Drawing.Point(4, 25);
            this.tpEmprestimo.Name = "tpEmprestimo";
            this.tpEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimo.Size = new System.Drawing.Size(762, 431);
            this.tpEmprestimo.TabIndex = 4;
            this.tpEmprestimo.Text = "Emprestimo";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(762, 431);
            this.tpUsuarios.TabIndex = 5;
            this.tpUsuarios.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(776, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tcControle.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPrincipal;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEmprestimo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnFuncionario;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLivro;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnUsuario;
        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage tpTelaPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLivro;
        private System.Windows.Forms.TabPage tpFuncionario;
        private System.Windows.Forms.TabPage tpEmprestimo;
        private System.Windows.Forms.TabPage tpUsuarios;
    }
}

