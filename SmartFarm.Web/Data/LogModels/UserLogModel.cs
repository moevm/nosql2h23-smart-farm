using InfluxDB.Client.Core;

namespace SmartFarm.Web.Data.LogModels;

public class UserLogModel: Log
{
    [Column("user_id", IsTag = true)] public string UserId { get; set; } 
    [Column("edited_by", IsTag = true)] public string EditedBy { get; set; } 
    [Column("edit_field", IsTag = true)] public string EditField { get; set; } 
    [Column("previous_value")] public string PreviousValue { get; set; } 
    [Column("new_value")] public string NewValue { get; set; } 
}