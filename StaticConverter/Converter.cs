namespace ConsoleApp26;

class Converter
{
    private int logCount = 0;
    public string OperatorName { get; set; }
    public string[] OperationLogs { get; }

    public Converter(string operatorName)
    {
       OperatorName = operatorName; 
       OperationLogs = new string[100];
    }


    static Converter()
    {
        DollarRate = GetDollarRate();
        EuroRate = GetEuroRate();
    }

    private static double GetDollarRate()
    {
        return 42; // call database
    }

    private static double GetEuroRate()
    {
        return 45; // call database
    }

    public static double DollarRate { get; set; }   
    public static double EuroRate { get; set; }


    public static double ConvertEuroToHrn(double sum)
    {
        return EuroRate * sum;
    }

    public static double ConvertDollarsToHrn(double sum)
    {
        return DollarRate * sum;
    }

    public double ConvertHrnToDollarsWithLogs(double sum)
    {
        var res = ConvertEuroToHrn(sum);
        LogOperation($"Opertor {OperatorName} has proceeded operation convert hrn to dollars {sum} -> {res}");

        return res; 
    }

    public double ConvertDollarsToHrnWithLogs(double sum)
    {
        var res = ConvertDollarsToHrn(sum);
        LogOperation($"Opertor {OperatorName} has proceeded operation convert dollars to hrn {sum} -> {res}");
        return res;
    }

    public double ConvertEuroToHrnWithLogs(double sum)
    {
        var res = ConvertEuroToHrn(sum);
        LogOperation($"Opertor {OperatorName} has proceeded operation convert euro to hrn {sum} -> {res}");
        return res;
    }

    public double ConvertHrnToEuroWithLogs(double sum)
    {
        var res = ConvertHrnToEuro(sum);
        LogOperation($"Opertor {OperatorName} has proceeded operation convert hrn to euro {sum} -> {res}");
        return res;
    }

    private void LogOperation(string message)
    {
        if (logCount == OperationLogs.Length)
        {
            logCount = 0;
        }

        OperationLogs[logCount] = message;  
        logCount++;
    }

    public static double ConvertHrnToEuro(double sum)
    {
        if (EuroRate == 0)
            return 0;   

        return sum / EuroRate;
    }

    public static double ConvertHrnToDollars(double sum)
    {
        if (DollarRate == 0)
            return 0;

        return sum / DollarRate;
    }

}
