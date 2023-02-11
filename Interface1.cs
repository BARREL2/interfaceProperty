using NLog;
namespace interfaceProperty
{
    internal interface IData
    {
        public string Name { get; set; }
        public NLog.Logger Logger { get; }

        //public static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
    }
}