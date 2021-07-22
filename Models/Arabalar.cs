using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Yarıs.Models
{
    public class Arabalar
    {
        public virtual int GetSpeed() //karakterlerin hızları çok biçimli çünkü değişebilir
        {
            return 7; //standart 7 
        }
    }
}
