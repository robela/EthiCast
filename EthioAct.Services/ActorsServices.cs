using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Data.UnitOfWork;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public class ActorsServices:IActorsService
   {
       private readonly IUnitOfWork _unitOfWork;
       public ActorsServices(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;

       }
        public bool AddActor(Actor actor)
        {
            _unitOfWork.ActorRepository.Add(actor);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteActor(Actor actor)
        {
            if (actor == null) return false;
            _unitOfWork.ActorRepository.Delete(actor);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActorRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActorRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActor(Actor actor)
        {
            _unitOfWork.ActorRepository.Edit(actor);
            _unitOfWork.Save();
            return true;
        }

        public Actor FindById(int id)
        {
            return _unitOfWork.ActorRepository.FindById(id);
        }

        public List<Actor> GetAllActor()
        {
            return _unitOfWork.ActorRepository.GetAll();
        }

        public List<Actor> FindBy(System.Linq.Expressions.Expression<Func<Actor, bool>> predicate)
        {
            return _unitOfWork.ActorRepository.FindBy(predicate);
        }
    }
}
