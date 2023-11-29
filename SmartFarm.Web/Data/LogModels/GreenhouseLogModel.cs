using InfluxDB.Client.Core;

namespace SmartFarm.Web.Data.LogModels;

public class GreenhouseLogModel: Log
{
    [Column("action")] public string Action { get; set; }
    [Column("user_id", IsTag = true)] public string UserId { get; set; } 
        
}

public enum GreenhouseLogAction
{
    Plant,
    Harvest
}