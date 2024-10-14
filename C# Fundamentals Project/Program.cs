class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Oyunumuza Hoşgeldiniz !!\n");
            Console.WriteLine("0: Çıkış Yapmak İçin\n");
            Console.WriteLine("1: Rastgele Sayı Bulma Oyunu");
            Console.WriteLine("2: Hesap Makinesi");
            Console.WriteLine("3: Ortalama Hesaplama\n");

            Console.WriteLine("Seçmek istediğiniz oyunun numarasını giriniz.");

            int y = Convert.ToInt32(Console.ReadLine());

            if (y == 1)
            {
                Random rastgele = new Random();

                int rastgeleSayi = rastgele.Next(1, 100);

                int tahminHakki = 0;

                while (tahminHakki < 5)
                {
                    Console.WriteLine("Bir tahminde bulununuz.\n");

                    int tahmin = Convert.ToInt32(Console.ReadLine());

                    if (tahmin < rastgeleSayi)
                    {
                        Console.WriteLine("Tahmininiz küçük kalmıştır.");
                    }
                    else if (tahmin > rastgeleSayi)
                    {
                        Console.WriteLine("Tahmininiz büyük kalmıştır.");
                    }
                    else
                    {
                        Console.WriteLine($"Tahmniniz doğru!. Tebrikler!. Rastgele sayınız : {rastgeleSayi}");
                        y = 0;
                    }

                    tahminHakki++;

                    Console.WriteLine($"Kalan tahmin hakkınız:{5 - tahminHakki} \n");
                }
            }

            if (y == 2)
            {
                Console.WriteLine("Lütfen bir tamsayı değeri giriniz.");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci bir tamsayı değeri giriniz.");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("Toplama için +,\r\n\r\n Çıkarma için -,\r\n\r\n Çarpma için *,\r\n\r\n Bölme için / kullanınız.");

                string islem = Console.ReadLine();

                switch (islem)
                {
                    case "+":
                        Console.WriteLine($"Toplama işlemi: {sayi1 + sayi2}");
                        break;
                    case "-":
                        Console.WriteLine($"Çıkarma işlemi: {sayi1 - sayi2}");
                        break;
                    case "*":
                        Console.WriteLine($"Çarpma İşlemi: {sayi1 * sayi2}");
                        break;
                    case "/":
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Hatalı işlem yaptınız.");
                            break;
                        }
                        Console.WriteLine($"Bölme işlemi: {sayi1 / sayi2}");
                        break;
                    default:
                        Console.WriteLine("Hatalı Giriş Yaptınız.");
                        break;

                }

            }

            if (y == 3)
            {
                Console.WriteLine("Lütfen birinci ders notunuzu  giriniz.");
                int not1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci ders notunuzu  giriniz.");
                int not2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen üçüncü ders notunuzu  giriniz.");
                int not3 = Convert.ToInt32(Console.ReadLine());

                double ortalama = ((not1 + not2 + not3) / 3.0);

                if (!(0 <= not1 && not1 <= 100) || !(0 <= not2 && not2 <= 100) || !(0 <= not3 && not3 <= 100))
                {
                    Console.WriteLine("Geçersiz bir not girişi yaptınız.");
                    y = 0;
                }

                if (ortalama >= 90 && ortalama <= 100)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: AA");
                }
                else if (ortalama >= 85 && ortalama <= 89)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: BA");
                }
                else if (ortalama >= 80 && ortalama <= 84)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: BB");

                }
                else if (ortalama >= 75 && ortalama <= 79)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: CB");
                }
                else if (ortalama >= 70 && ortalama <= 74)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: CC");
                }
                else if (ortalama >= 65 && ortalama <= 69)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: DC");
                }
                else if (ortalama >= 60 && ortalama <= 64)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: DD");
                }
                else if (ortalama >= 55 && ortalama <= 59)
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: FD");
                }
                else
                {
                    Console.WriteLine($"Ortalamanız : {ortalama}. Harf Notunuz: AA");
                }
            }

            if (y == 0)
            {
                break;
            }
        }
    }
}
