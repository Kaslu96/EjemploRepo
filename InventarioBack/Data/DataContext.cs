namespace InventarioBack.Data
{
    using Microsoft.EntityFrameworkCore;

    public class DataContext
    {
        public DataContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
