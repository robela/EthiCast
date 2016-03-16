using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class portfolioVSImageMap : EntityTypeConfiguration<portfolioVSImage>
    {
        public portfolioVSImageMap()
        {
            // Primary Key
            this.HasKey(t => t.portfolioVsImageId);

            // Properties
            // Table & Column Mappings
            this.ToTable("portfolioVSImage");
            this.Property(t => t.portfolioVsImageId).HasColumnName("portfolioVsImageId");
            this.Property(t => t.portfolioId).HasColumnName("portfolioId");
            this.Property(t => t.ImageId).HasColumnName("ImageId");

            // Relationships
            this.HasRequired(t => t.Image)
                .WithMany(t => t.portfolioVSImages)
                .HasForeignKey(d => d.ImageId);
            this.HasRequired(t => t.portfolio)
                .WithMany(t => t.portfolioVSImages)
                .HasForeignKey(d => d.portfolioId);

        }
    }
}
