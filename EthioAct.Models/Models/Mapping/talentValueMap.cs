using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class talentValueMap : EntityTypeConfiguration<talentValue>
    {
        public talentValueMap()
        {
            // Primary Key
            this.HasKey(t => t.talentValueId);

            // Properties
            this.Property(t => t.value)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("talentValue");
            this.Property(t => t.talentValueId).HasColumnName("talentValueId");
            this.Property(t => t.value).HasColumnName("value");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.talentCategoryId).HasColumnName("talentCategoryId");

            // Relationships
            this.HasOptional(t => t.TalentCategory)
                .WithMany(t => t.talentValues)
                .HasForeignKey(d => d.talentCategoryId);

        }
    }
}
