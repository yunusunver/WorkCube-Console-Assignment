using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkcubeApp.Banks.Abstract;
using WorkcubeApp.GatewayService.Concrete;

namespace WorkcubeApp.Banks.Concrete
{
    public class BBank : GatewayOne, IBBank
    {
        
        public string Cancel(int payId)
        {
            return Refund(payId);
        }
    }
}
