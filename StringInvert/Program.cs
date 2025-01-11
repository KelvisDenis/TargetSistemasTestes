// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma palavra ou frase:");
var input = Console.ReadLine();
var invertString = StringInvert.InvertMethod(input);
Console.WriteLine(invertString);
