namespace Treinando_Crud.Models
{
    public class Employee : Users
    {
        public Employee(int id, string name, DateTime birthDate, string email, decimal cPF) : base(id, name, birthDate, email, cPF)
        {
        }
        public Employee() { }
    }
}
