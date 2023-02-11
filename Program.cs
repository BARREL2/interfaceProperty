using interfaceProperty;
using NLog;

DataClass dc = new DataClass();
Datas ds = new Datas();

dc.OutputLog();
ds.OutputLog();

internal class DataClass : IData
{
    public string Name { get; set; } = string.Empty;
    public Logger Logger => NLog.LogManager.GetCurrentClassLogger();

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