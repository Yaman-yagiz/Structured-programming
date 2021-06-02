using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataForm2
{
    class Ogrenci
    {
        public AkademikPersonel DanismanHoca { get; set; }   
       public Ogrenci()
        {
            DanismanHoca = new AkademikPersonel();
        }
    }
}
