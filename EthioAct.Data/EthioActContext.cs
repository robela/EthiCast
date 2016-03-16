using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Models.Models.Mapping;

namespace EthioAct.Data
{
    public partial class EthioActContext : DbContext
    {
        static EthioActContext()
        {
            Database.SetInitializer<EthioActContext>(null);
            //Database.SetInitializer<EthioActContext>(new MigrateDatabaseToLatestVersion<EthioActContext, Configuration>());
        }

        public EthioActContext()
            : base("EthioActContext")
        {
        }

        public DbSet<ActingType> ActingTypes { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorRequirement> ActorRequirements { get; set; }
        public DbSet<ActorVsActingType> ActorVsActingTypes { get; set; }
        public DbSet<ActorVsImage> ActorVSImages { get; set; }
        public DbSet<ActorVsTalent> ActorVsTalents { get; set; }
        public DbSet<ActorVSVideo> ActorVSVideos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<casting> castings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageType> ImageTypes { get; set; }
        public DbSet<portfolio> portfolios { get; set; }
        public DbSet<PortfolioType> PortfolioTypes { get; set; }
        public DbSet<portfolioVSImage> portfolioVSImages { get; set; }
        public DbSet<portfolioVSVideo> portfolioVSVideos { get; set; }
        public DbSet<RequirementType> RequirementTypes { get; set; }
        public DbSet<RequirementValue> RequirementValues { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Talent> Talents { get; set; }
        public DbSet<TalentCategory> TalentCategories { get; set; }
        public DbSet<talentValue> talentValues { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoType> VideoTypes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActingTypeMap());
            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new ActorRequirementMap());
            modelBuilder.Configurations.Add(new ActorVsActingTypeMap());
            modelBuilder.Configurations.Add(new ActorVSImageMap());
            modelBuilder.Configurations.Add(new ActorVsTalentMap());
            modelBuilder.Configurations.Add(new ActorVSVideoMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new castingMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new ImageTypeMap());
            modelBuilder.Configurations.Add(new portfolioMap());
            modelBuilder.Configurations.Add(new PortfolioTypeMap());
            modelBuilder.Configurations.Add(new portfolioVSImageMap());
            modelBuilder.Configurations.Add(new portfolioVSVideoMap());
            modelBuilder.Configurations.Add(new RequirementTypeMap());
            modelBuilder.Configurations.Add(new RequirementValueMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TalentMap());
            modelBuilder.Configurations.Add(new TalentCategoryMap());
            modelBuilder.Configurations.Add(new talentValueMap());
            modelBuilder.Configurations.Add(new VideoMap());
            modelBuilder.Configurations.Add(new VideoTypeMap());
        }
    }
}
