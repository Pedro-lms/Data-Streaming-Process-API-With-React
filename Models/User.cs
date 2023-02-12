using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Streaming_Process_API_With_React.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Column (name:"telefone")]
        public string PhoneNumber { get; set; }
        [Column (name:"CEP")]
        public string Address { get; set; }
        
    }
}
