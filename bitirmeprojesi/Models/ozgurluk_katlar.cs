//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitirmeprojesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ozgurluk_katlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ozgurluk_katlar()
        {
            this.ozgurluk = new HashSet<ozgurluk>();
        }
    
        public int id { get; set; }
        public string kat_adedi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ozgurluk> ozgurluk { get; set; }
    }
}
