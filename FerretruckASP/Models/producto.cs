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
    
    public partial class producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producto()
        {
            this.cat_product = new HashSet<cat_product>();
            this.detalle_venta = new HashSet<detalle_venta>();
        }
    
        public int codigo_p { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public Nullable<int> precio { get; set; }
        public string descripcion { get; set; }
        public byte[] estado { get; set; }
        public Nullable<int> stock { get; set; }
        public byte[] oferta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cat_product> cat_product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_venta> detalle_venta { get; set; }
    }
}
