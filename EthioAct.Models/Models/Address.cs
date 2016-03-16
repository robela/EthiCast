using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class Address
    {
        public Address()
        {
            this.Actors = new List<Actor>();
        }

        public int addressId { get; set; }
        public Nullable<int> conurtyId { get; set; }
        public Nullable<int> cityId { get; set; }
        public string address1 { get; set; }
        public string phoneNo { get; set; }
        public string mobileNo { get; set; }
        public string mobileNo2 { get; set; }
        public string houseNo { get; set; }
        public Nullable<int> regionId { get; set; }
        public Nullable<int> zoneId { get; set; }
        public Nullable<int> woredaId { get; set; }
        public string townName { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
    }
}
