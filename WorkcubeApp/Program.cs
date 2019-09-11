using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkcubeApp.Banks.Abstract;
using WorkcubeApp.Banks.Concrete;
using WorkcubeApp.Model;

namespace WorkcubeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CardInfo info = new CardInfo();
            ABank aBank = new ABank();
            BBank bBank= new BBank();
            CBank cBank = new CBank();
            DBank dBank = new DBank();

            int islem,banka,payId=2;
            Console.WriteLine("Bir işlem seçiniz:");
            Console.WriteLine("1- Pay");
            Console.WriteLine("2- TriDPay");
            Console.WriteLine("3- Cancel");
            Console.WriteLine("4- Refund");

            islem = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Banka seçiniz:");
            Console.WriteLine("1- ABank");
            Console.WriteLine("2- BBank");
            Console.WriteLine("3- CBank");
            Console.WriteLine("4- DBank");

            banka = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Adınız:");
            info.Adi = Console.ReadLine();
            Console.WriteLine("Kredi Kartı No");
            info.KrediKartNo = Console.ReadLine();
            Console.WriteLine("Son Kullanma Tarihi");
            info.SonKulTarihi = Console.ReadLine();
            Console.WriteLine("CVV");
            info.CVV = Console.ReadLine();
            Console.WriteLine("Tutar");
            info.Tutar = Convert.ToInt16(Console.ReadLine());
            

            if (banka == 1)
            {
                Islem(islem,info,aBank,payId);
            }
            else if (banka == 2)
            {
                Islem(islem, info, bBank, payId);
            }
            else if (banka == 3)
            {
                Islem(islem, info, cBank, payId);
            }
            else if(banka == 4)
            {
                Islem(islem, info, dBank, payId);
            }

            Console.ReadKey();

        }

        public static void Islem(int islemSecimi,CardInfo info,IBank bank, int payId)
        {
            if (islemSecimi == 1)
            {
               Console.WriteLine(bank.Pay(info.Tutar, info.KrediKartNo));
            }
            else if (islemSecimi == 2)
            {
                Console.WriteLine(bank.TriDPay(info.Tutar, info.KrediKartNo));
            }
            else if (islemSecimi == 3)
            {
               Console.WriteLine(bank.Cancel(payId));
            }
            else if (islemSecimi == 4)
            {
                Console.WriteLine(bank.Refund(payId));
            }
        }
       
    }

}
