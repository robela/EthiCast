using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>
    {
        public ImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ImageId);

            // Properties
            this.Property(t => t.ImageName)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.imageURL)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Images");
            this.Property(t => t.ImageId).HasColumnName("ImageId");
            this.Property(t => t.ImageName).HasColumnName("ImageName");
            this.Property(t => t.imageURL).HasColumnName("imageURL");
            this.Property(t => t.imageTypeId).HasColumnName("imageTypeId");
            this.Property(t => t.description).HasColumnName("description");

            // Relationships
            this.HasOptional(t => t.ImageType)
                .WithMany(t => t.Images)
                .HasForeignKey(d => d.imageTypeId);

        }
    }
}
