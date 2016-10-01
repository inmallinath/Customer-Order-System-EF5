﻿namespace SalesDomain.DomainClasses
{
    public partial class ContactDetail
    {
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