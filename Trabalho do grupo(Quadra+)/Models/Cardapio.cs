namespace Trabalho_do_grupo_Quadra__.Models
{
    public class Cardapio
    {
        public int Id_Item { get; set; }
        public string Nome_Item { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
        public bool Disponibilidade { get; set; }
    }
}
