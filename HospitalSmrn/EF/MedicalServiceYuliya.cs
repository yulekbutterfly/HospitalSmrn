//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalSmrn.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalServiceYuliya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalServiceYuliya()
        {
            this.AppointmentYuliya = new HashSet<AppointmentYuliya>();
        }
    
        public int ID { get; set; }
        public string TitleService { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public Nullable<int> QNT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppointmentYuliya> AppointmentYuliya { get; set; }
    }
}
