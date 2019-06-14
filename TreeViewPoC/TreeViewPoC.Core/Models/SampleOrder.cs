using System;
using System.Collections.Generic;
using System.Text;
using TreeViewPoC.Core.Extensions;

namespace TreeViewPoC.Core.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class SampleOrder
    {
        public string OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public string ShipperName { get; set; }

        public string ShipperPhone { get; set; }

        public double Freight { get; set; }

        public string Company { get; set; }

        public string ShipTo { get; set; }

        public double OrderTotal { get; set; }

        public string Status { get; set; }

        public char Symbol => (char)SymbolCode;

        public int SymbolCode { get; set; }

        public IEnumerable<SampleOrderDetail> Details { get; set; }

        public override string ToString()
        {
            return $"{Company} {Status}";
        }

        public string LongDescription
        {
            get
            {
                var result = new StringBuilder();
                result.Append("Order: ");
                result.TryAppendFormat("{0} ", OrderID);
                result.TryAppendFormat("Status: {0} ", Status);
                result.TryAppendFormat("Freight: {0} ", Freight);
                result.TryAppendFormat("OrderTotal: {0} ", OrderTotal);
                return result.ToString();
            }
        }

        public string ShortDescription
        {
            get
            {
                var result = new StringBuilder();
                result.TryAppendFormat("{0} ", OrderDate?.ToString("MM/dd"));
                result.TryAppendFormat("{0} ", Status);
                return result.ToString();
            }
        }
    }
}
