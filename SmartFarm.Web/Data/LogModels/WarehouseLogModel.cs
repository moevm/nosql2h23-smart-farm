using InfluxDB.Client.Core;

namespace SmartFarm.Web.Data.LogModels;

public class WarehouseLogModel: Log
{
    [Column("user_id", IsTag = true)] public string UserId { get; set; } 
    [Column("greenhouse_id", IsTag = true)] public string GreenhouseId { get; set; } 
    [Column("warehouse_id", IsTag = true)] public string WarehouseId { get; set; } 
    [Column("amount")] public int Amount { get; set; } 
}
