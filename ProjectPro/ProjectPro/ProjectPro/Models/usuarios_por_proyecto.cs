//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios_por_proyecto
    {
        public int id_usuarioProyecto { get; set; }
        public string cod_usuario { get; set; }
        public int cod_proyecto { get; set; }
    
        public virtual proyecto proyecto { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
