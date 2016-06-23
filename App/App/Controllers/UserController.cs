using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//References
using App.BLL;
using App.Entities;


namespace App.Controllers
{
    public class UserController : Controller
    {
        private UsersBLL _userBLL;

        public UserController()
        {
            _userBLL = new UsersBLL();
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Users user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _userBLL.Add(user);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("Name", "Already Exist");
                }
            }
            return View();
        }


        public ActionResult AllUsersLinQ()
        {
            var UserList = _userBLL.GetAllUsersLinQ();
            return View(UserList);
        }

        public ActionResult ListUsersUsingLambda()
        {
            var Userlist = _userBLL.GetAllUsersLambda();
                return View(Userlist);
        }


    }
}