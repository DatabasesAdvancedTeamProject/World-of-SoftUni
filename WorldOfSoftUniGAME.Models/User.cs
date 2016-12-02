namespace WorldOfSoftUniRPG.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class User
    {
        public User()
        {
            this.IsLogged = false;
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(450), Index(IsUnique = true)]
        public string UserName { get; set; }

        [Required, MinLength(5, ErrorMessage = "Your password must be at least 5 characters long!")]
        public string PasswordHash { get; set; }

        [RegularExpression(@"(^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$)")]
        public string Email { get; set; }

        public bool IsLogged { get; set; }
    }
}