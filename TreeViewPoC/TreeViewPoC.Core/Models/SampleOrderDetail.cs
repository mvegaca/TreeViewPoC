using System.Text;
using TreeViewPoC.Core.Extensions;

namespace TreeViewPoC.Core.Models
{
    public class SampleOrderDetail
    {
        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public string QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public double Total { get; set; }

        public string LongDescription
        {
            get
            {
                var result = new StringBuilder();
                result.Append("Product: ");
                result.TryAppendFormat("{0} ", ProductID);
                result.TryAppendFormat("{0} ", ProductName);
                result.TryAppendFormat("quantity: {0} ", Quantity);
                result.TryAppendFormat("({0}) ", QuantityPerUnit);
                result.TryAppendFormat("unit price: {0} ", UnitPrice);                
                result.TryAppendFormat("discount {0} ", Discount);
                result.TryAppendFormat("category: {0} ", CategoryName);
                result.TryAppendFormat("{0} ", CategoryDescription);
                result.TryAppendFormat("Total: {0} ", Total);
                return result.ToString();
            }
        }
    }
}
