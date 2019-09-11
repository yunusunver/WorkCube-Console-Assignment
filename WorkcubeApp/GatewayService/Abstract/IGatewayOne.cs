using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkcubeApp.GatewayService.Abstract
{
    public interface IGatewayOne
    {
        string Pay(int tutar, string krediKartiNo);
        string TriDPay(int tutar, string krediKartiNo);
        string Refund(int payId);
    }
}
