namespace StoreAssignment.Controllers
{
    using StoreAssignment.Factories;
    using StoreAssignment.Models.Products;
    using System;
    using System.Collections.Generic;

    public static class Engine
    {
       
        public static void Run()
        {
            Client client = new Client();
            Cashier cashier = new Cashier();
            List<ProductModel> cart = client.FillCart();
            cashier.PrintReceipt(cart, new DateTime(2021,6,14,12,34,56));

        }
       
    }
}
