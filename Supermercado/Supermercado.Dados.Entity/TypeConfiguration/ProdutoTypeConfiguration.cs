using Supermercado.Dominio;
using Supermercado.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado.Dados.Entity.TypeConfiguration
{
    class ProdutoTypeConfiguration : SupermercadoEntityAbstractConfig<Produto>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
               .IsRequired()
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
               .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Marca)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Marca");

            Property(p => p.Quantidade)
               .IsRequired()
               .HasColumnName("Quantidade");

            Property(p => p.Validade)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("Validade");

            Property(p => p.Valor)
               .IsRequired()
               .HasColumnName("Valor");
        }

        protected override void ConfigurarChaveEstrageira()
        {
           
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Produto");
        }
    }

}
