using System.Collections.Generic;

namespace SalesDomain.DomainClasses
{
    public class Product
    {
        public Product()
        {
            this.LineItems = new HashSet<LineItem>();
            this.Categories = new HashSet<Category>();
        }

        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}