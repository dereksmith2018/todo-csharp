using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [Route("/items")]
        public ActionResult Index()
        {
            List<Item> allItems =Item.GetAll();
            return View(allItems);
        }

        [Route("/items/form")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [Route("/items/new")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            myItem.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
          return new EmptyResult();
        }
        public ActionResult Index()
        {
          return View(0);
        }
    }
}
