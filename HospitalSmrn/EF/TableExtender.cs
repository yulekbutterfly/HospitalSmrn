using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSmrn.EF
{
        public partial class PatientYuliya
        {
            public string FullName { get => $"{FName} {MName} {LName}"; }
        }
    public partial class EmployeeYuliya
    {
        public string FullName { get => $"{FName} {MName} {LName}"; }
    }
    public partial class AppointmentYuliya
    {
        public string Date { get { return DateService.ToString("yyyy-MM-dd"); } }
    }
}
