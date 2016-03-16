using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class PortfolioTypeMap : EntityTypeConfiguration<PortfolioType>
    {
        public PortfolioTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.portfolioTypeID);

            // Properties
            this.Property(t => t.portfolioTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PortfolioType");
            this.Property(t => t.portfolioTypeID).HasColumnName("portfolioTypeID");
            this.Property(t => t.portfolioTypeName).HasColumnName("portfolioTypeName");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
