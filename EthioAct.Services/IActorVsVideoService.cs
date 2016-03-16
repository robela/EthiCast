using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IActorVsVideoService
    {
       bool AddActorVsVideo(ActorVSVideo actorVsVideo);
       bool DeleteActorVsVideo(ActorVSVideo actorVsVideo);
        bool DeleteById(int id);
        bool EditActorVsVideo(ActorVSVideo actorVsVideo);
        ActorVSVideo FindById(int id);
        List<ActorVSVideo> GetAllActorVsVideo();
        List<ActorVSVideo> FindBy(Expression<Func<ActorVSVideo, bool>> predicate);

    }
}
