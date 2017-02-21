using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM2
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HomePageUrl { get; set; }
        public List<UpdateModel> UpdateModels { get; set; }
      
    }
}
