public class PercentageData: IPercentageData{
    public string Uf { get; set; }
    public double Valor { get; set; }


    public PercentageData(){}
    public PercentageData(string uf, double valor){
        Valor = valor;
        Uf = uf;
    }

}