namespace StoreAssignment.Models.Products
{
    using System;
    public class FoodProductModel : PerishableProductModel
    {
        public FoodProductModel(string name, string brand, decimal price, double quantity, DateTime exDate)
            :base(name,brand,price,quantity,exDate)
        {

        }

        public override string Type => "Food";
    }
}
