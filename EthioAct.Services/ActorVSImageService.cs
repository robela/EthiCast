using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
  public  class ActorVsImageService:IActorVsImageService
  {
      private readonly IUnitOfWork _unitOfWork;

      public ActorVsImageService(IUnitOfWork unitOfWork)
      {
          _unitOfWork = unitOfWork;
      }
      public bool AddActorVsImage(ActorVsImage actorVsImage)
      {
          _unitOfWork.ActorVsImageRepository.Add(actorVsImage);
          _unitOfWork.Save();
          return true;
      }

        public bool DeleteActorVsImage(ActorVsImage actorVsImage)
        {
            if (actorVsImage == null) return false;
            _unitOfWork.ActorVsImageRepository.Delete(actorVsImage);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorVsImageRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorVsImageRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActorVsImage(ActorVsImage actorVsImage)
        {
            _unitOfWork.ActorVsImageRepository.Edit(actorVsImage);
            _unitOfWork.Save();
            return true;
        }

        public ActorVsImage FindById(int id)
        {
            return _unitOfWork.ActorVsImageRepository.FindById(id);
        }

        public List<ActorVsImage> GetAllActorVsImage()
        {
            return _unitOfWork.ActorVsImageRepository.GetAll();
        }

        public List<ActorVsImage> FindBy(System.Linq.Expressions.Expression<Func<ActorVsImage, bool>> predicate)
        {
            return _unitOfWork.ActorVsImageRepository.FindBy(predicate);
        }
    }
}
