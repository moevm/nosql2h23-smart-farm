using InfluxDB.Client.Core;

namespace SmartFarm.Web.Data.LogModels;

public class AttendanceLogModel: Log
{
    [Column("user_id", IsTag = true)] public string UserId { get; set; } 
    [Column("placement", IsTag = true)] public string Placement { get; set; } 
    [Column("greenhouse_number", IsTag = true)] public int? GreenhouseNumber { get; set; } 
    [Column("action")] public string Action { get; set; } 
}

public enum AttendanceAction
{
    Arrive,
    Leave
}

public enum PlacementType
{
    Greenhouse,
    Warehouse
}
