using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVCApp.Models
{
    public class DbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        //Здесь, используя переменную типа ApplicationDbContext, 
        //мы можем получить доступ к DbSet для каждой «таблицы» и 
        //вставлять данные для начальной инициализации 
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
        }
    }
}