using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesApp.Data;
using SuperHeroesApp.Models;

namespace SuperHeroesApp.Controllers
{

    
    public class SuperHeroesController : Controller
    {


        public ApplicationDbContext _context;

        public SuperHeroesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SuperHeroesController
        public ActionResult Index()
        {
            // linq queriy to retireve all rows from tables var= someting


            var superHero = _context.SuperHeroes.ToList();

            return View(superHero);
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)

        {
            // linq queirys to find specfics row from table

            var superHero = _context.SuperHeroes.Where(ur => ur.Id == id).FirstOrDefault(); ;
                

            return View(superHero);
        }

        // GET: SuperHeroesController/Create
        public ActionResult Create()
        {



            return View();
        }

        // POST: SuperHeroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superhero)
        {
            //linq quiery to add the superhero into the database
            try
            {
                _context.SuperHeroes.Add(superhero);
                _context.SaveChanges();

                

                return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superhero)
        {

            //linq quiery to update the ifo into the database
            try
            {

                _context.SuperHeroes.Update(superhero);
                _context.SaveChanges();


                return RedirectToAction(nameof(Index));




            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SuperHero superhero)
        {

            
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
