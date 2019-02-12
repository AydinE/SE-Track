using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEAPI.Models
{
	public class SEAPIContext : DbContext
	{
		public SEAPIContext(DbContextOptions<SEAPIContext> options)
			: base(options)
		{
		}

		public DbSet<Post> Posts { get; set; }
	}
}
