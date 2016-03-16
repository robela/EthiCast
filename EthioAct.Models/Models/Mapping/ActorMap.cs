using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace EthioAct.Models.Models.Mapping
{
    public class ActorMap : EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            // Primary Key
            this.HasKey(t => t.actorID);

            // Properties
            this.Property(t => t.userId)
                .HasMaxLength(128);

            this.Property(t => t.firstName)
                .HasMaxLength(50);

            this.Property(t => t.secondName)
                .HasMaxLength(50);

            this.Property(t => t.lastName)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.gender)
                .IsFixedLength()
                .HasMaxLength(1);
            this.Property(t => t.aboutMe)
                .HasMaxLength(500);

            this.Property(t => t.educationLevel)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.emailAddress)
                .HasMaxLength(50);

            this.Property(t => t.emailAddress2)
                .HasMaxLength(50);

            this.Property(t => t.faceBookAddress)
                .HasMaxLength(50);

            this.Property(t => t.googlePluseAddress)
                .HasMaxLength(50);

            this.Property(t => t.twitterAddress)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Actor");
            this.Property(t => t.actorID).HasColumnName("actorID");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.secondName).HasColumnName("secondName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.dateOfBirth).HasColumnName("dateOfBirth");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.height).HasColumnName("height");
            this.Property(t => t.weight).HasColumnName("weight");
            this.Property(t => t.aboutMe).HasColumnName("aboutMe");
            this.Property(t => t.educationLevel).HasColumnName("educationLevel");
            this.Property(t => t.addressId).HasColumnName("addressId");
            this.Property(t => t.emailAddress).HasColumnName("emailAddress");
            this.Property(t => t.emailAddress2).HasColumnName("emailAddress2");
            this.Property(t => t.faceBookAddress).HasColumnName("faceBookAddress");
            this.Property(t => t.googlePluseAddress).HasColumnName("googlePluseAddress");
            this.Property(t => t.twitterAddress).HasColumnName("twitterAddress");

            // Relationships
            this.HasOptional(t => t.Address)
                .WithMany(t => t.Actors)
                .HasForeignKey(d => d.addressId);
            this.HasOptional(t => t.AspNetUser)
                .WithMany(t => t.Actors)
                .HasForeignKey(d => d.userId);

        }
    }
}
