namespace datasheetapi.Models
{
    public interface ITagData
    {
        Guid Id { get; set; }
        string? TagNo { get; set; }
        string? Description { get; set; }
        string? Category { get; set; }
        string? Area { get; set; }
        string? Discipline { get; set; }
        int Version { get; set; }
        TagDataReview? TagDataReview { get; set; }
        RevisionContainer? RevisionContainer { get; set; }
    }
}