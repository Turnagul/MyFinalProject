using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: db tabloları ile proje classlarını bağlamak ilişkilendirmek
    public class NortwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*base.OnConfiguring(optionsBuilder);*/// override on yazdığımızda ilk çıkan seçeneği seçtiğimizde böyle oluyor ve başlık kımı değişiyor.
            // bailık kısmı değiştikten sonra bu alan silinir.
            optionsBuilder.UseSqlServer(@"Server=175.45.2.12");// sql servera bu şekilde bağlantı sağlanır. Parantez içinde bir ıp görünür normalde
        }
    }
}
