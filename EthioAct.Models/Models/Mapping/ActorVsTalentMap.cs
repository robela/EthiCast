using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorVsTalentMap : EntityTypeConfiguration<ActorVsTalent>
    {
        public ActorVsTalentMap()
        {
            // Primary Key
            this.HasKey(t => t.actorVsTalent1);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActorVsTalent");
            this.Property(t => t.actorVsTalent1).HasColumnName("actorVsTalent");
            this.Property(t => t.actorId).HasColumnName("actorId");
            this.Property(t => t.talentId).HasColumnName("talentId");
            this.Property(t => t.talentValueId).HasColumnName("talentValueId");

            // Relationships
            this.HasRequired(t => t.Actor)
                .WithMany(t => t.ActorVsTalents)
                .HasForeignKey(d => d.actorId);
            this.HasRequired(t => t.Talent)
                .WithMany(t => t.ActorVsTalents)
                .HasForeignKey(d => d.talentId);
            this.HasRequired(t => t.talentValue)
                .WithMany(t => t.ActorVsTalents)
                .HasForeignKey(d => d.talentValueId);

        }
    }
}
