// See https://aka.ms/new-console-template for more information
using Talents;

Console.WriteLine("Hello, World!");



Calculadora c = new Calculadora(); 

c.Somar(2,2); 
c.Multiplicar(2,3);
c.Dividir(3,2);
c.Somar(4,3); 
List<string> operacoes = c.Historico();

foreach (var hist in operacoes)
{
    Console.WriteLine(hist);
}