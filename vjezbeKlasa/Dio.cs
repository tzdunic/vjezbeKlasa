using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbeKlasa
{
   public interface IDio
    {
         string naziv { get; set; }
         int sifra { get; set; }

         string printAttributes();
       
    }
}
