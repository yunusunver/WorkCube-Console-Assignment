using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkcubeApp.Banks.Abstract
{
    public interface IBank
    {
        string Pay(int tutar, string krediKartiNo);
        string TriDPay(int tutar, string krediKartiNo);
        string Refund(int payId);
        string Cancel(int payId);
    }
}
