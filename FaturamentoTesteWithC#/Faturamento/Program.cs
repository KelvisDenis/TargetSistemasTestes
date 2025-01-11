// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;


String filePath =  "D:\\TestesTarget\\Data\\dados.json";
string jsonFile = File.ReadAllText(filePath);
List<DailyBilling> dados = JsonConvert.DeserializeObject<List<DailyBilling>>(jsonFile);
var minValue = FormatFaturamento.LowerRevenueMethod(dados);
Console.WriteLine($"Menor valor de faturamento do mês: Dia: {minValue.Dia}, Valor: R${minValue.Valor}");

Console.WriteLine("---------------------------------");
var maxValueList = FormatFaturamento.HigherRevenueMethod(dados);
Console.WriteLine($"Maior valor de faturamento do mês: Dia: {maxValueList.Dia}, Valor: R${maxValueList.Valor}");

Console.WriteLine("---------------------------------");
var mediaValue = FormatFaturamento.AverageRevenueMethod(dados);
Console.WriteLine($"Quantidade de dias onde faturamento diário foi maior que a média mensal foram  {mediaValue}");




