// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("Observer...");

var Lojas = new LojasNotifier();
var Clientes = new ClientesNotifier();

var produto = new Produto();
produto.PrecoAlterado(Lojas);
produto.PrecoAlterado(Clientes);
produto.NotificarPrecos(10);
