using System.Globalization;

namespace Trabalho_do_grupo_Quadra__.Models
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}