

public class PercentageDTO: IPercentageDTO{
    public string Uf { get; set; }
    public double Percentage { get; set; }

    public PercentageDTO(){}
    public PercentageDTO(string Uf, double Percentage) {
        Uf = Uf;
        Percentage = Percentage;
    }
}