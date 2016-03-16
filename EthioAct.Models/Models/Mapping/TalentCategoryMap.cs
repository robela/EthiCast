using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class TalentCategoryMap : EntityTypeConfiguration<TalentCategory>
    {
        public TalentCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.talentCategoryId);

            // Properties
            this.Property(t => t.talentCategoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.categoryName)
                .HasMaxLength(50);

            this.Property(t => t.type)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TalentCategory");
            this.Property(t => t.talentCategoryId).HasColumnName("talentCategoryId");
            this.Property(t => t.categoryName).HasColumnName("categoryName");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
