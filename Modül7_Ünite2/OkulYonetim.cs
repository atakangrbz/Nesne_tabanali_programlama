using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modül7.Ünite1
{
    internal class OkulYonetim
    {
    }
    interface IInsan
    {
        void Buyu();
    }

    // Soyut sınıf
    abstract class OkuyanInsan
    {
        public void Oku()
        {
            Console.WriteLine("Okudum.");
        }
    }

    // Ogrenci sınıfı: OkuyanInsan'dan miras alır, IInsan arayüzünü uygular
    class Ogrenci : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Hızlı büyüdüm.");
        }
    }

    // Ogretmen sınıfı: OkuyanInsan'dan miras alır, IInsan arayüzünü uygular
    class Ogretmen : OkuyanInsan, IInsan
    {
        public void Buyu()
        {
            Console.WriteLine("Yavaş büyüdüm.");
        }
    }
}
