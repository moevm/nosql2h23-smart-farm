using InfluxDB.Client.Core;

namespace SmartFarm.Web.Data.LogModels;

public abstract class Log
{
    [Column(IsTimestamp = true)] public DateTime Time { get; set; }
    [Column(IsMeasurement = true)] public string Measurement { get; set; }
}