using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface ICastingService
    {
        bool AddCasting(casting casting);
        bool DeleteCasting(casting casting);
        bool DeleteById(int id);
        bool EditCasting(casting donor);
        casting FindById(int id);
        List<casting> GetAllCasting();
        List<casting> FindBy(Expression<Func<casting, bool>> predicate);
    }
}
