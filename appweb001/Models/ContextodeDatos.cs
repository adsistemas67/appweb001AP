using Microsoft.EntityFrameworkCore;


namespace appweb001.Models
{
    public class ContextodeDatos: DbContext
    {

        public DbSet<Contactos> contactos { get; set; }

        public ContextodeDatos(DbContextOptions<ContextodeDatos> options)
            : base(options)
        {
        }



    }
}
