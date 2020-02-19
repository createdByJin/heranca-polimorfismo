using System;
using System.Globalization;
using System.Text;

namespace PrimeiroProjeto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price,DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (used) ");
            sb.Append("$ " + Price.ToString("f2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");
            return sb.ToString();
        }
    }
}
