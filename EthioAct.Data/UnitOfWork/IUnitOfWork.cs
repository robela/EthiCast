using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Data.Repository;
using EthioAct.Models.Models;

namespace EthioAct.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        Database Database { get; }
        IGenericRepository<Actor> ActorRepository { get; }
        IGenericRepository<ActingType> ActingTypeRepository { get; }
        IGenericRepository<ActorRequirement> ActorRequirementRepository { get; }
        IGenericRepository<ActorVsActingType> ActorVsActingTypeRepository { get; }
        IGenericRepository<ActorVsTalent> ActorVsTalentRepository { get; }
        IGenericRepository<ActorVsImage> ActorVsImageRepository { get; }
        IGenericRepository<ActorVSVideo> ActorVsVideoRepository { get; }
        IGenericRepository<Address> AddressRepository { get; }
        IGenericRepository<casting> CastingRepository { get; }
        IGenericRepository<Image> ImageRepository { get; }
        IGenericRepository<ImageType> ImageTypeRepository { get; }
        IGenericRepository<portfolio> PortfolioRepository { get; }
        IGenericRepository<PortfolioType> PortfolioTypeRepository { get; }
        IGenericRepository<portfolioVSImage> PortfolioVsImageRepository { get; }
        IGenericRepository<portfolioVSVideo> PortfolioVsVideoRepository { get; }
        IGenericRepository<RequirementType> RequirementTypeRepository { get; }
        IGenericRepository<RequirementValue> RequirementValueRepository { get; }
        IGenericRepository<Talent> TalentRepository { get; }
        IGenericRepository<TalentCategory> TalentCategoryRepository { get; }
        IGenericRepository<talentValue> TalentValueRepository { get; }
        IGenericRepository<Video> VideoRepository { get; }
        IGenericRepository<VideoType> VideoTypeRepository { get; } 

        
        void Save();
    }
}
