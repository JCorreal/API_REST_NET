namespace Api_Rest.Models
{
    public class Usuario
    {
        private int Usuario_Id = 0;
        private string Nombres;
        private string Apellidos;

        // Default Constructor
        public Usuario() { }

        public int usuario_id
        {
            get { return Usuario_Id; }
            set { Usuario_Id = value; }
        }

        public string nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }

        public string apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }

    }
}