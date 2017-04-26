using Microsoft.EntityFrameworkCore;

namespace TaskAPI.Models
{
    public class TaskContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskList> TaskLists { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
     
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
