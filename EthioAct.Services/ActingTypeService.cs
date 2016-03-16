using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class ActingTypeService:IActingTypeService
   {

        private readonly IUnitOfWork _unitOfWork;

       public ActingTypeService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }
        public bool AddActingType(ActingType actingType)
        {
            _unitOfWork.ActingTypeRepository.Add(actingType);
            _unitOfWork.Save();
            return true;
        }

        public bool DeleteActingType(ActingType actingType)
        {
            if (actingType == null) return false;
            _unitOfWork.ActingTypeRepository.Delete(actingType);
            _unitOfWork.Save();
            return true;

        }

        public bool DeleteById(int id)
        {
            var entity = _unitOfWork.ActingTypeRepository.FindById(id);
            if (entity == null) return false;
            _unitOfWork.ActingTypeRepository.Delete(entity);
            _unitOfWork.Save();
            return true;
        }

        public bool EditActingType(ActingType actingType)
        {
            _unitOfWork.ActingTypeRepository.Edit(actingType);
            _unitOfWork.Save();
            return true;
        }

        public ActingType FindById(int id)
        {
            return _unitOfWork.ActingTypeRepository.FindById(id);
        }

        public List<ActingType> GetAllActingType()
        {
            return _unitOfWork.ActingTypeRepository.GetAll();
        }

        public List<ActingType> FindBy(System.Linq.Expressions.Expression<Func<ActingType, bool>> predicate)
        {
            return _unitOfWork.ActingTypeRepository.FindBy(predicate);
        }
    }
}
