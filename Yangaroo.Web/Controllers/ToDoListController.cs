using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yangaroo.Web.Models;
using Yangaroo.Web.Repository;

namespace Yangaroo.Web.Controllers
{
    public class ToDoListController : Controller
    {
        private IToDoListRepository _repository;
        [HttpGet]
        public ActionResult Index()
        {
            _repository = new ToDoListRepository();
            var data = _repository.GetItems();
            return View(data);
        }
        [HttpPost]
        public JsonResult AddItem(string item)
        {
            _repository = new ToDoListRepository();
            bool isSuccess = _repository.AddItem(new ToDoItem { ListItem = item });
            if (isSuccess)
            {
                return Json(new { result = true, data = _repository.GetItems() });
            }
            return Json(new { result = false });
        }


    }
}