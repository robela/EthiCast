using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IActorsService
    {
        bool AddActor(Actor actor);
        bool DeleteActor(Actor actor);
        bool DeleteById(int id);
        bool EditActor(Actor actor);
        Actor FindById(int id);
        List<Actor> GetAllActor();
        List<Actor> FindBy(Expression<Func<Actor, bool>> predicate);
    }
}
