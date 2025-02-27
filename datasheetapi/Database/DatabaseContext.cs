using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


namespace api.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Contract> Contracts { get; set; } = null!;
    public DbSet<RevisionContainer> RevisionContainers { get; set; } = null!;
    public DbSet<RevisionContainerTagNo> RevisionContainerTagNos { get; set; } = null!;
    public DbSet<RevisionContainerReview> RevisionContainerReviews { get; set; } = null!;
    public DbSet<TagDataReview> TagDataReviews { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } = null!;
}
