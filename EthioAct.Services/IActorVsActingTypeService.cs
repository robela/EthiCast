using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
    public interface IActorVsActingTypeService
    {
        bool AddActorVsActingType(ActorVsActingType actorVsActingType);
        bool DeleteActorVsActingType(ActorVsActingType actorVsActingType);
        bool DeleteById(int id);
        bool EditActorVsActingType(ActorVsActingType actorVsActingType);
        ActorVsActingType FindById(int id);
        List<ActorVsActingType> GetAllActorVsActingType();
        List<ActorVsActingType> FindBy(Expression<Func<ActorVsActingType, bool>> predicate);
    }
} 
