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
        public Vacitation Vacitation { get; set;}
        public PacientClass(string fullName, Vacitation vacitation)
        {
            FullName = fullName;
            Vacitation = vacitation;
        }
        public PacientClass(string fullName)
        {
            FullName = fullName.Substring(3);
            int num = Convert.ToInt16(fullName.Remove(3, fullName.Length));
            Vacitation = NumValue(num);
        }
        public Vacitation NumValue(int value)
        {
            if(value == 0)
            {
                return Vacitation.Zero;
            }
            else if (value == 1)
            {
                return Vacitation.One;
            }
            else
            {
                return Vacitation.Two;
            }
        }
        public bool IsSertificate(string fullname)
        {
            throw new NotImplementedException();
        }
    }
}
