using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
            // Initialize context properties here
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
            // Initialize context properties here
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure the database provider and connection string here
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ExoApi;User Id=sa2;Password=12345;TrustServerCertificate=True;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}