using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
  public  class ActorVsVideoService:IActorVsVideoService
  {
      private readonly IUnitOfWork _unitOfWork;

      public ActorVsVideoService(IUnitOfWork unitOfWork)
      {
          _unitOfWork = unitOfWork;
      }
      public bool AddActorVsVideo(ActorVSVideo actorVsVideo)
      {
          _unitOfWork.ActorVsVideoRepository.Add(actorVsVideo);
          _unitOfWork.Save();
          return true;
      }

        public bool DeleteActorVsVideo(ActorVSVideo actorVsVideo)
        {
            if (actorVsVideo == null) return false;
            _unitOfWork.ActorVsVideoRepository.Delete(actorVsVideo);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorVsVideoRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorVsVideoRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActorVsVideo(ActorVSVideo actorVsVideo)
        {
            _unitOfWork.ActorVsVideoRepository.Edit(actorVsVideo);
            _unitOfWork.Save();
            return true;
        }

        public ActorVSVideo FindById(int id)
        {
            return _unitOfWork.ActorVsVideoRepository.FindById(id);

        }

        public List<ActorVSVideo> GetAllActorVsVideo()
        {
            return _unitOfWork.ActorVsVideoRepository.GetAll();
        }

        public List<ActorVSVideo> FindBy(System.Linq.Expressions.Expression<Func<ActorVSVideo, bool>> predicate)
        {
            return _unitOfWork.ActorVsVideoRepository.FindBy(predicate);
        }
    }
}
