//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contact.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class organisation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public organisation()
        {
            this.positions = new HashSet<position>();
            this.slogans = new HashSet<slogan>();
            this.users = new HashSet<user>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> slogan_id { get; set; }
        public Nullable<int> address_id { get; set; }
        public string contact_no { get; set; }
        public string email { get; set; }
    
        public virtual address address { get; set; }
        public virtual slogan slogan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<position> positions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<slogan> slogans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
