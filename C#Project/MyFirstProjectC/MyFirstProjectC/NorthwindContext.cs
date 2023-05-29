using MyFirstProjectC.Entities;
using System.Data.Entity;

namespace MyFirstProjectC
{
    public class NorthwindContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Product Classini Databasedeki Products tablosuna bagliyor.Ayrica mapping yapmadigimiz surece
    }
}
