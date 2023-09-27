namespace Desafio_Estacionamento_Dio.Classes
{
    public interface IEstacionamento<T>
    {
        void AdicionaVeiculo(T etity);
        void ListaDeVeiculos();
        void RemoveVeiculo(int index);
    }
}