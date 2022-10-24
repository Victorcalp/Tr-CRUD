using Treinando_Crud.DataBase;
using Treinando_Crud.Models;
using System.Linq;

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

        public void Edit(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }
    }
}
