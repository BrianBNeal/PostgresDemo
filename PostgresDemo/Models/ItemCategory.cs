namespace PostgresDemo.Models;

public enum ItemCategoryId
{
    Miscellaneous,
    Electronics,
    Clothing,
    Snacks,
    Beverages
}
public class ItemCategory : BaseEntity<ItemCategoryId>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string BillingCode { get; set; } = string.Empty;
}
