namespace Treinando_Crud.Models
{
    public class Employee : Users
    {
        public int DepartmentId { get; set; }
        public Employee(int id, string name, DateTime birthDate, string email, decimal cPF, int departmentId) : base(id, name, birthDate, email, cPF)
        {
            DepartmentId = departmentId;
        }
        public Employee() { }
    }
}
