using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Infrastructure.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<CourseEntity> Courses { get; set; }

    public DbSet<SubscriberEntity> Subscribers { get; set; }




    public DbSet<CourseDetailEntity> CourseDetails { get; set; }

    public DbSet<ProgramDetailEntity> ProgramDetails { get; set; }
}
