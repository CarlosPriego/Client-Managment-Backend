using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientManagment.Models
{
    [Table("Clientes")]
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public required String Name { get; set; }
        public required String Surname { get; set; }
        public required String Job { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }


    }
}
