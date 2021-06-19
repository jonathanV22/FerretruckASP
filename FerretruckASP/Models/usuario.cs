//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FerretruckASP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.cuenta = new HashSet<cuenta>();
            this.venta = new HashSet<venta>();
        }
    
        public int id_u { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string rut { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string correo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string direccion { get; set; }
        public string imagen { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public Nullable<int> telefono { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Campo requerido")]
        public string clave { get; set; }
        
        public byte[] estado { get; set; }
        public Nullable<int> id_tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuenta> cuenta { get; set; }
        public virtual tipo_usuario tipo_usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}