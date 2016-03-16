using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorVsActingTypeMap : EntityTypeConfiguration<ActorVsActingType>
    {
        public ActorVsActingTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.actorVsActingTypeId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ActorVsActingType");
            this.Property(t => t.actorVsActingTypeId).HasColumnName("actorVsActingTypeId");
            this.Property(t => t.actorId).HasColumnName("actorId");
            this.Property(t => t.actingTypeId).HasColumnName("actingTypeId");
        }
    }
}
