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
    
    public partial class Realizacja_Procesu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Realizacja_Procesu()
        {
            this.Przydzial_Zasobow = new HashSet<Przydzial_Zasobow>();
        }
    
        public int ID_Realizacji_Procesu { get; set; }
        public int ID_Procesu_Produkcyjnego { get; set; }
        public int ID_Etapu { get; set; }
        public System.DateTime Data_Rozpoczecia_Procesu { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia_Procesu { get; set; }
        public Nullable<System.DateTime> Data_Kontroli { get; set; }
        public string Uwagi_Kontroli { get; set; }
    
        public virtual Proces_Produkcyjny Proces_Produkcyjny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Przydzial_Zasobow> Przydzial_Zasobow { get; set; }
        public virtual Rodzaj_Etapu Rodzaj_Etapu { get; set; }
    }
}
