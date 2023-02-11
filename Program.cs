using interfaceProperty;
using NLog;

DataClass dc = new DataClass();
Datas ds = new Datas();

//dc.OutputLog();
//ds.OutputLog();

dc.FirstName = "Test";

//dc.LastName = "Last";
dc.SetLastName("last");

Console.WriteLine(dc.FirstName);
Console.WriteLine(dc.LastName);

Func<int, string> circle = (x) => (x * x * 2).ToString();
Console.WriteLine(circle(5));

// 使用方法
Console.WriteLine(dc.PerformCalculation(5, 10, dc.AddNumbers));
Console.WriteLine(dc.PerformCalculation(5, 10, dc.SubtractNumbers));

internal class DataClass : IData
{
    public string Name { get; set; } = string.Empty;
    public Logger Logger => NLog.LogManager.GetCurrentClassLogger();

    internal string FirstName { get; set; }
    internal string LastName { get; private set; }

    internal void SetLastName(string Last)
    {
        LastName = Last;
    }

    public DataClass()
    {
        Name = this.GetType().Name;
    }

    internal void SetName(string name)
    {
        this.Name = name;
    }

    internal void OutputLog()
    {
        Logger.Info("ロガー名: " + Name);
    }

    public int PerformCalculation(int num1, int num2, Func<int, int, int> calculationType)
    {
        return calculationType(num1, num2);
    }

    public int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    public int SubtractNumbers(int num1, int num2)
    {
        return num1 - num2;
    }


}

internal class Datas : IData
{
    public string Name { get; set; } = string.Empty;
    public Logger Logger => NLog.LogManager.GetCurrentClassLogger();

    public Datas()
    {
        Name = this.GetType().Name;
    }

    internal void OutputLog()
    {
        Logger.Trace("ロガー名: " + Name);
    }


}