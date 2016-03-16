using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorVSImageMap : EntityTypeConfiguration<ActorVsImage>
    {
        public ActorVSImageMap()
        {
            // Primary Key
            this.HasKey(t => t.actorVsImageId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActorVSImage");
            this.Property(t => t.actorVsImageId).HasColumnName("actorVsImageId");
            this.Property(t => t.actorId).HasColumnName("actorId");
            this.Property(t => t.ImageId).HasColumnName("ImageId");

            // Relationships
            this.HasRequired(t => t.Actor)
                .WithMany(t => t.ActorVSImages)
                .HasForeignKey(d => d.actorId);
            this.HasRequired(t => t.Image)
                .WithMany(t => t.ActorVSImages)
                .HasForeignKey(d => d.ImageId);

        }
    }
}
