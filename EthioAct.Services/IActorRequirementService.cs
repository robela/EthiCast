using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IActorRequirementService
   {
       bool AddActorRequirement(ActorRequirement actorRequirement);
       bool DeleteActorRequirement(ActorRequirement actorRequirement);
       bool DeleteById(int id);
       bool EditActorRequirement(ActorRequirement actorRequirement);
       ActorRequirement FindById(int id);
       List<ActorRequirement> GetAllDonor();
       List<ActorRequirement> FindBy(Expression<Func<ActorRequirement, bool>> predicate);
   }
}
