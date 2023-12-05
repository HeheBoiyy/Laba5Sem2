using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5Sem2
{
    public enum Vacitation
    {
        Zero = 0,
        One = 1,
        Two = 2
    }
    public class PacientClass
    {
        public string FullName { get; set; }
        public string FullNameVacitation
        {
            get
            {
                return "["+((int)Vacitation).ToString()+"]" + FullName;
            }
        }
        public Vacitation Vacitation { get; set;}
        public PacientClass(string fullName, Vacitation vacitation)
        {
            FullName = fullName;
            Vacitation = vacitation;
        }
        public static bool IsSertificate(PacientClass pacient)
        {
            if (pacient.Vacitation == Vacitation.Two)
            {
                return true;
            }
           return false;
        }
        
    }
}
