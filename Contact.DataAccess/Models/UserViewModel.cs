using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Models
{
    public class UserViewModel
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> position_id { get; set; }
        public Nullable<int> organisation_id { get; set; }
        public Nullable<int> address_id { get; set; }
        public string mob_no { get; set; }
        public string alt_mob_no { get; set; }
        public string email { get; set; }

        public AddressViewModel address { get; set; }
    }
}
