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
    
    public partial class AppointmentYuliya
    {
        public int ID { get; set; }
        public int IDEmployee { get; set; }
        public int IDMedicalService { get; set; }
        public System.DateTime DateService { get; set; }
        public int IDPatient { get; set; }
        public Nullable<int> IDDiagnosis { get; set; }
    
        public virtual DiagnosisYuliya DiagnosisYuliya { get; set; }
        public virtual EmployeeYuliya EmployeeYuliya { get; set; }
        public virtual MedicalServiceYuliya MedicalServiceYuliya { get; set; }
        public virtual PatientYuliya PatientYuliya { get; set; }
    }
}
