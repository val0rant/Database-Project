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
    
    public partial class sequenza
    {
        public string IDtappa { get; set; }
        public int Indice { get; set; }
        public string IDpercorso { get; set; }
    
        public virtual percorso percorso { get; set; }
        public virtual tappa tappa { get; set; }
    }
}