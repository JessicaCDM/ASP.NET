using TrabalhoFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoFinal.DataBase
{
    public class BaseDadosContext : DbContext
    {
        public BaseDadosContext(DbContextOptions<BaseDadosContext> opcoes) : base(opcoes) 
        { 

        }

        public DbSet<RegistoModel> Registos { get; set; }
    }
}
