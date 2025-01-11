


public class DailyBilling: IDailyBilling{
    public int Dia { get; set; }
    public double Valor { get; set; }


    public DailyBilling(){}
    public DailyBilling(int dia, double valor){
        Valor = valor;
        Dia = dia;
    }

}