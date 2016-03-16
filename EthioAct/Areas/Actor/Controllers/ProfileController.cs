using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EthioAct.Services;
using EthioAct.Data.UnitOfWork;
using EthioAct.Models.Models;
using EthioAct.Areas.Actor.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Security.Claims;
using EthioAct.Models;

namespace EthioAct.Areas.Actor.Controllers
{
    public class ProfileController : Controller
    {
        private UnitOfWork _unitOfWork=new UnitOfWork();
        private IActingTypeService _actingTypeService;
        private IActorsService _actorService;
        public ProfileController(IActingTypeService actingTypeService, IActorsService actorsService)
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
            
        {
            _actorService = actorsService;
        }
        public ProfileController(UserManager<ApplicationUser> userManager )
        {
            UserManager = userManager;
          
        }
        public ProfileController()
        {
            

        }
        public UserManager<ApplicationUser> UserManager { get; private set; }

        // GET: /Actor/Actor/
        public ActionResult Index()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());

            var actors = _actorService.FindBy(m => m.userId == user.Id).FirstOrDefault(); //_unitOfWork.ActorRepository.FindBy(m => m.userId == user.Id).FirstOrDefault();
            return View(actors);
        }

        //
        // GET: /Actor/Actor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Actor/Actor/Create
        public ActionResult Create()
        {
            var basicProfile = new ActorBasicProfileViewModel();

            return View(basicProfile);
        }

        //
        // POST: /Actor/Actor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ActorBasicProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user =  UserManager.FindById(User.Identity.GetUserId());
               
                if (user!=null)
                {
                    var actorProfile = new EthioAct.Models.Models.Actor
                    {
                        userId = user.Id,
                        firstName = model.firstName,
                        secondName = model.secondName,
                        lastName = model.lastName,
                        dateOfBirth = model.dateOfBirth,
                        gender = model.gender,
                        height = model.height,
                        weight = model.weight,
                        educationLevel = model.educationLevel,
                        addressId = model.addressId,
                        emailAddress = model.emailAddress
                    };
                    _unitOfWork.ActorRepository.Add(actorProfile);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                  
                }
                else
                {
                    ModelState.AddModelError("Errors", "User Doesn't exist");
                }
            }

            return View(model);
        }

        //
        // GET: /Actor/Actor/Edit/5
        public ActionResult Edit(int id)
        {
            var actor = _unitOfWork.ActorRepository.FindById(id);
            if(actor==null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        //
        // POST: /Actor/Actor/Edit/5
        [HttpPost]
        public ActionResult Edit(EthioAct.Models.Models.Actor actor)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ActorRepository.Edit(actor);
                return RedirectToAction("index");
            }
            return View(actor);
        }

        //
        // GET: /Actor/Actor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Actor/Actor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
