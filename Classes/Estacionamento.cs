namespace Desafio_Estacionamento_Dio.Classes
{
    public class Estacionamento : IEstacionamento<Veiculo> 
    {
        private Veiculo[] _vagas;
        private int tam = 0;
        
        public Estacionamento(int capacidade)
        {
            _vagas = new Veiculo[capacidade];
        }

        public void AdicionaVeiculo(Veiculo veiculo)
        {
            if(tam < _vagas.Length)
            {
                var i = Array.IndexOf(_vagas, null);
                _vagas[i] = veiculo;
                tam++;
            } else 
            {
                Console.WriteLine("Estacionamento Lotado!!!");
            }
        }

        public void ListaDeVeiculos()
        {
            for (int i = 0; i < _vagas.Length; i++)
            {
               if(_vagas[i] != null) Console.WriteLine($"Veiculos: {_vagas[i].Modelo} {i}");
            }
        }

        public void RemoveVeiculo(int index)
        {
            var tempo = _vagas[index].Chegada;
            CalculoPermanencia.CalculaValor(tempo);
            ResizeVagas(index);
        }

        private void ResizeVagas(int index)
        {
            _vagas[index] = null!;
            tam--;   
        }
    }
}
