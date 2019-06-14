using System.Collections.Generic;
using System.Text;
using TreeViewPoC.Core.Extensions;

namespace TreeViewPoC.Core.Models
{
    public class SampleCompany
    {
        public string CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public IEnumerable<SampleOrder> Orders { get; set; }

        public string LongDescription
        {
            get
            {
                var result = new StringBuilder();
                result.Append("Company: ");
                result.TryAppendFormat("{0} ", CompanyID);
                result.TryAppendFormat("{0} ", CompanyName);
                result.Append("Contact: ");
                result.TryAppendFormat("{0} ", ContactName);
                result.TryAppendFormat("{0} ", ContactTitle);
                result.TryAppendFormat(" Phone: {0} ", Phone);
                result.Append("Location: ");
                result.TryAppendFormat("{0} ", Address);
                result.TryAppendFormat("{0} ", PostalCode);
                result.TryAppendFormat("{0} ", City);
                result.TryAppendFormat("{0} ", Region);
                result.TryAppendFormat("{0} ", Country);
                return result.ToString();
            }
        }
    }
}
