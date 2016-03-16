using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IActorVsTalentService
    {
       bool AddActorVsTalent(ActorVsTalent actorVsTalent);
       bool DeleteActorVsTalent(ActorVsTalent actorVsTalent);
        bool DeleteById(int id);
        bool EditActorVsTalent(ActorVsTalent actorVsTalent);
        ActorVsTalent FindById(int id);
        List<ActorVsTalent> GetAllActorVsTalent();
        List<ActorVsTalent> FindBy(Expression<Func<ActorVsTalent, bool>> predicate);
    }
}
