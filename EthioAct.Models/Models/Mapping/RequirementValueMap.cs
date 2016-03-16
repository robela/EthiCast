using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class RequirementValueMap : EntityTypeConfiguration<RequirementValue>
    {
        public RequirementValueMap()
        {
            // Primary Key
            this.HasKey(t => t.RequirementValueID);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RequirementValue");
            this.Property(t => t.RequirementValueID).HasColumnName("RequirementValueID");
            this.Property(t => t.requirementTypeId).HasColumnName("requirementTypeId");
            this.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
