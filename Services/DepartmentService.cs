using Treinando_Crud.DataBase;
using Treinando_Crud.Models;
using System.Linq;

namespace Treinando_Crud.Services
{
    public class DepartmentService
    {
        public readonly Context _context;
        public DepartmentService(Context context)
        {
            _context = context;
        }
        public void Insert(Department department)
        {
            _context.Add(department);
            _context.SaveChanges();
        }

        public List<Department> FiendAll()
        {
            return _context.Departments.OrderBy(x => x.Id).ToList();
        }

        public Department FiendId(int? id)
        {
            var list = _context.Departments.FirstOrDefault(x => x.Id == id);
            return list;
        }
        public void Edit(Department department)
        {
            _context.Update(department);
            _context.SaveChanges();
        }

        public void Delete(Department department)
        {
            _context.Remove(department);
            _context.SaveChanges();
        }
    }
}
