//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation_roles
    {
        public int Id { get; set; }
        public Nullable<int> IdRoles { get; set; }
        public Nullable<int> IdOperation { get; set; }
    
        public virtual Operations Operations { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
