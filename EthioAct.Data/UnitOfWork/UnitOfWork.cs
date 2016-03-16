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
    public class UnitOfWork : IUnitOfWork
    {


        public Database Database { get { return _context.Database; } }
        private readonly EthioActContext _context;
        private IGenericRepository<Actor> _actorRepository;
        private IGenericRepository<ActingType> _actingTypeRepository;
        private IGenericRepository<ActorRequirement> _actorRequirementRepository;
        private IGenericRepository<ActorVsActingType> _actorVsActingTypeRepository;
        private IGenericRepository<ActorVsTalent> _actorVsTalentRepository;
        private IGenericRepository<ActorVsImage> _actorVsImageRepository;
        private IGenericRepository<ActorVSVideo> _actorVsVideoRepository;
        private IGenericRepository<Address> _addressRepository;
        private IGenericRepository<casting> _castingRepository;
        private IGenericRepository<Image> _imageRepository;
        private IGenericRepository<ImageType> _imageTypeRepository;
        private IGenericRepository<portfolio> _portfolioRepository;
        private IGenericRepository<PortfolioType> _protfolioTypeRepository;
        private IGenericRepository<portfolioVSImage> _portfolioVsImageRepository;
        private IGenericRepository<portfolioVSVideo> _portfolioVsVideoRepository;
        private IGenericRepository<RequirementType> _requirementTypeRepository;
        private IGenericRepository<RequirementValue> _requirementValueRepository;
        private IGenericRepository<Talent> _talentRepository;
        private IGenericRepository<TalentCategory> _talentCategoryRepository;
        private IGenericRepository<talentValue> _talentValueRepository;
        private IGenericRepository<Video> _videoRepository;
        private IGenericRepository<VideoType> _videoTypeRepository;

        public UnitOfWork()
        {
            this._context = new EthioActContext();
        }
         
         public IGenericRepository<Actor> ActorRepository
         {
             get
             {
                 return this._actorRepository ?? (this._actorRepository = new GenericRepository<Actor>(_context));
             }

         }

         public IGenericRepository<ActingType> ActingTypeRepository
         {
             get
             {
                 return this._actingTypeRepository ?? (this._actingTypeRepository = new GenericRepository<ActingType>(_context));
             }

         }
        public IGenericRepository<ActorRequirement>  ActorRequirementRepository
        {
            get
            {
                return this._actorRequirementRepository ?? (this._actorRequirementRepository = new GenericRepository<ActorRequirement>(_context));
            }
        }
        public IGenericRepository<ActorVsActingType> ActorVsActingTypeRepository
        {
            get
            {
                return this._actorVsActingTypeRepository ?? (this._actorVsActingTypeRepository = new GenericRepository<ActorVsActingType>(_context));
            }
        }

        public IGenericRepository<ActorVsTalent> ActorVsTalentRepository
        {
            get
            {
                return this._actorVsTalentRepository ?? (this._actorVsTalentRepository = new GenericRepository<ActorVsTalent>(_context));
            }
        }
        public IGenericRepository<ActorVsImage> ActorVsImageRepository
        {
            get
            {
                return this._actorVsImageRepository ?? (this._actorVsImageRepository = new GenericRepository<ActorVsImage>(_context));
            }
        }
        public IGenericRepository<ActorVSVideo> ActorVsVideoRepository
        {
            get
            {
                return this._actorVsVideoRepository ?? (this._actorVsVideoRepository = new GenericRepository<ActorVSVideo>(_context));
            }
        }

        public IGenericRepository<Address> AddressRepository
        {
            get
            {
                return this._addressRepository ?? (this._addressRepository = new GenericRepository<Address>(_context));
            }
        }
        public IGenericRepository<casting> CastingRepository
        {
            get
            {
                return this._castingRepository ?? (this._castingRepository = new GenericRepository<casting>(_context));
            }
        }

        public IGenericRepository<Image> ImageRepository
        {
            get
            {
                return this._imageRepository ?? (this._imageRepository = new GenericRepository<Image>(_context));
            }
        }
        public IGenericRepository<ImageType> ImageTypeRepository
        {
            get
            {
                return this._imageTypeRepository ?? (this._imageTypeRepository = new GenericRepository<ImageType>(_context));
            }
        }

        public IGenericRepository<portfolio> PortfolioRepository
        {
            get
            {
                return this._portfolioRepository ?? (this._portfolioRepository = new GenericRepository<portfolio>(_context));
            }
        }

        public IGenericRepository<PortfolioType> PortfolioTypeRepository
        {
            get
            {
                return this._protfolioTypeRepository ?? (this._protfolioTypeRepository = new GenericRepository<PortfolioType>(_context));
            }
        }

        public IGenericRepository<portfolioVSImage> PortfolioVsImageRepository
        {
            get
            {
                return this._portfolioVsImageRepository ?? (this._portfolioVsImageRepository = new GenericRepository<portfolioVSImage>(_context));
            }
        }

        public IGenericRepository<portfolioVSVideo> PortfolioVsVideoRepository
        {
            get
            {
                return this._portfolioVsVideoRepository ?? (this._portfolioVsVideoRepository = new GenericRepository<portfolioVSVideo>(_context));
            }
        }

        public IGenericRepository<RequirementType> RequirementTypeRepository
        {
            get
            {
                return this._requirementTypeRepository ?? (this._requirementTypeRepository = new GenericRepository<RequirementType>(_context));
            }
        }

        public IGenericRepository<RequirementValue> RequirementValueRepository
        {
            get
            {
                return this._requirementValueRepository ?? (this._requirementValueRepository = new GenericRepository<RequirementValue>(_context));
            }
        }

        public IGenericRepository<Talent> TalentRepository
        {
            get
            {
                return this._talentRepository ?? (this._talentRepository = new GenericRepository<Talent>(_context));
            }
        }

        public IGenericRepository<TalentCategory> TalentCategoryRepository
        {
            get
            {
                return this._talentCategoryRepository ?? (this._talentCategoryRepository = new GenericRepository<TalentCategory>(_context));
            }
        }

        public IGenericRepository<talentValue> TalentValueRepository
        {
            get
            {
                return this._talentValueRepository ?? (this._talentValueRepository = new GenericRepository<talentValue>(_context));
            }
        }

        public IGenericRepository<Video> VideoRepository
        {
            get
            {
                return this._videoRepository ?? (this._videoRepository = new GenericRepository<Video>(_context));
            }
        }

        public IGenericRepository<VideoType> VideoTypeRepository
        {
            get
            {
                return this._videoTypeRepository ?? (this._videoTypeRepository = new GenericRepository<VideoType>(_context));
            }
        }

        public void Save()
        {
            this._context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
