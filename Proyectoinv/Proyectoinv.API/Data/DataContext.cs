using Proyectoinv.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Proyectoinv.API.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Proyectoinvestigacion> Proyectoinv { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }



}