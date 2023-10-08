using BookShop.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using OnlineSchool.Models;

namespace OnlineSchool.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LoginController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Log(string login, string password)
        {   
            if(_unitOfWork.UserRepository.Get(u => u.Login == login) == null)
            {
                return NotFound();
            };

            if(_unitOfWork.UserRepository.Get(u => u.Login == login).Password == password)
            {
                return RedirectToAction("Index", "Home");
            }

            return NotFound();
        }
    }
}
