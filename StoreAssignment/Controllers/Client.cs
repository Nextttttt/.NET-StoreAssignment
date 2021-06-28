namespace StoreAssignment.Controllers
{
    using StoreAssignment.Factories;
    using StoreAssignment.Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Client
    {
        private readonly ProductFactory productFactory;
        private readonly List<ProductModel> cart;

        public Client()
        {
            this.productFactory = new ProductFactory();
            this.cart = new List<ProductModel>();
        }
        public List<ProductModel> FillCart()
        {
            cart.Add(this.productFactory.Create("food", "apples", "BrandA", (decimal)1.5 ,2.45 , new DateTime(2021, 6, 14)));
            cart.Add(this.productFactory.Create("beverage", "milk", "BrandM", (decimal)0.99 ,3 , new DateTime(2022, 2, 2)));
            cart.Add(this.productFactory.Create("clothing", "T-shirt", "BrandT", (decimal)15.99 ,2 , "M", "violet"));
            cart.Add(this.productFactory.Create("appliance", "laptop", "BrandL", (decimal)2345 ,1 , "ModelL", new DateTime(2021, 3, 3), 1.125));

            foreach(var item in cart)
            {
                Console.WriteLine(item.Price);
            }
            Console.WriteLine();
            Console.WriteLine();

            return cart;
        }

    }
}
