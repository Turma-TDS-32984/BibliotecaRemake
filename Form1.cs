using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaRemake
{
    public partial class Form1 : Form
    {
        private Erros erros;
        private Livros livros;
        private Usuarios usuarios;
        private Funcionario funcionarios;
        public Form1()
        {
            InitializeComponent();// Remoção do Erros como controle para renderizar a tela principal,
                                  // para evitar o erro de controle já adicionado
            MudarCorDeBotoes();

            btnPrincipal.FillColor = Color.FromArgb(200, 200, 200);
            btnPrincipal.ForeColor = Color.Black;
        }

        private void VoltarTelaPrincipal(object quemChama, EventArgs evento)
        {
            tcControle.SelectTab(tpTelaPrincipal);
        }
        public void MudarCorDeBotoes()
        {
            Color corPadraoFundo = Color.FromArgb(20, 20, 20);
            Color corPadraoTexto = Color.White;
            btnPrincipal.FillColor = corPadraoFundo;
            btnPrincipal.ForeColor = corPadraoTexto;
            //btnPrincipal.BackColor = corPadraoTexto; para o btn do WinForms padrão
            btnLivro.FillColor = corPadraoFundo;
            btnLivro.ForeColor = corPadraoTexto;
            btnUsuario.FillColor = corPadraoFundo;
            btnUsuario.ForeColor = corPadraoTexto;
            btnFuncionario.FillColor = corPadraoFundo;
            btnFuncionario.ForeColor = corPadraoTexto;
            btnEmprestimo.FillColor = corPadraoFundo;
            btnEmprestimo.ForeColor = corPadraoTexto;

        }
        private void btnLivro_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((SiticoneButton)sender).FillColor = Color.FromArgb(200, 200, 200);
            btnLivro.ForeColor = Color.Black;
            if (livros != null)
                livros.Dispose();//Vou limpar todos os elementos
            livros = null; // Garantir que não exista mais referência ao controle antigo
            tpLivro.Controls.Clear(); // Limpar os controles do TabPage para evitar sobreposição
            livros = new Livros();// Crie um novo controle Livros
            //livros.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal; 
            tpLivro.Controls.Add(livros);// Adicione o novo controle ao TabPage
            tcControle.SelectTab(tpLivro); // Agora entro na aba de livros
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((SiticoneButton)sender).FillColor = Color.FromArgb(200, 200, 200);
            ((SiticoneButton)sender).ForeColor = Color.Black;
            tcControle.SelectTab(tpTelaPrincipal);
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MudarCorDeBotoes();
            ((SiticoneButton)sender).FillColor = Color.FromArgb(200, 200, 200);
            ((SiticoneButton)sender).ForeColor = Color.Black;
            if (usuarios != null)
                usuarios.Dispose();//Vou limpar todos os elementos
            usuarios = null; // Garantir que não exista mais referência ao controle antigo
            tpUsuarios.Controls.Clear(); // Limpar os controles do TabPage para evitar sobreposição
            usuarios = new Usuarios();// Crie um novo controle Usuarios
            //usuarios.Controls.Find("btnVoltar", true).First().Click += VoltarTelaPrincipal; 
            tpUsuarios.Controls.Add(usuarios);// Adicione o novo controle ao TabPage
            tcControle.SelectTab(tpUsuarios); // Agora entro na aba de usuários
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            //MudarCorDeButton();
            btnFuncionario.FillColor = Color.FromArgb(200, 200, 200);
            btnFuncionario.ForeColor = Color.FromArgb(0, 0, 0);
            tcControle.SelectTab(tpFuncionario);
            funcionarios = new Funcionario();
            funcionarios.Dock = DockStyle.Fill;
            tpFuncionario.Controls.Add(funcionarios);
        }
    }
}
