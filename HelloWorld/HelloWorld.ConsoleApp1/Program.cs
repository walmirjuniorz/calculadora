using System.Runtime.InteropServices;

Console.Clear();

Console.WriteLine("-------------------------------"); //saida de dados / output
Console.WriteLine("Academia do Programador 2026");
Console.WriteLine("-------------------------------");
Console.Write("Digite seu nome: ");
string nomeUsuario = Console.ReadLine(); // le o que o usuario digita e guarda na memoria

Console.WriteLine();

string mensagemSaudacao = "Seja bem-vindo, " + nomeUsuario;

Console.WriteLine(mensagemSaudacao);

mensagemSaudacao = "Teste";

Console.ReadLine(); //entrada de dados / input