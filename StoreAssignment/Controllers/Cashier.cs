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

            stringBuilder.AppendLine($"Date:{purchaseDateTime}\n");
            stringBuilder.AppendLine("--Products--\n");
            foreach(var item in cart)
            {
                fullPrice = (decimal)item.Quantity * item.Price;
                stringBuilder.AppendLine($"{item.Name} - {item.Brand}");
                stringBuilder.AppendLine($"{item.Quantity} x {item.Price} = {fullPrice}\n");
                subTotal += fullPrice;
                if(item.DiscountCalc(purchaseDateTime) != 0)
                {
                    discountedPrice = item.Price * (decimal)(item.DiscountCalc(purchaseDateTime) / 100);
                    stringBuilder.AppendLine($"#discount {item.DiscountCalc(purchaseDateTime)}% -${discountedPrice}\n");
                    discount += discountedPrice;

                }
            }
            stringBuilder.AppendLine("------------------------------------------------------------\n");
            stringBuilder.AppendLine($"SUBTOTAL: ${subTotal}");
            stringBuilder.AppendLine($"DISCOUNT: -${discount}\n");
            stringBuilder.AppendLine($"TOTAL: ${subTotal - discount}");

            Console.WriteLine(stringBuilder.ToString());

        }

    }
}
