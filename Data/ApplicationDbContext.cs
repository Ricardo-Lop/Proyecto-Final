using Microsoft.EntityFrameworkCore;
using Proyecto_Final.Models;

namespace Proyecto_Final.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(
			DbContextOptions<ApplicationDbContext> options
		) : base(options)
		{

		}

		public DbSet<Cliente> Clientes { get; set; }

		public DbSet<Ticket> Tickets { get; set; }

		public DbSet<DetalleTicket> DetalleTickets { get; set; }
	}
}