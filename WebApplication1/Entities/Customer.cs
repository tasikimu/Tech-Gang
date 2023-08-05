using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstanme { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}
