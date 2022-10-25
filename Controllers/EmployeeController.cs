﻿using Microsoft.AspNetCore.Mvc;
using Treinando_Crud.Models;
using Treinando_Crud.Models.ViewsModels;
using Treinando_Crud.Services;

namespace Treinando_Crud.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly EmployeeService _employeeService;
        public readonly DepartmentService _departmentService;

        public EmployeeController(EmployeeService employeeService, DepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _employeeService.FiendAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departments = _departmentService.FiendAll();
            var viewModel = new EmployeeFormViewModel { Departments = departments };
            return View(viewModel);
        }   

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Insert(employee);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit()
        {
            //var list = _employeeService.FiendAll();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employeeService.Edit(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
