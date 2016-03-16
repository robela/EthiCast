using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IActorVsImageService
    {
       bool AddActorVsImage(ActorVsImage actorVsImage);
        bool DeleteActorVsImage(ActorVsImage actorVsImage);
        bool DeleteById(int id);
        bool EditActorVsImage(ActorVsImage actorVsImage);
        ActorVsImage FindById(int id);
        List<ActorVsImage> GetAllActorVsImage();
        List<ActorVsImage> FindBy(Expression<Func<ActorVsImage, bool>> predicate);

    }
}
