namespace StoreAssignment.Models.Products
{
    using Constants;
    using System;

    public abstract class PerishableProductModel : ProductModel
    {
        private DateTime expirationDate;

        public PerishableProductModel(string name, string brand, decimal price, double quantity, DateTime exDate)
            :base(name,brand,price,quantity)
        {
            this.ExpirationDate = exDate;
        }
        public override string ToString()
        {
            return $"{Name} - {Brand}";
        }
        public override decimal DiscountCalc(DateTime curDate)
        {
            int discountPersents = 0;

            TimeSpan span = curDate - this.expirationDate;
        
            if((int)span.TotalDays <= 5 && (int)span.TotalDays > 0)
            {
                discountPersents = 10;
            }
            else if ((int)span.TotalDays == 0)
            {
                discountPersents = 50;
            }
            else
            {
                discountPersents = 0;
            }


            return discountPersents;
        }

        public DateTime ExpirationDate 
        { 
            get
            {
                return expirationDate;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException(ErrorMessages.NULL_EXCEPTION,ExpirationDate.ToString());
                }
                else
                {
                    expirationDate = value;
                }
            }
        }

    }
}
