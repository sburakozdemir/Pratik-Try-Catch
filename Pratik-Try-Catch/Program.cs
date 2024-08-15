using System;

class Program
{
    static void Main()
    {
        // Kullanıcı çıkış yapmak isteyene kadar döngüyü sürdür
        while (true)
        {
            try
            {
                // Kullanıcıdan giriş iste
                Console.Write("Bir sayı giriniz (Çıkış için 'q' yazın): ");
                string input = Console.ReadLine();

                // Kullanıcı çıkış yapmak istiyorsa döngüyü sonlandır
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Program sonlandırılıyor...");
                    break;
                }

                // Kullanıcı girişini tam sayıya çevir
                int sayi = Convert.ToInt32(input);

                // Sayının karesini hesapla
                double kare = Math.Pow(sayi, 2);

                // Sonucu ekrana yazdır
                Console.WriteLine($"{sayi} sayısının karesi: {kare}");
            }
            catch (FormatException)
            {
                // Kullanıcı sayı dışında bir şey girerse bu hatayı yakala
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
            catch (OverflowException)
            {
                // Girilen sayı int veri tipinin sınırları dışındaysa bu hatayı yakala
                Console.WriteLine("Girilen sayı çok büyük veya çok küçük!");
            }
            catch (Exception e)
            {
                // Öngörülemeyen diğer hataları yakala
                Console.WriteLine($"Beklenmeyen bir hata oluştu: {e.Message}");
            }

            // Her girişten sonra okunabilirlik için boş bir satır bırak
            Console.WriteLine();
        }
    }
}