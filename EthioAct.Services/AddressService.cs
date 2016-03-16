using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class AddressService:IAddressService
   {
       private readonly IUnitOfWork _unitOfWork;

       public AddressService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }

       public bool AddAddress(Address address)
       {
           _unitOfWork.AddressRepository.Add(address);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteDonor(Address address)
       {
           if (address == null) return true;
           _unitOfWork.AddressRepository.Delete(address);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteById(int id)
       {
           var entity = _unitOfWork.AddressRepository.FindById(id);
           if (entity == null) return false;
           _unitOfWork.AddressRepository.Delete(entity);
           _unitOfWork.Save();
           return true;
       }

       public bool EditDonor(Address address)
       {
           _unitOfWork.AddressRepository.Edit(address);
           _unitOfWork.Save();
           return true;
       }

       public Address FindById(int id)
       {
          return _unitOfWork.AddressRepository.FindById(id);
       }

       public List<Address> GetAllDonor()
       {
           return _unitOfWork.AddressRepository.GetAll();
       }

       public List<Address> FindBy(System.Linq.Expressions.Expression<Func<Address, bool>> predicate)
       {
           return _unitOfWork.AddressRepository.FindBy(predicate);
       }
   }
}
