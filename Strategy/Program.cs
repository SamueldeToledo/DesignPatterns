// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Strategy!");
Console.WriteLine("Digite uma das seguintes operações:\n 1- adição\n 2- subtração");
string respostaOperacao = Console.ReadLine();

Console.WriteLine("Digite o primeiro número: ");
decimal Valor1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
decimal Valor2 = Convert.ToDecimal(Console.ReadLine());

if (respostaOperacao == "1")
{
  var result =  new Operacoes().calculo(new Mais(), Valor1, Valor2);
    Console.WriteLine($"Resultado: {result}");
}
else if (respostaOperacao == "2")
{
   var result = new Operacoes().calculo(new Menos(), Valor1, Valor2);
    Console.WriteLine($"Resultado: {result}");
}

