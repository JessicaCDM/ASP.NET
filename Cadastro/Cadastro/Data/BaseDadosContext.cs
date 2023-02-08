using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
	public class BaseDadosContext : DbContext
	{
		public BaseDadosContext(DbContextOptions<BaseDadosContext> opcoes) : base(opcoes)
		{

		}
		public DbSet<RegistoModel> Registos { get; set; }
	}
}

