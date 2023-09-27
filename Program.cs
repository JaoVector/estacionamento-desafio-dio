using Desafio_Estacionamento_Dio.Classes;

var estacionamento = new Estacionamento(3);

estacionamento.AdicionaVeiculo(new Veiculo("1g212", "Palio"));
estacionamento.AdicionaVeiculo(new Veiculo("535tr", "Corsa"));
estacionamento.AdicionaVeiculo(new Veiculo("gds341", "Vectra"));
estacionamento.ListaDeVeiculos();
Console.WriteLine("=========================================");
estacionamento.RemoveVeiculo(1);
Console.WriteLine("=========================================");
estacionamento.ListaDeVeiculos();
estacionamento.AdicionaVeiculo(new Veiculo("gds341", "Lancer"));
Console.WriteLine("=========================================");
estacionamento.ListaDeVeiculos();
Console.WriteLine("=========================================");
estacionamento.AdicionaVeiculo(new Veiculo("gds341", "Land Rover"));

/*

Neste Projeto de LAB você será desafiado a construir um sistema para um estacionamento, 
que será usado para gerenciar os veículos estacionados e realizar suas operações, 
como por exemplo adicionar um veículo, 
remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

*/