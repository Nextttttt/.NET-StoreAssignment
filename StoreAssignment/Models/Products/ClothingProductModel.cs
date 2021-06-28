namespace StoreAssignment.Models.Products
{
    using StoreAssignment.Constants;
    using System;
    class ClothingProductModel : ProductModel
    {
        private string size;
        private readonly string colour;
        public ClothingProductModel(string name, string brand, decimal price, double quantity, string size, string colour)
            :base(name,brand,price,quantity)
        {
            this.Size = size;
            this.Colour = colour;
        }
        //Sunday - 0 Saturday - 6
        public override int DiscountCalc(DateTime curDate)
        {
            int discountPersents = 0;
            if((int)curDate.DayOfWeek >= 1 && (int)curDate.DayOfWeek <= 5)
            {
                discountPersents = 10;
            }

            return discountPersents;
        }

        public string Size 
        { 
            get
            {
                return this.size;
            }
            set
            {
                if(value == "XS" || value == "S" || value == "M" || value == "L" || value == "XL")
                {
                    this.size = value;
                }
                else 
                {
                    throw new ArgumentException(ErrorMessages.NOT_VALID_CLOTHING_SIZE_EXCEPTION);
                }
            }
        }

        public string Colour 
        { 
            get
            {
                return this.colour;
            }
            set
            {
                if(value.Length < 3 || value == null)
                {
                    throw new ArgumentException(ErrorMessages.OUT_OF_RANGE_EXCEPTION, Colour.ToString());
                }
            }
        }

        public override string Type => "Clothing";
    }
}
