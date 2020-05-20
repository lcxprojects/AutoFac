using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoFac.Model;
using AutoFac.Service.IService;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IBaseService<User> _baseService;
        public HomeController(IUserService userService, IRoleService roleService, IBaseService<User> baseService)
        {
            _userService = userService;
            _roleService = roleService;
            _baseService = baseService;
        }

        public ActionResult Index()
        {
            var userModel = _baseService.GetModel("085AC7C7-94BE-4A41-93C7-C207939714B9");

            var userList = _userService.GetModelList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}