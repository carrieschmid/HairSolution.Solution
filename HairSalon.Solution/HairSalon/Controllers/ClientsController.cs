using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    
    {
        List<Clients> model = _db.Clients.Include(c => c.Stylists).ToList();
        return View(model);
    }
    

    public ActionResult Create()
    {
        ViewBag.StylistsId = new SelectList(_db.Stylists, "StylistsId", "FirstName", "LastName");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Clients client)
    {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Clients thisClient = _db.Clients.FirstOrDefault(c => c.ClientsId == id);
        return View(thisClient);
    }
        public ActionResult Delete(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(c => c.ClientsId == id);
        return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(c => c.ClientsId == id);
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
        public ActionResult Edit(int id)
    {
        var thisClient = _db.Clients.FirstOrDefault(c => c.ClientsId == id);
        ViewBag.StylistsId = new SelectList(_db.Stylists, "StylistsId", "FirstName", "LastName");
        return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Clients client)
    {
        _db.Entry(client).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

  }
}