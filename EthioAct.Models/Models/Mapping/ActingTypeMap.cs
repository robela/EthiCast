using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActingTypeMap : EntityTypeConfiguration<ActingType>
    {
        public ActingTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.actingTypeId);

            // Properties
            this.Property(t => t.typeName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ActingType");
            this.Property(t => t.actingTypeId).HasColumnName("actingTypeId");
            this.Property(t => t.typeName).HasColumnName("typeName");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
