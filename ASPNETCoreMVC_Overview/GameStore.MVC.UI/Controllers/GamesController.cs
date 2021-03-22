using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.MVC.UI.Data;
using GameStore.Shared.Entities;

namespace GameStore.MVC.UI.Controllers
{
    public class GamesController : Controller
    {
        

        public GamesController()
        {
            
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {

            //Liste können wir via WebAPI auch bekommen 

            return View(/*await _context.Game.ToListAsync()*/);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //MUSS ERSETZT WERDEN mit WEBAPI CALL
            //var game = await _context.Game
            //    .FirstOrDefaultAsync(m => m.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Genre,Price")] Game game)
        {
            if (ModelState.IsValid)
            {

                //MUSS ERSETZT WERDEN mit WEBAPI CALL
                //_context.Add(game);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //MUSS ERSETZT WERDEN mit WEBAPI CALL
            //var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Genre,Price")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //MUSS ERSETZT WERDEN mit WEBAPI CALL
                    //_context.Update(game);
                    //await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                   
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id) // Ist wir RazorPages-Details ->Get Methode
        {
            if (id == null)
            {
                return NotFound();
            }

            //var game = await _context.Game
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //MUSS ERSETZT WERDEN mit WEBAPI CALL
            //var game = await _context.Game.FindAsync(id);
            //_context.Game.Remove(game);
            //await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        
    }
}
