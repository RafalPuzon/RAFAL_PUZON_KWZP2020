//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP_LAB_Winform
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rodzaj_Etapu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rodzaj_Etapu()
        {
            this.Etapy_W_Procesie = new HashSet<Etapy_W_Procesie>();
            this.Realizacja_Procesu = new HashSet<Realizacja_Procesu>();
        }
    
        public int ID_Etapu { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etapy_W_Procesie> Etapy_W_Procesie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realizacja_Procesu> Realizacja_Procesu { get; set; }
    }
}
