using Data_Streaming_Process_API_With_React.Models;

namespace Data_Streaming_Process_API_With_React.Services
{
    public class LoginService
    {
        private readonly User _user;
        private readonly LoginContext _context;
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        public LoginService(User user, LoginContext context)
        { 
            _context = context;
            _user = user;
        }

        public User GetLogin()
        {
            return _user;
        }

        public User Login(string username, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            return user;
        }

        public User Register(string name, string email, string password)
        {
            var user = new User
            {
                Name = name,
                Email = email,
                Password = password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void ForgotPassword(string email)
        {
            if (_user == null)
                return;
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                // enviar email de recuperação de senha
            }
        }

    }
}
