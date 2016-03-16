using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class castingMap : EntityTypeConfiguration<casting>
    {
        public castingMap()
        {
            // Primary Key
            this.HasKey(t => t.castingId);

            // Properties
            this.Property(t => t.description)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.actingTypeId)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("casting");
            this.Property(t => t.castingId).HasColumnName("castingId");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.actingTypeId).HasColumnName("actingTypeId");
            this.Property(t => t.scriptDoc).HasColumnName("scriptDoc");
        }
    }
}
