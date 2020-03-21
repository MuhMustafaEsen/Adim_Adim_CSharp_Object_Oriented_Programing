using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sealed
{
    class Book:BaseBook
    {
        public virtual DateTime CreateTime()
        {
            return DateTime.Now.Date;
        }

        public override void GetLog()
        {
            base.GetLog();
        }

        public sealed override void UserLog()
        {
            base.UserLog();
        }
    }
}
