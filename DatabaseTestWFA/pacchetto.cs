//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseTestWFA
{
    using System;
    using System.Collections.Generic;
    
    public partial class pacchetto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pacchetto()
        {
            this.servizios = new HashSet<servizio>();
        }
    
        public float Prezzo { get; set; }
        public int Sconto { get; set; }
        public string IDpacchetto { get; set; }
        public string CFcliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servizio> servizios { get; set; }
    }
}
