using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class ActorVsTalentService:IActorVsTalentService
   {
       private readonly IUnitOfWork _unitOfWork;

       public ActorVsTalentService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;

       }
        public bool AddActorVsTalent(ActorVsTalent actorVsTalent)
        {
            _unitOfWork.ActorVsTalentRepository.Add(actorVsTalent);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteActorVsTalent(ActorVsTalent actorVsTalent)
        {
            if (actorVsTalent == null) return false;
            _unitOfWork.ActorVsTalentRepository.Delete(actorVsTalent);
            _unitOfWork.Save();
            return true;
           
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorVsTalentRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorVsTalentRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActorVsTalent(ActorVsTalent actorVsTalent)
        {
            _unitOfWork.ActorVsTalentRepository.Edit(actorVsTalent);
            _unitOfWork.Save();
            return true;
        }

        public ActorVsTalent FindById(int id)
        {
            return _unitOfWork.ActorVsTalentRepository.FindById(id);
        }

        public List<ActorVsTalent> GetAllActorVsTalent()
        {
            return _unitOfWork.ActorVsTalentRepository.GetAll();
        }

        public List<ActorVsTalent> FindBy(System.Linq.Expressions.Expression<Func<ActorVsTalent, bool>> predicate)
        {
            return _unitOfWork.ActorVsTalentRepository.FindBy(predicate);
        }
    }
}
