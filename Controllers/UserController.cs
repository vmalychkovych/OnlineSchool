using BookShop.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using OnlineSchool.Models;

namespace OnlineSchool.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            ViewBag.ActivePage = "User";

            return View(GetAllUser());
        }

		public List<User> GetAllUser()
		{
			List<User> objProductList = _unitOfWork.UserRepository.GetAll(includeProperties: "Role").ToList();
            return objProductList;
		}
	}
}
