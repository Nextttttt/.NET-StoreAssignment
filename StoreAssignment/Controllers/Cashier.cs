namespace StoreAssignment.Controllers
{
    using StoreAssignment.Models.Products;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cashier
    {

        public void PrintReceipt(List<ProductModel> cart, DateTime purchaseDateTime)
        {

            StringBuilder stringBuilder = new StringBuilder();

            decimal subTotal = 0;
            decimal fullPrice;
            decimal discountedPrice;
            decimal discount = 0;

            stringBuilder.AppendLine($"Date: {purchaseDateTime:yyyy-MM-dd HH:mm:ss}\n");
            stringBuilder.AppendLine("--Products--\n\n");
            foreach(var item in cart)
            {
                fullPrice = (decimal)item.Quantity * item.Price;
               
                stringBuilder.AppendLine($"{item}");
                stringBuilder.AppendLine($"{item.Quantity} x ${item.Price:f2} = ${Math.Round(fullPrice,2)}");
                subTotal += fullPrice;
                if(item.DiscountCalc(purchaseDateTime) != 0)
                {
                    discountedPrice = fullPrice * (item.DiscountCalc(purchaseDateTime) / 100);
                    stringBuilder.AppendLine($"#discount {item.DiscountCalc(purchaseDateTime)}% -${Math.Round(discountedPrice,2)}");
                    discount += discountedPrice;

                }
                stringBuilder.AppendLine("\n\n");
            }
            stringBuilder.AppendLine("------------------------------------------------------------\n");
            stringBuilder.AppendLine($"SUBTOTAL: ${Math.Round(subTotal,2)}");
            stringBuilder.AppendLine($"DISCOUNT: -${Math.Round(discount,2)}\n");
            stringBuilder.AppendLine($"TOTAL: ${Math.Round(subTotal - discount,2)}");

            Console.WriteLine(stringBuilder.ToString());

        }

    }
}
