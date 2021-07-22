using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Yarıs.Models
{
    public class Mercedes:Arabalar
    {
        public override int GetSpeed()
        { //mercedes hızlı 
            return 10;
        }
    }
}
