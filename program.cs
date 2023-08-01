using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string giris, adım;
            int sayi1 = 0,sayi2, toplam = 0;;

            Console.WriteLine("1.Soru:(1)");
            Console.WriteLine("2.Soru:(2)");
            Console.WriteLine("3.Soru:(3)");
            Console.WriteLine("4.Soru:(4)");
            Console.WriteLine("5.Soru:(5)");
            Console.Write("Sorunuz Seçiniz Lütfen:");
            giris = Console.ReadLine();


            //soru 1

            if (giris == "1")
            {

                Console.WriteLine("Kullanıcıdan iki adet sayı alalım. İlk sayı başlangıç değeri olsun." +
                    " İkinci sayı ise bitiş değeri olsun kullanıcı konsol üzerinden sayıları girdiğinde" +
                    " (örneğin: 5 'den 100'e kadar olsun). For döngüsü kullanılacak. Eğer kullanıcının girdiği" +
                    " sayı tek sayı ise girilen değerler arasında konsol çıktısı olarak sadece tek sayılar ekrana" +
                    " yazılsın eğer girilen sayı çift ise konsolda sadece çift sayılar yazsın.?");


                Console.Write("1.Sayiyi Giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());
                Console.Write("2.Sayiyi Giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());

                if (sayi1 % 2 == 0 || sayi1 % 2 == 1)
                {
                    for (int i = sayi1; i < sayi2; i += 2)
                    {
                        Console.WriteLine(i);
                    }

                }


            }



   

            //soru 2

            else if (giris == "2")
            {

                Console.WriteLine("For Döngüsü kullanarak Kullanıcıdan aldığı 10 adet sayıyı toplayarak" +
                    " ekranda yazan bir konsol uygulaması oluştur.?");

                Console.Write("1.Sayiyi Giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());
                Console.Write("2.Sayiyi Giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());
                if (sayi1 < sayi2)
                {

                    for (int i = sayi1; i <= sayi2; i++)
                    {

                        toplam = toplam + i;
                        Console.WriteLine(i + ". Adımda ki toplama = " + toplam);

                    }
                }
                else
                {
                    for (int i = sayi1; i >= sayi2; i--)
                    {

                        toplam = toplam + i;
                        Console.WriteLine(i + ". Adımda ki toplama = " + toplam);

                    }
                }


            }




           

            //soru 3

            else if (giris == "3")
            {
                Console.WriteLine("For Döngüsü kullanılarak Kullanıcıdan 10 adet isim alarak başına " +
                    "numaraların da ekleyerek ekranda yazdıran bir konsol uygulaması oluştur" +
                    " ör: 1. Enes Aktaş 2.Ahmet Kırmızgül 3. Onur Mert gibi.?");


                for (int i = 0; i <= 10; i++)
                {
                    Console.Write("Adınız Giriniz: ");
                    adım = Console.ReadLine();
                    Console.WriteLine(i + "." + adım);
                }



            }


            

            //soru 4

            else if (giris == "4") 
            {
                Console.WriteLine("1-100 arası 3 e bölünebilen sayıları ekrana yazdıran örnek: (3,5,7,9...99).?");


                if (sayi1 % 3 == 0)
                {
                    for (int i = 1; i <= 100; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }


          

            //soru 5

            else if (giris == "5")
            {
                Console.WriteLine("Kullanıcıdan başlangıç ve bitiş değeri alıncak ve konsol çıktısı olarak " +
                    "sadece 5'e tam bölünebilen sayılar ekrana yazdırılacak.?");


                Console.Write("1.Sayiyi Giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());
                Console.Write("2.Sayiyi Giriniz: ");
                sayi2 = int.Parse(Console.ReadLine());


                if (sayi1 < sayi2 && sayi1 % 5 == 0)
                {
                    for (int i = sayi1; i <= sayi2; i += 5)
                    {
                        Console.WriteLine(i);

                    }
                }
                else
                {
                    for (int i = sayi1; i >= sayi2; i -= 5)
                    {
                        Console.WriteLine(i);

                    }
                }

            }

            else
            {
                Console.WriteLine("Yanlış Giriş Yaptınız!");
            }

            Console.ReadKey();
        }
    }

}