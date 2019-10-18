using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
            
    [HttpGet]    
    public ActionResult Index()
    {
      List<Stylists> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylists stylists)
    {
      _db.Stylists.Add(stylists);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Stylists thisStylist = _db.Stylists.FirstOrDefault(s => s.StylistsId == id);
      return View(thisStylist);
    }
     public ActionResult Delete(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(s => s.StylistsId == id);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(s => s.StylistsId == id);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(s => s.StylistsId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylists stylists)
    {
      _db.Entry(stylists).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}