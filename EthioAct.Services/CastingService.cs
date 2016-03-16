using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class CastingService :ICastingService
   {
       private readonly IUnitOfWork _unitOfWork;

       public CastingService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }


       public bool AddCasting(casting casting)
       {
           _unitOfWork.CastingRepository.Add(casting);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteCasting(casting casting)
       {
           if (casting == null) return false;
           _unitOfWork.CastingRepository.Delete(casting);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteById(int id)
       {
           var entity = _unitOfWork.CastingRepository.FindById(id);
           if (entity == null) return false;
           _unitOfWork.CastingRepository.Delete(entity);
           _unitOfWork.Save();
           return true;
       }

       public bool EditCasting(casting casting)
       {
           _unitOfWork.CastingRepository.Edit(casting);
           _unitOfWork.Save();
           return true;
       }

       public casting FindById(int id)
       {
           return _unitOfWork.CastingRepository.FindById(id);
       }

       public List<casting> GetAllCasting()
       {
           return _unitOfWork.CastingRepository.GetAll();
       }

       public List<casting> FindBy(System.Linq.Expressions.Expression<Func<casting, bool>> predicate)
       {
           return _unitOfWork.CastingRepository.FindBy(predicate);
       }
   }
}
