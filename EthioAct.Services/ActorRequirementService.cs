using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class ActorRequirementService:IActorRequirementService
   {
       private readonly IUnitOfWork _unitOfWork;

       public ActorRequirementService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }

        public bool AddActorRequirement(ActorRequirement actorRequirement)
        {
            _unitOfWork.ActorRequirementRepository.Add(actorRequirement);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteActorRequirement(ActorRequirement actorRequirement)
        {
            if (actorRequirement == null) return false;
            _unitOfWork.ActorRequirementRepository.Delete(actorRequirement);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorRequirementRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorRequirementRepository.Delete(entity);
            _unitOfWork.Save();
            return true;

        }

        public bool EditActorRequirement(ActorRequirement actorRequirement)
        {
            _unitOfWork.ActorRequirementRepository.Edit(actorRequirement);
            _unitOfWork.Save();
            return true;
        }

        public ActorRequirement FindById(int id)
        {
            return _unitOfWork.ActorRequirementRepository.FindById(id);

        }

        public List<ActorRequirement> GetAllDonor()
        {
            return _unitOfWork.ActorRequirementRepository.GetAll();
        }

        public List<ActorRequirement> FindBy(System.Linq.Expressions.Expression<Func<ActorRequirement, bool>> predicate)
        {
            return _unitOfWork.ActorRequirementRepository.FindBy(predicate);
        }
    }
}
