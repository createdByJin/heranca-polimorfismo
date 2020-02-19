using System.Text;
using System.Globalization;

namespace PrimeiroProjeto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct (string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ " + CustomsFee.ToString("f2", CultureInfo.InvariantCulture) + ")");
            return sb.ToString();
        }
    }
}
