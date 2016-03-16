using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class TalentMap : EntityTypeConfiguration<Talent>
    {
        public TalentMap()
        {
            // Primary Key
            this.HasKey(t => t.talentId);

            // Properties
            this.Property(t => t.talentName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Talent");
            this.Property(t => t.talentId).HasColumnName("talentId");
            this.Property(t => t.talentCategoryId).HasColumnName("talentCategoryId");
            this.Property(t => t.talentName).HasColumnName("talentName");
            this.Property(t => t.description).HasColumnName("description");

            // Relationships
            this.HasOptional(t => t.TalentCategory)
                .WithMany(t => t.Talents)
                .HasForeignKey(d => d.talentCategoryId);

        }
    }
}
