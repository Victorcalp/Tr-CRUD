namespace Treinando_Crud.Models
{
    public abstract class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int Idade { get { var temp = DateTime.Now.Year - BirthDate.Year; return temp; } }
        public decimal CPF { get; private set; }

        public Users() { }
        public Users(int id, string name, DateTime birthDate, string email, decimal cPF)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Email = email;
            CPF = cPF;
        }
    }
}
