using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{                   //Context sınıfımızı yazdık
    public class DataContext:DbContext
    {                            //Context sınıfımızı yazdık
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
        //Modeldeki sınıflar ile kod yazarken kullanıcamız isim arasındaki ilişki
        public DbSet<Value> Values { get; set; }
    }
}
