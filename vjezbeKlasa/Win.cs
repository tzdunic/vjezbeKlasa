using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbeKlasa
{
   public class Win
    {
       private int wmi;
       private int vds;
       private int vis;

       public string getVin()
       {

           return wmi.ToString() + " " + vds.ToString() + " " + vis.ToString();
       }

       public Win( int wmi, int vds, int vis)
       {
           this.wmi = wmi;
           this.vds = vds;
           this.vis = vis;

       }
    }
}
