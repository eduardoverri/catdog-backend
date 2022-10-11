using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catdog_backend_domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace catdog_backend_domain
{
    public class Context: DbContext 
    {

        protected readonly IConfiguration Configuration;

        public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }
            
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Animal> Animal { get; set; }

        public DbSet<Evento> Evento { get; set; }

        public DbSet<TipoEvento> TipoEvento { get; set; }
        
        public DbSet<Entidade> Entidade { get; set; }
    }
}