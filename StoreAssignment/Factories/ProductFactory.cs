namespace StoreAssignment.Factories
{
    using Constants;
    using Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ProductFactory
    {

        public ProductModel Create(string type, string name, string brand, decimal price, double quantity, DateTime exDate)
        {
             ProductModel product;

            if(type == "food" || type == "Food")
            {
                product = new FoodProductModel(name,brand,price,quantity,exDate);
            }
            else if(type == "beverage" || type == "Beverage")
            {
                product = new BeverageProductModel(name, brand, price,quantity, exDate);
            }
            else
            {
                throw new ArgumentException(ErrorMessages.NOT_VALID_TYPE_EXCEPTION);
            }


            return product;
        }

        public ProductModel Create(string type, string name, string brand, decimal price, double quantity, string size, string color)
        {
            ProductModel product;

            if(type == "Clothing" || type == "clothing")
            {
                product = new ClothingProductModel(name, brand, price,quantity, size, color);
            }
            else
            {
                throw new ArgumentException(ErrorMessages.NOT_VALID_TYPE_EXCEPTION);
            }


            return product;
        }

        public ProductModel Create(string type, string name, string brand, decimal price, double quantity, string model, DateTime prDate, double weight)
        {
            ProductModel product;

            if(type == "appliance" || type == "Appliance")
            {
                product = new ApplianceProductModel(name, brand, price, quantity, model, prDate, weight);
            }
            else
            {
                throw new ArgumentException(ErrorMessages.NOT_VALID_TYPE_EXCEPTION);
            }

            return product;
        }

    }
}
