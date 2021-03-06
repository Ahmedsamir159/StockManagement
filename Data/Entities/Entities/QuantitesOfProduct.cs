//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuantitesOfProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuantitesOfProduct()
        {
            this.Stocks = new HashSet<Stock>();
        }
    
        public int Id { get; set; }
        public string ProductId { get; set; }
        public double Quantity { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
