using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class RequirementTypeMap : EntityTypeConfiguration<RequirementType>
    {
        public RequirementTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.requirementTypeId);

            // Properties
            this.Property(t => t.requirementName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RequirementType");
            this.Property(t => t.requirementTypeId).HasColumnName("requirementTypeId");
            this.Property(t => t.requirementName).HasColumnName("requirementName");
            this.Property(t => t.description).HasColumnName("description");
        }
    }
}
