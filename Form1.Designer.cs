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
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.tpTelaPrincipal = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLivro = new System.Windows.Forms.TabPage();
            this.tpFuncionario = new System.Windows.Forms.TabPage();
            this.tpEmprestimo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tcEmprestimo = new MaterialSkin.Controls.MaterialTabControl();
            this.tpEPrincipal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tpEmprestando = new System.Windows.Forms.TabPage();
            this.tpDevolvendo = new System.Windows.Forms.TabPage();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUsuario = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEmprestimo = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnFuncionario = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLivro = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnPrincipal = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcControle.SuspendLayout();
            this.tpTelaPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpEmprestimo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tcEmprestimo.SuspendLayout();
            this.tpEPrincipal.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tcControle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 562);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tcControle
            // 
            this.tcControle.Controls.Add(this.tpTelaPrincipal);
            this.tcControle.Controls.Add(this.tpLivro);
            this.tcControle.Controls.Add(this.tpFuncionario);
            this.tcControle.Controls.Add(this.tpEmprestimo);
            this.tcControle.Controls.Add(this.tabPage4);
            this.tcControle.Depth = 0;
            this.tcControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControle.Location = new System.Drawing.Point(3, 35);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(779, 665);
            this.tcControle.TabIndex = 0;
            // 
            // tpTelaPrincipal
            // 
            this.tpTelaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpTelaPrincipal.Controls.Add(this.panel1);
            this.tpTelaPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpTelaPrincipal.Name = "tpTelaPrincipal";
            this.tpTelaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelaPrincipal.Size = new System.Drawing.Size(771, 639);
            this.tpTelaPrincipal.TabIndex = 0;
            this.tpTelaPrincipal.Text = "Tela Principal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 633);
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
            this.label1.Size = new System.Drawing.Size(765, 633);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja bem-vindo ao NossaBiblioteca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpLivro
            // 
            this.tpLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpLivro.Location = new System.Drawing.Point(4, 22);
            this.tpLivro.Name = "tpLivro";
            this.tpLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tpLivro.Size = new System.Drawing.Size(771, 639);
            this.tpLivro.TabIndex = 2;
            this.tpLivro.Text = "Livro";
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tpFuncionario.Name = "tpFuncionario";
            this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionario.Size = new System.Drawing.Size(771, 639);
            this.tpFuncionario.TabIndex = 3;
            this.tpFuncionario.Text = "Funcionario";
            this.tpFuncionario.UseVisualStyleBackColor = true;
            // 
            // tpEmprestimo
            // 
            this.tpEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpEmprestimo.Controls.Add(this.tableLayoutPanel3);
            this.tpEmprestimo.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestimo.Name = "tpEmprestimo";
            this.tpEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestimo.Size = new System.Drawing.Size(771, 639);
            this.tpEmprestimo.TabIndex = 4;
            this.tpEmprestimo.Text = "Emprestimo";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tcEmprestimo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.897315F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.10268F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(765, 633);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tcEmprestimo
            // 
            this.tcEmprestimo.Controls.Add(this.tpEPrincipal);
            this.tcEmprestimo.Controls.Add(this.tpEmprestando);
            this.tcEmprestimo.Controls.Add(this.tpDevolvendo);
            this.tcEmprestimo.Controls.Add(this.tpConsultar);
            this.tcEmprestimo.Depth = 0;
            this.tcEmprestimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEmprestimo.Location = new System.Drawing.Point(3, 34);
            this.tcEmprestimo.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcEmprestimo.Name = "tcEmprestimo";
            this.tcEmprestimo.SelectedIndex = 0;
            this.tcEmprestimo.Size = new System.Drawing.Size(759, 596);
            this.tcEmprestimo.TabIndex = 0;
            // 
            // tpEPrincipal
            // 
            this.tpEPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tpEPrincipal.Controls.Add(this.label2);
            this.tpEPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpEPrincipal.Name = "tpEPrincipal";
            this.tpEPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpEPrincipal.Size = new System.Drawing.Size(751, 570);
            this.tpEPrincipal.TabIndex = 0;
            this.tpEPrincipal.Text = "Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione uma opção acima";
            // 
            // tpEmprestando
            // 
            this.tpEmprestando.BackColor = System.Drawing.Color.Black;
            this.tpEmprestando.Location = new System.Drawing.Point(4, 22);
            this.tpEmprestando.Name = "tpEmprestando";
            this.tpEmprestando.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmprestando.Size = new System.Drawing.Size(751, 570);
            this.tpEmprestando.TabIndex = 1;
            this.tpEmprestando.Text = "Emprestar";
            // 
            // tpDevolvendo
            // 
            this.tpDevolvendo.BackColor = System.Drawing.Color.Black;
            this.tpDevolvendo.Location = new System.Drawing.Point(4, 22);
            this.tpDevolvendo.Name = "tpDevolvendo";
            this.tpDevolvendo.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolvendo.Size = new System.Drawing.Size(751, 570);
            this.tpDevolvendo.TabIndex = 2;
            this.tpDevolvendo.Text = "Devolver";
            // 
            // tpConsultar
            // 
            this.tpConsultar.BackColor = System.Drawing.Color.Black;
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultar.Size = new System.Drawing.Size(751, 570);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnDevolver, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEmprestar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnEmprestimos, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSelecionar, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(759, 25);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.DimGray;
            this.btnDevolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(570, 3);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(186, 19);
            this.btnDevolver.TabIndex = 3;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.DimGray;
            this.btnEmprestar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmprestar.FlatAppearance.BorderSize = 0;
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestar.ForeColor = System.Drawing.Color.White;
            this.btnEmprestar.Location = new System.Drawing.Point(381, 3);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(183, 19);
            this.btnEmprestar.TabIndex = 2;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.DimGray;
            this.btnEmprestimos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmprestimos.FlatAppearance.BorderSize = 0;
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btnEmprestimos.Location = new System.Drawing.Point(192, 3);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(183, 19);
            this.btnEmprestimos.TabIndex = 1;
            this.btnEmprestimos.Text = "Consultar";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.DimGray;
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelecionar.FlatAppearance.BorderSize = 0;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(3, 3);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(183, 19);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(771, 639);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(779, 26);
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
            this.btnUsuario.Location = new System.Drawing.Point(623, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(153, 20);
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
            this.btnEmprestimo.Location = new System.Drawing.Point(468, 3);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(149, 20);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.Text = "✔️ Emprestimo";
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
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
            this.btnFuncionario.Location = new System.Drawing.Point(313, 3);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(149, 20);
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
            this.btnLivro.Location = new System.Drawing.Point(158, 3);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(149, 20);
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
            this.btnPrincipal.Size = new System.Drawing.Size(149, 20);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "🏠 Home";
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(785, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tcControle.ResumeLayout(false);
            this.tpTelaPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpEmprestimo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tcEmprestimo.ResumeLayout(false);
            this.tpEPrincipal.ResumeLayout(false);
            this.tpEPrincipal.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabControl tcEmprestimo;
        private System.Windows.Forms.TabPage tpEPrincipal;
        private System.Windows.Forms.TabPage tpEmprestando;
        private System.Windows.Forms.TabPage tpDevolvendo;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Label label2;
    }
}

