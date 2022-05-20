using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class AccessController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            try
            {
                using (var db= new Models.ProductEntities())
                {
                    var oUser = (from d in db.usuario
                                 where d.email == User && d.password == Pass.Trim()
                                 select d).FirstOrDefault();
                    if(oUser == null)
                    {
                        ViewBag.Error = "Usuario/Contraseña comido por los ratones (no existente)";

                        return View();
                    }

                    Session["User"] = oUser;

                }



                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }















    }
}