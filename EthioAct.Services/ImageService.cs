using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EthioAct.Models.Models;
using EthioAct.Data.UnitOfWork;

namespace EthioAct.Services
{
   public class ImageService:IImageService
   {
       private readonly IUnitOfWork _unitOfWork;

       public ImageService(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;

       }


       public bool AddImage(Image image)
       {
           _unitOfWork.ImageRepository.Add(image);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteImage(Image image)
       {
           if (image == null) return true;
           _unitOfWork.ImageRepository.Delete(image);
           _unitOfWork.Save();
           return true;
       }

       public bool DeleteById(int id)
       {
           var entity = _unitOfWork.ImageRepository.FindById(id);
           if (entity == null) return false;
           _unitOfWork.ImageRepository.Delete(entity);
           _unitOfWork.Save();
           return true;
       }

       public bool EditImage(Image image)
       {
           _unitOfWork.ImageRepository.Edit(image);
           _unitOfWork.Save();
           return true;
       }

       public Image FindById(int id)
       {
           return _unitOfWork.ImageRepository.FindById(id);
       }

       public List<Image> GetAllImage()
       {
           return _unitOfWork.ImageRepository.GetAll();
       }

       public List<Image> FindBy(System.Linq.Expressions.Expression<Func<Image, bool>> predicate)
       {
           return _unitOfWork.ImageRepository.FindBy(predicate);
       }
   }
}
