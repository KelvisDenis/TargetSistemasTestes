using Newtonsoft.Json;


String filePath =  "D:\\TestesTarget\\Data\\dadosCidade.json";
string jsonFile = File.ReadAllText(filePath);
List<PercentageData> dados = JsonConvert.DeserializeObject<List<PercentageData>>(jsonFile);
var format = CalculatePercentage.CalculatePercentageMethod(dados);

foreach(var item in format){
    Console.WriteLine($"UF: {item.Uf}  percentual: {item.Percentage}%");

}