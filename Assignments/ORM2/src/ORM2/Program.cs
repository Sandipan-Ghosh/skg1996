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
                 db.ProductModels.Add(new ProductModel
                 {

                     Name = "Dove",
                     Description = "Female Shampoo",
                     HomePageUrl = "https://www.dove.com",
                 });
                 db.ProductModels.Add(new ProductModel
                 {

                     Name = "Clear",
                     Description = "Male Shampoo",
                     HomePageUrl = "https://www.clear.com",
                 });
                 db.UpdateModels.Add(new UpdateModel
                 {

                     Id=1,
                     Name = "tressemme-advanced",
                     Description = "Shampoo For Both",
                 });
                 db.UpdateModels.Add(new UpdateModel
                 {
                     Id=3,
                     Name = "Clear-advanced",
                     Description = "Male Shampoo",
                 });
                 db.UpdateModels.Add(new UpdateModel
                 {

                     Id = 2,
                     Name = "dove-advanced",
                     Description = "Female Shampoo",
                 });
                db.ProductModels.Update(new ProductModel
                {
                    Id = 8,
                    Name = "head & shoulders",
                    Description = "Shampoo for head and shoulders",
                    HomePageUrl="https://www.Headandshoulders.com"
                });
                db.UpdateModels.Update(new UpdateModel
                 {
                     UpdateId = 2,
                     Id=2,
                     Name = "dove_child_special",
                     Description = "Baby Shampoo",
                 });
                db.UpdateModels.Remove(new UpdateModel
                {
                    UpdateId = 2,
                    Id = 2,
                    Name = "dove_child_special",
                    Description = "Baby Shampoo",
                });
                db.ProductModels.Remove(new ProductModel
                {
                    Id = 2,
                    //Name = "Dove",
                    //Description = "Female Shampoo",
                });


                var count = db.SaveChanges();
                Console.WriteLine("{0} record saved to detabase", count);
                Console.WriteLine();
                Console.WriteLine("All products in database");
                foreach(var ProductModel in db.ProductModels)
                {
                    Console.WriteLine(" - {0}", ProductModel.HomePageUrl);
                }
            }
        }
    }
}
