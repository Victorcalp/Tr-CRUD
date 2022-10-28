using Treinando_Crud.DataBase;
using Treinando_Crud.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Treinando_Crud.Services
{
    public class EmployeeService
    {

        public readonly Context _context;

        public EmployeeService(Context context)
        {
            _context = context;
        }

        public void Insert(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> FiendAll()
        {
            return _context.Employees.ToList();
        }

        public Employee FiendId(int? id)
        {
            var obj = _context.Employees.Include(x => x.Department).FirstOrDefault(x => x.Id == id);
            return obj;
        }

        public void Edit(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }
    }
}
