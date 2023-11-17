using Microsoft.AspNetCore.Mvc;
using MVC_APU_FlowerShop2023.Models;
using MVC_APU_FlowerShop2023.Data;
using Microsoft.EntityFrameworkCore;

namespace MVC_APU_FlowerShop2023.Controllers
{
    public class SurveyController : Controller
    {
        private readonly MVC_APU_FlowerShop2023Context _context;
        public SurveyController(MVC_APU_FlowerShop2023Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddData()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddData(Survey survey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(survey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(survey);
        }
    }
}
