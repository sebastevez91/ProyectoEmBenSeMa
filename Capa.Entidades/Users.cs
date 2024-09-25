using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public byte? ChangePassword { get; set; } = default!;

        public Users(int idUser, string username, string password)
        {
            IdUser = idUser;
            Username = username;
            UserPassword = password;
        }

        public Users()
        {
        }
    }
}
