using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Database.Migrate();
                db.ProductModels.Add(new ProductModel
                {

                    Name = "Tressemme",
                    Description = "Shampoo For All",
                    HomePageUrl = "https://www.tressemme.com",
                });
                var count = db.SaveChanges();
                db.ProductModels.Add(new ProductModel
                {

                    Name = "Dove",
                    Description = "Female Shampoo",
                    HomePageUrl = "https://www.dove.com",
                });
                count = db.SaveChanges();
                db.ProductModels.Add(new ProductModel
                {

                    Name = "Clear",
                    Description = "Male Shampoo",
                    HomePageUrl = "https://www.clear.com",
                });
                count = db.SaveChanges();
                db.UpdateModels.Add(new UpdateModel
                {


                    Name = "tressemme-advanced",
                    Description = "Shampoo For Both",
                    Id=1
                });
                count = db.SaveChanges();
                db.UpdateModels.Add(new UpdateModel
                {

                    Name = "Clear-advanced",
                    Description = "Male Shampoo",
                    Id=2
                });
                count = db.SaveChanges();
                db.UpdateModels.Add(new UpdateModel
                {


                    Name = "dove-advanced",
                    Description = "Female Shampoo",
                    Id=3
                });
                count = db.SaveChanges();

            }
            using (var db = new BloggingContext())
            {
                db.ProductModels.Update(new ProductModel
                {
                    Id = 1,
                    Name = "head & shoulders",
                    Description = "Shampoo for head and shoulders",
                    HomePageUrl = "https://www.Headandshoulders.com"
                });
                var count = db.SaveChanges();
                db.UpdateModels.Update(new UpdateModel
                {
                    UpdateId = 2,
                    Id = 2,
                    Name = "dove_child_special",
                    Description = "Baby Shampoo",
                });
                count = db.SaveChanges();

            }
            using (var db = new BloggingContext())
            {
                db.UpdateModels.Remove(new UpdateModel
                {
                    UpdateId = 2,
                    Id = 2,
                    Name = "dove_child_special",
                    Description = "Baby Shampoo",
                });
                var count = db.SaveChanges();
                db.ProductModels.Remove(new ProductModel
                {
                    Id = 2,
                    Name = "Dove",
                    Description = "Female Shampoo",
                });
                count = db.SaveChanges();

            }
            Console.Read();
            }
        }
    }

