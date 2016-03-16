using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
  public class ActorVsActingTypeService:IActorVsActingTypeService
  {
          private readonly IUnitOfWork _unitOfWork;

          public ActorVsActingTypeService(IUnitOfWork unitOfWork)
          {
              _unitOfWork = unitOfWork;

          }
        public bool AddActorVsActingType(ActorVsActingType actorVsActingType)
        {
            _unitOfWork.ActorVsActingTypeRepository.Add(actorVsActingType);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteActorVsActingType(ActorVsActingType actorVsActingType)
        {
            if (actorVsActingType == null) return false;
            _unitOfWork.ActorVsActingTypeRepository.Delete(actorVsActingType);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorVsActingTypeRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorVsActingTypeRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActorVsActingType(ActorVsActingType actorVsActingType)
        {
            _unitOfWork.ActorVsActingTypeRepository.Edit(actorVsActingType);
            _unitOfWork.Save();
            return true;
        }

        public ActorVsActingType FindById(int id)
        {
            return _unitOfWork.ActorVsActingTypeRepository.FindById(id);
        }

        public List<ActorVsActingType> GetAllActorVsActingType()
        {
            return _unitOfWork.ActorVsActingTypeRepository.GetAll();
        }

        public List<ActorVsActingType> FindBy(System.Linq.Expressions.Expression<Func<ActorVsActingType, bool>> predicate)
        {
            return _unitOfWork.ActorVsActingTypeRepository.FindBy(predicate);
        }
    }
}
