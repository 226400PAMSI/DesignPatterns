using System;

namespace test
{
    public abstract class Kaczka
    {
       public ILatanie iLatanie;
       public  IKwakanie iKwakanie;

        public void wykonajKwacz()
        {
            iKwakanie.kwacz();
        }
        public void wykonajLec()
        {
            iLatanie.lec();
        }

        public void plywaj()
        {
            Console.WriteLine("Wszyscy potrafia plywac");
        }

    }

    public class DzikaKaczka : Kaczka
    {
        public DzikaKaczka()
        {
            iKwakanie = new Kwacz();
            iLatanie = new LataBoMaSkrzydla();
        }

        public void wyswietl()
        {
            Console.WriteLine("Dzika kaczka Here.");

        }
    }
    public interface ILatanie
    {
        public void lec();
    }

    public class LataBoMaSkrzydla: ILatanie
    {
        public void lec()
        {
            Console.WriteLine("Leci bo ma skrzydla");
        }
    }

    public class NieLataBoNieMaSkrzydel : ILatanie
    {
        public void lec()
        {
            Console.WriteLine("Nie latam, bo nie mam skrzydel");
        }
    }

    public interface IKwakanie
    {
        public void kwacz();
    }

    public class Kwacz: IKwakanie
    {
        public void kwacz()
        {
            Console.WriteLine("Kwak, kwak");
        }
    }
    public class Piszcz : IKwakanie
    {
        public void kwacz()
        {
            Console.WriteLine("pisk, pisk");
        }
    }
    public class NieKwacz : IKwakanie
    {
        public void kwacz()
        {
            Console.WriteLine("Sound of silence");
        }
    }
    class MiniSymulatorKaczki
    {
        static void Main(string[] args)
        {
            Kaczka dzika = new DzikaKaczka();
            dzika.wykonajKwacz();
            dzika.wykonajLec();
        }
    }
}
