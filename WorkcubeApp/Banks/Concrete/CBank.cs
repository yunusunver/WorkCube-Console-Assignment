using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkcubeApp.Banks.Abstract;
using WorkcubeApp.GatewayService.Concrete;

namespace WorkcubeApp.Banks.Concrete
{
    public class CBank : GatewayTwo, ICBank
    {
        public string Pay(int tutar, string krediKartiNo)
        {
            return this.TriDPay(tutar,krediKartiNo);
        }
    }
}
