# Estacionamento Desafio Dio
## Descrição do Projeto
Desafio feito usando princípios de POO e SOLID.
Este programa simula um estacionamento, possuí os metódos para adicionar, remover e listar os veiculos.
Quando um veiculo sai é efetuado o cácludo do valor a ser pago pelo tempo de permanencia no estacionamento.
Ao instanciar o estacionamento será passada o número de vagas que o estabelecimento possuí.

## Desafio
Neste Projeto de LAB você será desafiado a construir um sistema para um estacionamento, 
que será usado para gerenciar os veículos estacionados e realizar suas operações, 
como por exemplo adicionar um veículo, 
remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Saída:

```
Veiculos: Palio 0
Veiculos: Corsa 1
Veiculos: Vectra 2
=========================================
Acima de 5hrs deve ser pago R$125
=========================================
Veiculos: Palio 0
Veiculos: Vectra 2
=========================================
Veiculos: Palio 0
Veiculos: Lancer 1
Veiculos: Vectra 2
=========================================
Estacionamento Lotado!!!
```
Essa saída Mostra a entrada de todos os veiculos até acabar as vagas, depois a saida do "Corsa" da vaga 1, junto de seu valor a ser pago, e depois a chegada do "Lancer" na vaga 1, e por último a tentativa de entrada de mais um veículo porém já esta cheio.
