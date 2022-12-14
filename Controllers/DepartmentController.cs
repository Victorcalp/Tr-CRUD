using Microsoft.AspNetCore.Mvc;
using Treinando_Crud.DataBase;
using Treinando_Crud.Models;
using Treinando_Crud.Services;

namespace Treinando_Crud.Controllers
{
    public class DepartmentController : Controller
    {
        public readonly Context _context;
        public readonly DepartmentService _departmentService;

        public DepartmentController(Context context, DepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _departmentService.FiendAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            _departmentService.Insert(department);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            var obj = _departmentService.FiendId(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            _departmentService.Edit(department);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var obj = _departmentService.FiendId(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Department department)
        {
            _departmentService.Delete(department);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            var obj = _departmentService.FiendId(id);
            return View(obj);
        }
    }
}
