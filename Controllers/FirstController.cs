using database.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace database.Controllers
{
    public class FirstController : Controller
    {
        public readonly FirstDBContaxt _Db;
        public FirstController(FirstDBContaxt Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            var datalist = _Db.DataModels.ToList();
            return View(datalist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(data modle)
        {
            _Db.DataModels.Add(modle);
            _Db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _Db.DataModels.Where(x => x.Stdid == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit (data modle)
        {
            var data = _Db.DataModels.Where(x => x.Stdid == modle.Stdid).FirstOrDefault();
            if(data != null)
            {
                data.Stdid = modle.Stdid;
                data.Name = modle.Name;
                data.Email = modle.Email;
                data.Age = modle.Age;
                _Db.SaveChanges();

            }
            return View();
        }
        public ActionResult Details (int id)
        {
            var data = _Db.DataModels.Where(x => x.Stdid == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var ddata = _Db.DataModels.Where(x => x.Stdid == id).FirstOrDefault();
            _Db.DataModels.Remove(ddata);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
