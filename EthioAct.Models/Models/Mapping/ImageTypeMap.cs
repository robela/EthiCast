using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ImageTypeMap : EntityTypeConfiguration<ImageType>
    {
        public ImageTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.imageTypeId);

            // Properties
            this.Property(t => t.imageTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImageType");
            this.Property(t => t.imageTypeId).HasColumnName("imageTypeId");
            this.Property(t => t.imageTypeName).HasColumnName("imageTypeName");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
