//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgropuliApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int Id { get; set; }
        public System.DateTime Created { get; set; }
        public string NationalId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Town { get; set; }
        public string Vereda { get; set; }
        public string Farm { get; set; }
        public string GPS { get; set; }
        public string Administrator { get; set; }
        public string Crop { get; set; }
        public string Variety { get; set; }
        public Nullable<double> Ha { get; set; }
        public string Quote { get; set; }
        public string Product { get; set; }
        public Nullable<System.DateTime> CallDate { get; set; }
        public string SecondaryCrop { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> RequestAppointment { get; set; }
        public Nullable<bool> AssignTechnician { get; set; }
        public Nullable<System.DateTime> NextAppointment { get; set; }
    }
}
