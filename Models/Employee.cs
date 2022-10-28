using System.ComponentModel;

namespace Treinando_Crud.Models
{
    public class Employee : Users
    {
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Employee(int id, string name, DateTime birthDate, string email, decimal cPF, Department department) : base(id, name, birthDate, email, cPF)
        {
            Department = department;
        }
        public Employee() { }
    }
}
