using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class portfolioMap : EntityTypeConfiguration<portfolio>
    {
        public portfolioMap()
        {
            // Primary Key
            this.HasKey(t => t.portfolioId);

            // Properties
            this.Property(t => t.portfolioName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("portfolio");
            this.Property(t => t.portfolioId).HasColumnName("portfolioId");
            this.Property(t => t.portfolioName).HasColumnName("portfolioName");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.portfolioTypeId).HasColumnName("portfolioTypeId");

            // Relationships
            this.HasOptional(t => t.PortfolioType)
                .WithMany(t => t.portfolios)
                .HasForeignKey(d => d.portfolioTypeId);

        }
    }
}
