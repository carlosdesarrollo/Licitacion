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
    
    public partial class WorkWithUs
    {
        public int Id { get; set; }
        public System.DateTime Created { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> VehicleId { get; set; }
        public bool IsTechnician { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}