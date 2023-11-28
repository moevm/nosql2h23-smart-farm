namespace SmartFarm.Web.Data;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public UserRole Role { get; set; }
    public int? TeamId { get; set; }
    public bool IsWorking { get; set; }
    public string AdditionalInfo { get; set; }
    public List<UserTask>? Tasks { get; set; }
}

public class UserTask
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public string Description { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public int? GreenhouseNumber { get; set; }
    public bool IsCompleted { get; set; }
}

public enum UserRole
{
    Worker,
    Owner,
    Brigadier
}