using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class VideoMap : EntityTypeConfiguration<Video>
    {
        public VideoMap()
        {
            // Primary Key
            this.HasKey(t => t.videoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Videos");
            this.Property(t => t.videoId).HasColumnName("videoId");
            this.Property(t => t.videoTypeId).HasColumnName("videoTypeId");
            this.Property(t => t.videoURl).HasColumnName("videoURl");
            this.Property(t => t.description).HasColumnName("description");

            // Relationships
            this.HasOptional(t => t.VideoType)
                .WithMany(t => t.Videos)
                .HasForeignKey(d => d.videoTypeId);

        }
    }
}
