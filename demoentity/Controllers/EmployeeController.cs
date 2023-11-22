using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using democlasslib;
using demoentity.Models;

namespace demoentity.Controllers
{
    public class EmployeeController : Controller
    {
        democlasslib.dassEntities db= new dassEntities();
        dassEntities n= new dassEntities();

        // GET: Employee
        public ActionResult Index()
        {
            List<Employer>employers=db.Employers.ToList();
            List<Empmodel>emplist=new List<Empmodel>();
            foreach(var item in employers)
            {
                Empmodel model = new Empmodel();
                model.Companyid = item.companyid;
                model.CompanyName = item.companyname;
                model.City = item.city;
                emplist.Add(model);

            }
            return View(emplist);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employer E=db.Employers.Find(id);
            Empmodel model = new Empmodel();
            model.Companyid = E.companyid;
            model.CompanyName = E.companyname;
            model.City = E.city;
            return View(model);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Empmodel model = new Empmodel();
                model.Companyid = Convert.ToInt32(collection["Companyid"]);
                model.CompanyName = Convert.ToString(collection["CompanyName"]);
                model.City = Convert.ToString(collection["City"]);

                Employer E=new Employer();
                E.companyname = model.CompanyName;
                E.city=model.City;
                db.Employers.Add(E);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employer E1 = db.Employers.Find(id);
            Empmodel empmodel = new Empmodel();
            empmodel.Companyid=E1.companyid;
            empmodel.CompanyName=E1.companyname;
            empmodel.City=E1.city;
            return View(empmodel);


        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Employer E1=db.Employers.Find(id);
                E1.companyname = collection["CompanyName"].ToString() ;
                E1.city = collection["City"].ToString();
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employer E1 = db.Employers.Find(id);
            Empmodel empmodel = new Empmodel();
            empmodel.Companyid = E1.companyid;
            empmodel.CompanyName = E1.companyname;
            empmodel.City = E1.city;
            return View(empmodel);
            
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
               
                Employer E=db.Employers.Find(id);
                db.Employers.Remove(E);
                db.SaveChanges();


                return RedirectToAction("Index");


               
            }
            catch
            {
                return View();
            }
        }
    }
}
