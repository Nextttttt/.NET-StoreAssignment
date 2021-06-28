namespace StoreAssignment.Models.Products
{
    using System;

    class BeverageProductModel : PerishableProductModel
    {
        public BeverageProductModel(string name, string brand, decimal price, double quantity, DateTime exDate)
            : base(name, brand, price,quantity, exDate)
        {

        }
        public override string Type => "Beverage";

    }
}
