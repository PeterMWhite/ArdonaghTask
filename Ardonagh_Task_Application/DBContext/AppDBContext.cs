using Ardonagh_Task_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Ardonagh_Task_Application.DBContext
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<CustomerRecord> CustomerRecords { get; set; }
    }
}
