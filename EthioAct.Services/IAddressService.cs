using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IAddressService
    {
        bool AddAddress(Address address);
        bool DeleteDonor(Address address);
        bool DeleteById(int id);
        bool EditDonor(Address address);
        Address FindById(int id);
        List<Address> GetAllDonor();
        List<Address> FindBy(Expression<Func<Address, bool>> predicate);
    }
}
