//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_Cabinet_Medical
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public int ID_Medic { get; set; }
        public int ID_Pacient { get; set; }
        public System.DateTime Date { get; set; }
        public int Accepted { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
