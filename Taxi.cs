using System;

namespace ClassTaxi

{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
			Console.WriteLine("\n========================================================");
			Console.WriteLine("========================================================");
			Console.WriteLine("\t  Contoh Program Objek dari Class Taxi");
			Console.WriteLine("\t(Aldi Prabowo * 19.11.2850 * 19-S1IF-04)  ");
			Console.WriteLine("========================================================");
			Console.WriteLine("\n");
			
            taxi.driverName = "Aldi Prabowo";
            taxi.onDuty = true;
            taxi.NumPassenger = 12;
			
            taxi.TaxiInfo();
            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
			
			Console.WriteLine("\n========================================================");
			
			Console.WriteLine("\t   Tekan sembarang key untuk keluar");
			Console.WriteLine("========================================================");
			Console.WriteLine("========================================================");
            Console.ReadKey();
        }
    }

    class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("\tNama Pengemudi		: {0}", driverName);
            if (onDuty)
            {
                Console.WriteLine("\tDalam Tugas		: Iya");
            }
            else
            {
                Console.WriteLine("\tDalam Tugas		: Tidak");
            }
            Console.WriteLine("\tNomor Penumpang		: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("\t{0} sedang menjemput penumpang", driverName);
            }
            else
            {
                Console.WriteLine("\t{0} tidak menjemput penumpang", driverName);
            }
        }

        public void DropOffPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("\t{0} selesai mengantar penumpang", driverName);
            }
            else
            {
                Console.WriteLine("\t{0} tidak mengantar penumpang", driverName);
            }
        }
    }
}