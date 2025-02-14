﻿using Newtonsoft.Json.Linq;
using SMSTech.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SMSTech.Controllers
{
    public class RoleController : Controller
    {
        SMST4MEntities1 db = new SMST4MEntities1();
        // GET: Role

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetRole()
        {
            var Role = db.Roles.ToList();
            return Json(Role,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddRoles()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Role data)
        {
            Role role = new Role();

            role.Name = data.Name;
            role.Type = data.Type;
            db.Roles.Add(role);
            db.SaveChanges();
            return Json("Saved Successfully");
        }


    }
}