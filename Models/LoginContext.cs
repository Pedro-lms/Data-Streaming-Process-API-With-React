using System.Data.Entity;

namespace Data_Streaming_Process_API_With_React.Models
{
    public class LoginContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
    }
}
