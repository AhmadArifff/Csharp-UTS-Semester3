using System;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil Mbl = new Mobil();
            Motor Mtr = new Motor(); 
            Kendaraan K = new Kendaraan(); 
            K.Merek = "Lamborghini";
            K.Jenis = "Sport Car";
            K.Mobil_(K.Merek,K.Jenis);
            Mbl.Teknologi = "Radio, GPS, Autonomous drive, Pre - collision, Connected cars, Hybrid, Automatic safety braking system, Electromagnetic parking sensor\n";
            Mbl.FiturTeknologiKomukasi(Mbl.Teknologi);
            Mbl.Kelebihan = "Desain Bodi Active Aerodynamics, Performa Mesin Teratas Di Kelasnya, Beragam FItur yang Melengkapi Mobil";
            Mbl.Kekurangan = "Harga Yang Terbilang Mahal, Konsumsi Bahan Bakar Yang Boros, Bodi Mobil Yang “Ceper” Tidak Cocok Untuk Jalanan Indonesia";
            Mbl.Manfaat(Mbl.Kelebihan, Mbl.Kekurangan);
            K.Merek = "Ducati panigale v4";
            K.Jenis = "Sport Bike";
            K.Motor_(K.Merek, K.Jenis);
            Mtr.Teknologi = "ABS(Antilock Braking System), Shock breaker upside down untuk motor sport";
            Mtr.FiturTeknologiKomukasi(Mtr.Teknologi);
            Mtr.Kelebihan = "Performa khas motor sport, Fitur modern, Peranti keselamatan lengkap";
            Mtr.Kekurangan = "Harga Yang Terbilang Mahal, Pilihan warna terbatas";
            Mtr.Manfaat(Mbl.Kelebihan, Mbl.Kekurangan);
        }
    }
    class Kendaraan
    {
        /*property 1 : Merek
        Type Data : string
        Akses : global (public)
        */
        public string Merek { get; set; }
        /*property 2 : jenis
        Type Data : string
        Akses : global (public)
        */
        public string Jenis { get; set; }
        /*method virtual 1 yang bernama "Mobil_" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "merek" dan "jenis"*/
        public virtual void Mobil_(string merek, string jenis)
        {
            Merek = merek;
            Jenis = jenis;
            Console.WriteLine("Merek Mobil : "+Merek+"\nJenis Mobil : "+ Jenis + "\n");
        }
        /*method virtual 2 yang bernama "Motor_" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "merek" dan "jenis"*/
        public virtual void Motor_(string merek, string jenis)
        {
            Merek = merek;
            Jenis = jenis;
            Console.WriteLine("Merek Motor : " + Merek + "\nJenis Motor : " + Jenis + "\n");
        }
    }
    /*interface dibawah merupakan class abstrak yang dimana yang dimana method nya kosong atau tidak memiliki parameter,
    dan dan class interface ini memiliki nama class "IKomukasi" dengan method "FiturKomukasi" yang tidak memiliki parameter.*/ 
    interface IKomunikasi
    {
        void FiturTeknologiKomukasi(string Teknologi);
    }
    /*Class dibawah merupakan turunan class dari class utama yang dimana class utama yang bernama "Kendaraan" dan turunannya bernama "Mobil"*/
    class Mobil : Kendaraan,IKomunikasi
    {
        /*property : Teknologi
        Type Data : string
        Akses : global (public)
        */
        public string Teknologi { get; set; }
        /*property : Kelebihan
        Type Data : string
        Akses : global (public)
        */
        public string Kelebihan { get; set; }
        /*property : Kekurangan
        Type Data : string
        Akses : global (public)
        */
        public string Kekurangan { get; set; }
        /*method override yang bernama "Mobil_" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "merek" dan "jenis"*/
        public override void Mobil_(string merek,string jenis)
        {
            Console.WriteLine(merek + jenis);
        }
        /*method turunan dari class interface yang bernama "FiturTeknologiKomukasi" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 1 buah string yaitu "teknologi"*/
        public void FiturTeknologiKomukasi(string teknologi)
        {
            Teknologi = teknologi;
            Console.WriteLine("Fitur Teknologi Komukasi Mobil : "+ Teknologi);
        }
        /*method overloading yang bernama "Manfaat" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 1 buah string yaitu "kelebihan"*/
        public void Manfaat(string kelebihan)
        {
            Kelebihan = kelebihan;
            Console.WriteLine("Manfaat Kelebihan : " + Kelebihan);
        }
        /*method overloading yang bernama "Manfaat" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "kelebihan" dana "Kekurangan"*/
        public void Manfaat(string kelebihan,string kekurangan)
        {
            Kelebihan = kelebihan;
            Kekurangan = kekurangan;
            Console.WriteLine("Manfaat Kelebihan : " + Kelebihan+"\nManfaat Kekurangan : "+Kekurangan);
        }
    }
    /*Class dibawah merupakan turunan class dari class utama yang dimana class utama yang bernama "Kendaraan" dan turunannya bernama "Motor"*/
    class Motor : Kendaraan,IKomunikasi
    {
        /*property : Teknologi
        Type Data : string
        Akses : global (public)
        */
        public string Teknologi { get; set; }
        /*property : Kelebihan
        Type Data : string
        Akses : global (public)
        */
        public string Kelebihan { get; set; }
        /*property : Kekurangan
        Type Data : string
        Akses : global (public)
        */
        public string Kekurangan { get; set; }
        /*method override yang bernama "Motor_" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "merek" dan "jenis"*/
        public override void Motor_(string merek, string jenis)
        {
            Console.WriteLine(merek + jenis);
        }
        /*method turunan dari class interface yang bernama "FiturTeknologiKomukasi" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 1 buah string yaitu "teknologi"*/
        public void FiturTeknologiKomukasi(string teknologi)
        {
            Teknologi = teknologi;
            Console.WriteLine("Fitur Teknologi Komukasi Motor : "+Teknologi);
        }
        /*method overloading yang bernama "Manfaat" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 1 buah string yaitu "kelebihan"*/
        public void Manfaat(string kelebihan)
        {
            Kelebihan = kelebihan;
            Console.WriteLine("Manfaat Kelebihan : " + Kelebihan);
        }
        /*method overloading yang bernama "Manfaat" dan memiliki akses global atau dapat dipanggil
         diluar class, dan memiliki parameter 2 buah string yaitu "kelebihan" dana "Kekurangan"*/
        public void Manfaat(string kelebihan, string kekurangan)
        {
            Kelebihan = kelebihan;
            Kekurangan = kekurangan;
            Console.WriteLine("Manfaat Kelebihan : " + Kelebihan + "\nManfaat Kekurangan : " + Kekurangan);
        }
    }
}

