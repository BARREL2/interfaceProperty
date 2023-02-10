using interfaceProperty;
using NLog;


static void SetNamen(string[] args)
{
    DataClass dc = new();
    dc.SetName("aaaaaa");
}


internal class DataClass : IData
{
    public string Name { get; set; }

    static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

    internal void SetName(string name)
    {
        this.Name = name;
        _logger.Trace(name + DateTime.Now);
    }
}
