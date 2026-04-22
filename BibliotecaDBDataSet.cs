using BibliotecaRemake.BibliotecaDBDataSetTableAdapters;
using System.Linq;


namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        partial class RequisicoesRow
        {
            public override string ToString()
            {
                return LivroID.ToString();
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
