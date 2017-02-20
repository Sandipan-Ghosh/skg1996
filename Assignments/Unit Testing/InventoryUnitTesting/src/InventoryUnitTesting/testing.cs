using System.Collections.Generic;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;

        #region Constructor
        public Testing()
        {
            
        }
        #endregion
        [Fact]
        public void WhenAddingProductToInventory_InventoryListShouldbeIncreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 6,
                ProductId = 5,
                Quantity = 5,

            };

            var prgm1 = new Program();
            var list = prgm1.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);
        }

        [Fact]
        public void WhenRemovingProductFromInventory_InventoryListShouldbeDecreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 3,
                ProductId = 3,
            };
            var prgm2 = new Program();
            var list = prgm2.DeleteInventory(inventory);
            Assert.Equal(3, db.InventoryList.Count);
        }
        [Fact]
        public void WhenProductDetailsChangedInInventory_InventoryListShouldBeUpdated()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 4,
                ProductId = 4,
                 Quantity= 2,
            };
            var prgm3 = new Program();

            Assert.Equal(2, prgm3.UpdateInventory(inventory).Quantity);
        }
        [Fact]
        public void WhenTheUserCheckOut_PassingTest()
        {
            var inventorySize =new Database().InventoryList.Count;

            List<Cart> cartList = new List<Cart>();

            var cart = new Cart()
            {
                Id = 2,
                ProductId = 2,
                OrderedQuantity = 23
            };

            cartList.Add(cart);

            cart = new Cart()
            {
                Id = 2,
                ProductId = 2,
                OrderedQuantity = 23,
            };

            cartList.Add(cart);
            var prgm4 = new Program();
            Assert.Equal(inventorySize, prgm4.CheckOutTheCartandUpdateInventory(cartList).Count);
        }
        [Fact]
        public void WhenProductDetailsChangedInInventory_InventoryListShouldBeUpdated_FailingCase()
        {
            var inventory = new Inventory()
            {
                Id = 4,
                ProductId = 4,
                Quantity = 2,
            };
            var prgm3 = new Program();

            Assert.NotEqual(2, prgm3.UpdateInventory(inventory).Quantity);
        }

    }
}
