using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Treinando_Crud.Models
{
    public abstract class Users
    {
        [DisplayName("Codigo")]
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        public int Idade { get { var temp = DateTime.Now.Year - BirthDate.Year; return temp; } }

        [EmailAddressAttribute]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString ="{0:000-000-000-00}")]
        public decimal CPF { get; set; }

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
