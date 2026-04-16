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
        public Form1()
        {
            InitializeComponent();
            
           
        }
        private void MudarCorDeButton()
        {
            btnLivro.FillColor = Color.FromArgb(60, 60, 60);
            btnLivro.ForeColor = Color.White;
            btnEmprestimo.FillColor = Color.FromArgb(60, 60, 60);
            btnEmprestimo.ForeColor = Color.White;
            btnFuncionario.FillColor = Color.FromArgb(60, 60, 60);
            btnFuncionario.ForeColor = Color.White;
            btnUsuario.FillColor = Color.FromArgb(60, 60, 60);
            btnUsuario.ForeColor = Color.White;
            btnPrincipal.FillColor = Color.FromArgb(60, 60, 60);
            btnPrincipal.ForeColor = Color.White;
        }
        private void VoltarTelaPrincipal(object quemChama, EventArgs evento)
        {
            tcControle.SelectTab(tpTelaPrincipal);
        }
        private void btnErro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpLivro);
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MudarCorDeButton();
            btnPrincipal.FillColor = Color.FromArgb(200, 200, 200);
            btnPrincipal.ForeColor = Color.FromArgb(0, 0, 0);
            tcControle.SelectTab(tpTelaPrincipal);
            
        }
       

        private void btnLivro_Click(object sender, EventArgs e)
        {
            MudarCorDeButton();
            btnLivro.FillColor = Color.FromArgb(200, 200, 200);
            btnLivro.ForeColor = Color.FromArgb(0, 0, 0);
            tcControle.SelectTab(tpLivro);
            livros = new Livros();
            livros.Dock = DockStyle.Fill;
            tpLivro.Controls.Add(livros);
            //Localiza o botao btnErro, verifica se existe, se existir, retorna o primeiro e adiciona a funçao de click
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MudarCorDeButton();
            btnUsuario.FillColor = Color.FromArgb(200, 200, 200);
            btnUsuario.ForeColor = Color.FromArgb(0, 0, 0);
            tcControle.SelectTab(tpUsuarios);
            usuarios = new Usuarios();
            usuarios.Dock = DockStyle.Fill;
            tpUsuarios.Controls.Add(usuarios);
        }
    }
}
