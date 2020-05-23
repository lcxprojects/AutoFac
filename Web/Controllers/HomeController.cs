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
        public HomeController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public ActionResult Index()
        {
            var userModel = _userService.GetModel("085AC7C7-94BE-4A41-93C7-C207939714B9");

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