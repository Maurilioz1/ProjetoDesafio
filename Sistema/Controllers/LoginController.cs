using Sistema.DBModel;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class LoginController : Controller
    {
        UserDBEntities objUserDBEntities = new UserDBEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registro()
        {
            UserModel objUserModel = new UserModel();
            return View(objUserModel);
        }

        [HttpPost]
        public ActionResult Registro(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                if (!UsuarioDAL.VerificaEmail(objUserModel.Email))
                {
                    User objUser = new DBModel.User();
                    objUser.Email = objUserModel.Email;
                    objUser.Nome = objUserModel.Nome;
                    objUser.Senha = objUserModel.Senha;
                    objUserDBEntities.Users.Add(objUser);
                    objUserDBEntities.SaveChanges();
                    objUserModel = new UserModel();
                    objUserModel.SuccessMessage = "Usuário registrado com sucesso!";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email já cadastrado!");
                    return View();
                }
            }

            return View();
        }

        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                if (objUserDBEntities.Users.Where(m => m.Email == objLoginModel.Email && m.Senha == objLoginModel.Senha).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Email ou senha inválida!");
                    return View();
                }
                else
                {
                    Session["Email"] = objLoginModel.Email;
                    return RedirectToAction("Index", "Login");
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}