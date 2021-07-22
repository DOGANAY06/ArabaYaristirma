using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Yarıs.Models
{
    public class BMW : Arabalar
    {
        Random random = new Random(); //rastgele hızı belirlemek için kullandım
        public override int GetSpeed()
        {
            return random.Next(6, 12);
        }

    }
}
