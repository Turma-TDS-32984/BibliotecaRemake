namespace BibliotecaRemake
{


    partial class BibliotecaDBDataSet
    {
        public partial class  LivrosRow
        {
            public override string ToString()
            {
                return LivroID.ToString() +"-" + Titulo;
            }
        }
        public partial class  UsuariosRow
        {
            public override string ToString()
            {
                return UsuarioID.ToString() + "-" + Nome;
            }
        }
        partial class UsuariosDataTable
        {
        }
    }
}
