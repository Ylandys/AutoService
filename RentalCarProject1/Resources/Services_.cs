//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalCarProject1.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Services_()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<double> Discond { get; set; }
        public Nullable<int> PathID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ServicesImages ServicesImages { get; set; }
    }
}
