using Microsoft.EntityFrameworkCore;

public class contextoDB : DbContext
{
    public DbSet<estudiante> estudiantes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DENNIS;Database=semana11; Trusted_Connection = SSPI; MultipleActiveResultSets = true; Trust Server Certificate = true; ");
    }
}
