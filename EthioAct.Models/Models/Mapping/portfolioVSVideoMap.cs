using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class portfolioVSVideoMap : EntityTypeConfiguration<portfolioVSVideo>
    {
        public portfolioVSVideoMap()
        {
            // Primary Key
            this.HasKey(t => t.portfolioVsVideoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("portfolioVSVideo");
            this.Property(t => t.portfolioVsVideoId).HasColumnName("portfolioVsVideoId");
            this.Property(t => t.portfolioId).HasColumnName("portfolioId");
            this.Property(t => t.VideoId).HasColumnName("VideoId");

            // Relationships
            this.HasRequired(t => t.portfolio)
                .WithMany(t => t.portfolioVSVideos)
                .HasForeignKey(d => d.portfolioId);
            this.HasRequired(t => t.Video)
                .WithMany(t => t.portfolioVSVideos)
                .HasForeignKey(d => d.VideoId);

        }
    }
}
