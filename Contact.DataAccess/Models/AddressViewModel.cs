using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        public Guid AddressTypeID { get; set; }

        public string Street { get; set; }

        public string Street2 { get; set; }

        public int StateId { get; set; }

        public string PinCode { get; set; }
    }
}
