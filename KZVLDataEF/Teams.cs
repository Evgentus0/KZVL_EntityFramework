//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KZVLDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teams
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teams()
        {
            this.Players = new HashSet<Players>();
        }
    
        public int TM_Id { get; set; }
        public string TM_Name { get; set; }
        public Nullable<int> TM_Group_Groups_Id { get; set; }
        public Nullable<int> TM_Rating { get; set; }
        public Nullable<int> TM_Captain_Players_Id { get; set; }
    
        public virtual Groups Groups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Players> Players { get; set; }
        public virtual Players Players1 { get; set; }
    }
}
