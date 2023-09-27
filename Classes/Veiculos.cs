namespace Desafio_Estacionamento_Dio.Classes
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string? Modelo { get; set; }
        public DateTime Chegada = DateTime.Now;

        public Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }
    }
}