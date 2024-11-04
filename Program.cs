namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sayi=false;
            while (!sayi)
            {
                try
                {
                    Console.WriteLine(" Lütfen sayı giriniz:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int sonuc = number * number;
                    Console.WriteLine(sonuc);
                    sayi = true;
                }
                catch
                {
                    Console.WriteLine("Hatalı işlem yaptınız");
                }
                finally 
                {
                    Console.WriteLine("İşlem tamamlandı.");
                }
            }

        }
    }
}
