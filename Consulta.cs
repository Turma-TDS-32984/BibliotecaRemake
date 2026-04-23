using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BibliotecaRemake.BibliotecaDBDataSet;

namespace BibliotecaRemake
{
    public partial class Consulta : UserControl
    {
        public Consulta()
        {
            InitializeComponent();
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboConsulta.Items.AddRange(requisicoes.GetData().ToArray());
        }

        private void lboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequisicoesRow requisicao = lboConsulta.SelectedItem as RequisicoesRow;
            if (requisicao == null) return;
            lblDataDeEmprestimo.Text = requisicao.DataRequisicao.ToString();
            lblDataDeDevolucao.Text = requisicao.Devolucao;
            lblStatus.Text = requisicao.Status;
            LivrosTableAdapter livros = new LivrosTableAdapter();
            LivrosRow livro = (from linha in livros.GetData() 
                              where linha.LivroID == requisicao.LivroID
                              select linha).FirstOrDefault();
            if (livro == null) return;
            lblTitulo.Text = livro.Titulo;
            FuncionariosTableAdapter funcionarios = new FuncionariosTableAdapter();
            FuncionariosRow funcionario = (from linha in funcionarios.GetData()
                                            where linha.FuncionarioID == requisicao.FuncionarioID
                                            select linha).FirstOrDefault();
            if (funcionario == null) return;
            lblFuncionario.Text = funcionario.NomeCompleto;
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            UsuariosRow usuario = (from linha in usuarios.GetData()
                                   where linha.UsuarioID == requisicao.UsuarioID
                                   select linha).FirstOrDefault();
            if (usuario == null) return;
            lblUsuario.Text = usuario.Nome;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtLivro.Text == "")
            {
                RequisicoesTableAdapter dados = new RequisicoesTableAdapter();
                lboConsulta.Items.AddRange(dados.GetData().ToArray());
                return;
            }
            RequisicoesTableAdapter requisicoes = new RequisicoesTableAdapter();
            lboConsulta.Items.Clear();
            var dadosExtraidos = from linha in requisicoes.GetData()
            where requisicoes.ToString().ToLower().Contains(txtLivro.Text.ToLower())
            select linha;
            foreach (var item in dadosExtraidos) lboConsulta.Items.Add(item);

        }
    }
}
