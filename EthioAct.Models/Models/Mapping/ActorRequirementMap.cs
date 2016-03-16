using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorRequirementMap : EntityTypeConfiguration<ActorRequirement>
    {
        public ActorRequirementMap()
        {
            // Primary Key
            this.HasKey(t => t.actorRequirementId);

            // Properties
            this.Property(t => t.requirementId)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.castingId)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ActorRequirement");
            this.Property(t => t.actorRequirementId).HasColumnName("actorRequirementId");
            this.Property(t => t.requirementId).HasColumnName("requirementId");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.castingId).HasColumnName("castingId");
        }
    }
}
