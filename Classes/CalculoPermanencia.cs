namespace Desafio_Estacionamento_Dio.Classes
{
    public static class CalculoPermanencia
    {
        private static double[] Precos = {15.00, 20.00, 25.00, 30.00, 35.00};
        public static void CalculaValor(DateTime time)
        {
            var soma = (double[] values) =>
            {
                double soma = 0;
                foreach(var value in values) soma+= value;
                return soma;
            };

            var saida = new DateTime(2023, 9, 26, 22, 30, 15);

            TimeSpan calculoTempo = saida - time;

            if(calculoTempo.Hours < 1)
            {
                Console.WriteLine("Gratuito");
            } else if(calculoTempo.Hours < 5) 
            {
                Console.WriteLine($"Por {calculoTempo.Hours} pagar R${Precos[calculoTempo.Hours]} Reais");
            } else 
            {
                var totalApagar = soma(Precos);
                Console.WriteLine($"Acima de 5hrs deve ser pago R${totalApagar}");
            }
        } 
    }
}