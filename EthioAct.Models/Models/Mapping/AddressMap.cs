using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.addressId);

            // Properties
            this.Property(t => t.phoneNo)
                .HasMaxLength(50);

            this.Property(t => t.mobileNo)
                .HasMaxLength(50);

            this.Property(t => t.houseNo)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Address");
            this.Property(t => t.addressId).HasColumnName("addressId");
            this.Property(t => t.conurtyId).HasColumnName("conurtyId");
            this.Property(t => t.cityId).HasColumnName("cityId");
            this.Property(t => t.address1).HasColumnName("address");
            this.Property(t => t.phoneNo).HasColumnName("phoneNo");
            this.Property(t => t.mobileNo).HasColumnName("mobileNo");
            this.Property(t => t.mobileNo2).HasColumnName("mobileNo2");
            this.Property(t => t.houseNo).HasColumnName("houseNo");
            this.Property(t => t.regionId).HasColumnName("regionId");
            this.Property(t => t.zoneId).HasColumnName("zoneId");
            this.Property(t => t.woredaId).HasColumnName("woredaId");
            this.Property(t => t.townName).HasColumnName("townName");
        }
    }
}
