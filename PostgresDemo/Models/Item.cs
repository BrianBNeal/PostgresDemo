namespace PostgresDemo.Models;

public class Item : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ItemStatus Status { get; set; }
    public ItemCategoryId ItemCategoryId { get; set; }

    public virtual ItemCategory ItemCategory { get; set; } = null!;
}

public enum ItemStatus
{
    Active,
    Inactive,
    Preview,
    Discontinued,
    Deleted,
}