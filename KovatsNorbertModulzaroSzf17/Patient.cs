using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KovatsNorbertModulzaroSzf17
{
    public class Patient : BaseModel
    {
        public string Name { get; set; }
        public string BLocation { get; set; }
        public string BDate { get; set; }
        public int Age { get; set; }
        public int TAJ { get; set; }
        public int BNOPass { get; set; }
        public string BNOComm { get; set; }
        
    }
   
}
