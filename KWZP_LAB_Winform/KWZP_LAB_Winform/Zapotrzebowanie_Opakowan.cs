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
    
    public partial class Zapotrzebowanie_Opakowan
    {
        public int ID_Procesu_Produkcyjnego { get; set; }
        public int ID_Element { get; set; }
        public int Liczba { get; set; }
        public Nullable<bool> Czy_Otrzymano { get; set; }
        public string Uwagi { get; set; }
    
        public virtual Magazyn_Elementy Magazyn_Elementy { get; set; }
        public virtual Proces_Produkcyjny Proces_Produkcyjny { get; set; }
    }
}
