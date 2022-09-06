using DogMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogMVCProject.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        public IActionResult VetApplication(DogViewModel dog)
        {
            System.Console.WriteLine($" Dog: {dog.PetName} Mass: {dog.MassOfDog} Age: {dog.AgeOfDog} Dog Owner: {dog.Name} was saved in database");
            
            //ModelState.Clear();
            return VetApplication();
        }
    }
}
