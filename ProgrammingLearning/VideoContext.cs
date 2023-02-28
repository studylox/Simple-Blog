using Microsoft.EntityFrameworkCore;

using ProgrammingLearning.Models;

namespace ProgrammingLearning
{
    public class VideoContext:DbContext
    {
        public VideoContext(DbContextOptions<VideoContext>options):base(options)
        {

        }
       

        public DbSet<Video> Videos { get; set; }
        public DbSet<User>Users { get; set; }

        public DbSet<Comment>Comments { get; set; }

       
      

    }
}
