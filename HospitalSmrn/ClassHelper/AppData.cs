using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalSmrn.EF;

namespace HospitalSmrn.ClassHelper
{
    internal class AppData
    {
        public static EF.Entities Context { get; } = new EF.Entities();
    }
}
