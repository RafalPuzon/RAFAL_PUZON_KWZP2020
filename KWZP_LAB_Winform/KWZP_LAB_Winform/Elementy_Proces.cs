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
    
    public partial class Elementy_Proces
    {
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Element { get; set; }
        public int Liczba { get; set; }
    
        public virtual Magazyn_Elementy Magazyn_Elementy { get; set; }
        public virtual Proces_Zamowienie Proces_Zamowienie { get; set; }
    }
}