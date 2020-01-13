using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ExamControl.Authorization.Roles;
using ExamControl.Authorization.Users;
using ExamControl.MultiTenancy;

namespace ExamControl.EntityFrameworkCore
{
    public class ExamControlDbContext : AbpZeroDbContext<Tenant, Role, User, ExamControlDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExamControlDbContext(DbContextOptions<ExamControlDbContext> options)
            : base(options)
        {
        }
    }
}
