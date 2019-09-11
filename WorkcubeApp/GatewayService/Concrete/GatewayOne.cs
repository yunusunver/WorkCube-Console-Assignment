using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorkcubeApp.GatewayService.Abstract;

namespace WorkcubeApp.GatewayService.Concrete
{
    public class GatewayOne:IGatewayOne
    {
        public string Pay(int tutar, string krediKartiNo)
        {
            return tutar + " tutarı "+this.GetType().Name+" ile " + this.GetType().BaseType.Name + " üzerinden " + MethodBase.GetCurrentMethod().Name + " işlemi ile " + krediKartiNo + " nolu kredi kartından çekilmiştir.";
        }

        public string Refund(int payId)
        {
            return payId + " payid ile yapılan işlem " + this.GetType().Name+" ile "+ this.GetType().BaseType.Name + " üzerinden " + MethodBase.GetCurrentMethod().Name + " edilmiştir.";
        }

        public string TriDPay(int tutar, string krediKartiNo)
        {
            return tutar + " tutarı " + this.GetType().Name + " ile " + this.GetType().BaseType.Name + " üzerinden " + MethodBase.GetCurrentMethod().Name + " işlemi ile " + krediKartiNo + " nolu kredi kartından çekilmiştir.";
        }

    }
}
