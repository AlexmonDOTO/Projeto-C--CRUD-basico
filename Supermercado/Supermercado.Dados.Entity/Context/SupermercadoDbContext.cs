using Supermercado.Dados.Entity.TypeConfiguration;
using Supermercado.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dados.Entity.Context
{
    public class SupermercadoDbContext : DbContext
    {
        public DbSet<Produto> Produtos {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoTypeConfiguration());
        }

    }
}
