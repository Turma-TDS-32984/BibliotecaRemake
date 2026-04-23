using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System;
using System.Linq;

namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        partial class RequisicoesRow
        {
            public string Devolucao
            {
                get
                {
                    try
                    {
                        return DataDevolucao.ToString();
                    }
                    catch
                    {
                        return "Devolvido";
                    }
                }
            }
            public override string ToString()
            {
                LivrosTableAdapter livros = new LivrosTableAdapter();
                LivrosRow livro = (from linha in livros.GetData()
                                   where linha.LivroID == this.LivroID
                                   select linha).FirstOrDefault();
                return livro.Titulo;
            }
        }
        partial class LivrosRow
        {
            public override string ToString()
            {
                return Titulo;
            }
        }
        partial class UsuariosRow
        {
            public override string ToString()
            {
                return Nome;
            }
        }
        partial class FuncionariosRow
        {
            public override string ToString()
            {
                return NomeCompleto;
            }
        }

    }
}
