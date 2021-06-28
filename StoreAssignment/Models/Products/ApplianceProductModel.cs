namespace StoreAssignment.Models.Products
{
    using Constants;
    using System;

    class ApplianceProductModel : ProductModel
    {
        private string model;
        private DateTime productionDate;
        private double weight;

        public ApplianceProductModel(string name, string brand, decimal price, double quantity, string model, DateTime prDate, double weight)
            : base(name, brand, price,quantity)
        {
            this.Model = model;
            this.ProductionDate = prDate;
            this.Weight = weight;
        }

        public override int DiscountCalc(DateTime curDate)
        {
            int discountPercents = 0;

            if(((int)curDate.DayOfWeek == 0 || (int)curDate.DayOfWeek == 6) && Price > 999)
            {
                discountPercents = 5;
            }

            return discountPercents;
        }

        public string Model 
        { 
            get
            {
                return this.model;
            }
            set
            {
                if(value.Length < 0)
                {
                    throw new ArgumentException(ErrorMessages.OUT_OF_RANGE_EXCEPTION, Model.ToString());
                }

                this.model = value;
            }
        }

        public DateTime ProductionDate 
        { 
            get
            {
                return this.productionDate;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException(ErrorMessages.NULL_EXCEPTION, ProductionDate.ToString());
                }

                this.productionDate = value;
            }
        }

        public double Weight 
        { 
            get
            {
                return this.weight;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(ErrorMessages.NEGATIVE_NUMBER_EXCEPTION, Weight.ToString());
                }

                this.weight = value;
            }
        }

        public override string Type => "Appliance";
    }
}
