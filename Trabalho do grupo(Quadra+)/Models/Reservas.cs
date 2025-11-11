namespace Trabalho_do_grupo_Quadra__.Models
{
    public class Reservas
    {
        public int Id_Reserva { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Quadra { get; set; }
        public int Id_Esporte { get; set; }
        public DateTime Data_Reserva { get; set; }
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fim { get; set; }
        public string Status { get; set; }
        public decimal Valor_Total { get; set; }
        public DateTime Data_Criacao { get; set; }
    }
}
