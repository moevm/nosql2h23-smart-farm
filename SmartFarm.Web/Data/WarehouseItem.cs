namespace SmartFarm.Web.Data;

public class WarehouseItem
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int? Amount { get; set; }
    public string MeasureUnit { get; set; } = null!;
}