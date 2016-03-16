using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class VideoTypeMap : EntityTypeConfiguration<VideoType>
    {
        public VideoTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.videoTypeId);

            // Properties
            this.Property(t => t.videoTypeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VideoType");
            this.Property(t => t.videoTypeId).HasColumnName("videoTypeId");
            this.Property(t => t.videoTypeName).HasColumnName("videoTypeName");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
