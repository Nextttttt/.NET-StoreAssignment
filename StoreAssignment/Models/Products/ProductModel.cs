namespace StoreAssignment.Models.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Constants;
    public abstract class ProductModel : BaseModel
    {
        private string name;
        private string brand;
        private readonly decimal price;
        private readonly double quantity;

        public ProductModel(string name, string brand, decimal price, double quantity)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Quantity = quantity;
        }

        public abstract int DiscountCalc(DateTime curDate);
     

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException(ErrorMessages.OUT_OF_RANGE_EXCEPTION, Name.ToString());
                }

                else
                {
                    this.name = value;
                }
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException(ErrorMessages.OUT_OF_RANGE_EXCEPTION, Brand.ToString());
                }

                else
                {
                    this.brand = value;
                }
            }
        }

        public decimal Price 
        { 
            get
            {
                return this.price;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException(ErrorMessages.NEGATIVE_NUMBER_EXCEPTION, Price.ToString());
                }
            }
        }

        public double Quantity 
        { 
            get
            {
                return this.quantity;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(ErrorMessages.NEGATIVE_NUMBER_EXCEPTION, Quantity.ToString());
                }
            }

        }

        public abstract string Type { get; }
    }
}
