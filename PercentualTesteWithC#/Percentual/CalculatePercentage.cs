


public static class CalculatePercentage{
    public static List<PercentageDTO> CalculatePercentageMethod(List<PercentageData> percentageList){
        var sum = percentageList.Sum(x => x.Valor);
        var percentage = percentageList.Select(x => new PercentageDTO{Uf= x.Uf, Percentage= Math.Round(x.Valor / sum * 100, 2)} ).ToList();
        return percentage;
    }
}