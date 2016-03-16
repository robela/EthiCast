using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
    public interface IActingTypeService
    {
        bool AddActingType(ActingType actingType);
        bool DeleteActingType(ActingType actingType);
        bool DeleteById(int id);
        bool EditActingType(ActingType actingType);
        ActingType FindById(int id);
        List<ActingType> GetAllActingType();
        List<ActingType> FindBy(Expression<Func<ActingType, bool>> predicate);

    }
}