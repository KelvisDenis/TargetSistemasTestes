
Console.WriteLine("Digite um numero:");
var input = int.Parse(Console.ReadLine());
var result = Fibonacci.FibonacciMethod(input);
Console.WriteLine($"O número {input} {(result ? "é" : "não é")} um número de Fibonacci.");
