using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkcubeApp.GatewayService.Abstract
{
    public interface IGatewayTwo
    {
        string TriDPay(int tutar, string krediKartiNo);
        string Cancel(int payId);
        string Refund(int payId);
    }
}
