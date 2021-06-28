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

        public override int DiscountCalc(DateTime curDate)
        {
            int discountPersents = 0;

            TimeSpan span = curDate - this.expirationDate;
            if(span.TotalDays <= 5)
            {
                if(span.TotalDays == 0)
                {
                    discountPersents = 50;
                }

                discountPersents = 10;
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
