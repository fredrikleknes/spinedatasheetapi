namespace datasheetapi.Models;

public class TagData : ITagData
{
    public Guid Id { get; set; }
    public string? TagNo { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Area { get; set; }
    public string? Discipline { get; set; }
    public string? Contract { get; set; }
    public string? ContractName { get; set; }
    public string? TagStatus { get; set; }
    public string? EngineeringCode { get; set; }
    public string? PurchaseOrder { get; set; }
    public int Version { get; set; }
}
