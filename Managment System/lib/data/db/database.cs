using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

public class Database : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public Database()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=managment.db");
    }
    // DEBUG
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>().HasData(
                new User {Id = 1, login = "admin", password = "admin",isPriveleged = true},
                new User { Id = 2, login = "user", password = "user", isPriveleged = false}
        );
    }

    private static Database? instance;
 
    public static Database getInstance()
    {
        if (instance == null){
        instance = new Database();
        }
        return instance;
    }
}