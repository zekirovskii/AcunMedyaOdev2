using System;
using System.Runtime.CompilerServices;

class Program
{
    // 1. Sayının rakamlarının toplamını bulan algoritma

    static void Main()
    {
        Console.WriteLine("1. Sayının rakamlarının toplamını bulan algoritma");
        Console.Write("Bir sayı giriniz: ");
        int toplam = 0;

        for (int sayi = Convert.ToInt32(Console.ReadLine()); sayi > 0; sayi /= 10)
        {
            toplam += sayi % 10;
        }

        Console.WriteLine("Rakamların toplamı: " + toplam);

        // 2. Kullanıcıdan 10 ile 100 arasında bir sayı alma
        Console.WriteLine("2. Kullanıcıdan 10 ile 100 arasında bir sayı alma");
        int sayi1;

        while (true)
        {
            Console.WriteLine("Lütfen 10-100 aralığında bir sayı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            if (10 <= sayi1 && sayi1 <= 100)
            {
                Console.WriteLine($"Girdiğiniz {sayi1} doğru aralıktadır.");
                break;
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı 10-100 aralığında değildir.");
            }
        }
        // 3. Yaş kategorilerini belirleyen algoritma
        Console.WriteLine("3. Yaş kategorilerini belirleyen algoritma");
        int[] ages = new int[5];
        Console.Write("5 Adet yaş giriniz: ");
        for (int i = 0; i < 5; i++)
        {
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı");
        foreach (int age in ages)
        {
            if (0 <= age && age <= 12)
            {
                Console.WriteLine($"Girdiğiniz yaş ({age}): Çocuk.");
            }
            else if (13 <= age && age <= 19)
            {
                Console.WriteLine($"Girdiğiniz yaş ({age}): Genç.");
            }
            else if (20 <= age && age <= 64)
            {
                Console.WriteLine($"Girdiğiniz yaş ({age}): Yetişkin.");
            }
            else if (65 <= age)
            {
                Console.WriteLine($"Girdiğiniz yaş ({age}): Yaşlı.");
            }
        }
        // 4. Tekrar eden elemanları bulan algoritma
        Console.WriteLine("4. Tekrar eden elemanları bulan algoritma");
        int[] sayiDizisi = { 1, 2, 3, 1, 4, 2, 3, 2, 5, 6 };
        List<int> tekraredenlerListesi = new List<int>();
        for (int i = 0; i < sayiDizisi.Length; i++)
        {
            for (int j = i + 1; j < sayiDizisi.Length; j++)
            {
                if (sayiDizisi[i] == sayiDizisi[j] && !tekraredenlerListesi.Contains(sayiDizisi[i]))
                {
                    tekraredenlerListesi.Add(sayiDizisi[i]);
                    break;
                }
            }
        }
        Console.WriteLine("Tekrar eden elemanlar: ");
        foreach (int sayi in tekraredenlerListesi)
        {
            Console.WriteLine(sayi);
        }
        // 5. En uzun ve en kısa kelimeyi bulan algoritma
        Console.WriteLine("5. En uzun ve en kısa kelimeyi bulan algoritma");
        string[] kelimeDizisi = { "yusuf", "sengoz", "acunmedyaakademi", "arda", "tınmaz" };
        string shortest = kelimeDizisi[0];
        string longest = kelimeDizisi[0];

        foreach (string kelime in kelimeDizisi)
        {
            if (kelime.Length < shortest.Length)
            {
                shortest = kelime;
            }
            if (kelime.Length > longest.Length)
            {
                longest = kelime;
            }
        }
        Console.WriteLine($"En kısa kelime: {shortest}");
        Console.WriteLine($"En uzun kelime: {longest}");


        // 6. Cümleyi diziye kaydedip alfabetik sıralama
        Console.WriteLine("6. Cümleyi diziye kaydedip alfabetik sıralama");

        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(' ');

        Array.Sort(kelimeler);

        Console.WriteLine("Alfabetik olarak sıralanmış kelimeler:");
        foreach (string word in kelimeler)
        {
            Console.WriteLine(word);
        }
        // 7. String dizisinin boyutunu dinamik olarak genişletme
        Console.WriteLine("7. String dizisinin boyutunu dinamik olarak genişletme");

        List<string> words = new List<string>();

        while (true)
        {
            Console.Write("Bir kelime girin (Çıkmak için 'exit' yazın): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            words.Add(input);


            Console.WriteLine("\nGirilen kelimeler:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        // 8. Kullanıcının girdiği kelimeleri listeye kaydedip tersten yazdırma
        Console.WriteLine("8. Kullanıcının girdiği kelimeleri listeye kaydedip tersten yazdırma");
        List<string> kelimeler1 = new List<string>();

        while (true)
        {
            Console.Write("Bir kelime girin (Çıkmak için 'exit' yazın): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            kelimeler1.Add(input);


            Console.WriteLine("\nGirilen kelimeler:");
            foreach (string word in kelimeler1)
            {
                Console.WriteLine(word);
            }
        }
        Console.WriteLine("\nKelimelerin tersten sıralanmış hali:");
        for (int i = kelimeler1.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(kelimeler1[i]);
        }
        // 9. Rastgele sayılar alıp listeye ekleme ve işlemler
        Console.WriteLine("9. Rastgele sayılar alıp listeye ekleme ve işlemler");

        List<int> rastgeleSayilar = new List<int>();
        Console.Write("5 tane rastgele sayı giriniz: ");
        int toplam1 = 0;
        int ort;

        for (int i = 0; i < 5; i++)
        {
            int girdi = Convert.ToInt32(Console.ReadLine());
            rastgeleSayilar.Add(girdi);
            toplam1 += girdi;
        }

        ort = toplam1 / rastgeleSayilar.Count;

        Console.WriteLine($"Sayıların ortalaması: {ort}");

        rastgeleSayilar.Sort();
        Console.WriteLine("\nKüçükten büyüğe sıralanmış sayılar:");
        foreach (int num in rastgeleSayilar)
        {
            Console.WriteLine(num);
        }
        // 10. 10'dan küçük olanları silme
        Console.WriteLine("10. 10'dan küçük olanları silme");

        List<int> sayilar = new List<int> { 5, 12, 8, 20, 3, 15, 10, 7 };


        for (int i = sayilar.Count - 1; i >= 0; i--)
        {
            if (sayilar[i] < 10)
            {
                sayilar.RemoveAt(i);
            }
        }


        Console.WriteLine("Güncellenmiş liste:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
        // 11. Öğrenci notlarını güncelleme
        Console.WriteLine("11. Öğrenci notlarını güncelleme");
        List<int> notlar = new List<int> { 45, 60, 75, 30, 50 };
        for (int i = 0; i < notlar.Count; i++)
        {
            if (notlar[i] < 50)
            {
                notlar[i] = 50;
            }
        }


        Console.WriteLine("Güncellenmiş notlar:");
        foreach (int not in notlar)
        {
            Console.WriteLine(not);
        }
    }




}