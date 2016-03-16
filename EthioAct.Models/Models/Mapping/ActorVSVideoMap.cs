using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorVSVideoMap : EntityTypeConfiguration<ActorVSVideo>
    {
        public ActorVSVideoMap()
        {
            // Primary Key
            this.HasKey(t => t.actorVsVideoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActorVSVideo");
            this.Property(t => t.actorVsVideoId).HasColumnName("actorVsVideoId");
            this.Property(t => t.actorId).HasColumnName("actorId");
            this.Property(t => t.videoId).HasColumnName("videoId");

            // Relationships
            this.HasRequired(t => t.Actor)
                .WithMany(t => t.ActorVSVideos)
                .HasForeignKey(d => d.actorId);
            this.HasRequired(t => t.Video)
                .WithMany(t => t.ActorVSVideos)
                .HasForeignKey(d => d.videoId);

        }
    }
}
