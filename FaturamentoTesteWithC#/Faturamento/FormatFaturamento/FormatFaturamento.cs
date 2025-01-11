
using System;

public static class FormatFaturamento{

    public static DailyBilling LowerRevenueMethod(List<DailyBilling> dailyBillingList ){
        var validDays = dailyBillingList.Where(x => x.Valor != 0);
        var minValue = validDays.Min(x => x.Valor);
        var result = dailyBillingList.Find(x => x.Valor == minValue );
        return result;
    }
    public static DailyBilling HigherRevenueMethod(List<DailyBilling> dailyBillingList ){
        var value = dailyBillingList.Max(x => x.Valor);
        var result = dailyBillingList.Find(x => x.Valor == value);
        return result;
    }

    public static int AverageRevenueMethod(List<DailyBilling> dailyBillingList){
        var validDays = dailyBillingList.Where(x => x.Valor != 0);
        var mediaValues =  validDays.Sum(x => x.Valor / validDays.Count());
        var mediaDays = validDays.Where(x => x.Valor > mediaValues);
        return mediaDays.Count();
    }


}