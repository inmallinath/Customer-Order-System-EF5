using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesDomain.DomainClasses
{
    public class ContactDetail
    {
        [Key, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string OfficePhone { get; set; }
        public string TwitterAlias { get; set; }
        public string Facebook { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string Messenger { get; set; }

        public virtual Customer Customer { get; set; }
    }
}