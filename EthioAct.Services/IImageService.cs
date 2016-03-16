using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;

namespace EthioAct.Services
{
   public interface IImageService
    {
        bool AddImage(Image image);
        bool DeleteImage(Image image);
        bool DeleteById(int id);
        bool EditImage(Image image);
        Image FindById(int id);
        List<Image> GetAllImage();
        List<Image> FindBy(Expression<Func<Image, bool>> predicate);
    }
}
