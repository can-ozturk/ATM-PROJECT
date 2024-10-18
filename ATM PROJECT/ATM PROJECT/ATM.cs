using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_PROJECT
{
    internal class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
            int bakiye = 1000;
        RESET:
            try
            {

                char metin, tekrar;
                int paracek;
            tekrar:

                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Bakiyeyi Görüntüle");
                Console.WriteLine("2. Para Çek");
                Console.WriteLine("3. Para Yatır");
                Console.WriteLine("4. Çıkış Yap");
                Console.WriteLine("----------------------------");
                Console.Write("Lütfen Belirtilen Değerleri Giriniz: ");
                metin = char.Parse(Console.ReadLine());
                switch (metin)
                {
                    case '1':
                        Console.WriteLine("Bakiye: " + bakiye.ToString());
                        Console.Write("Geri dönmek için 'E/e' çıkış yapmak için 'H/h' harfine basınız: ");
                    varsayılan1:
                        tekrar = char.Parse(Console.ReadLine());
                        if (tekrar == 'e' || tekrar == 'E')
                        {

                            Console.Clear();
                            Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
                            goto tekrar;

                        }
                        else if (tekrar == 'h' || tekrar == 'H')
                        {
                            Console.WriteLine("Güle Güle !");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Yanlış tuşlama tekrar tuşlayın: ");
                            goto varsayılan1;
                        }
                        break;
                    case '2':
                        Console.Write("Kaç para çekmek istiyorsun: ");
                        paracek = int.Parse(Console.ReadLine());
                        if (bakiye >= paracek)
                        {
                            bakiye = bakiye - paracek;
                            Console.WriteLine("Mevcut Bakiye: " + bakiye.ToString());
                            Console.Write("Geri dönmek için 'E/e' çıkış yapmak için 'H/h' harfine basınız: ");
                        varsayılan2:
                            tekrar = char.Parse(Console.ReadLine());
                            if (tekrar == 'e' || tekrar == 'E')
                            {

                                Console.Clear();
                                Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
                                goto tekrar;

                            }
                            else if (tekrar == 'h' || tekrar == 'H')
                            {
                                Console.WriteLine("Güle Güle !");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Yanlış tuşlama tekrar tuşlayın: ");
                                goto varsayılan2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bakiye Yetersiz");
                            Console.Write("Geri dönmek için 'E/e' çıkış yapmak için 'H/h' harfine basınız: ");
                        varsayılan12:
                            tekrar = char.Parse(Console.ReadLine());
                            if (tekrar == 'e' || tekrar == 'E')
                            {
                                Console.Clear();
                                Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
                                goto tekrar;

                            }
                            else if (tekrar == 'h' || tekrar == 'H')
                            {
                                Console.WriteLine("Güle Güle !");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Yanlış tuşlama tekrar tuşlayın: ");
                                goto varsayılan12;
                            }
                            break;
                        }

                        break;

                    case '3':
                        Console.Write("Kaç para yatırmak istiyorsun: ");
                        paracek = int.Parse(Console.ReadLine());

                        bakiye = bakiye + paracek;
                        Console.WriteLine("Mevcut Bakiye: " + bakiye.ToString());

                        Console.Write("Geri dönmek için 'E/e' çıkış yapmak için 'H/h' harfine basınız: ");
                    varsayılan3:
                        tekrar = char.Parse(Console.ReadLine());
                        if (tekrar == 'e' || tekrar == 'E')
                        {
                            Console.Clear();
                            Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
                            goto tekrar;

                        }
                        else if (tekrar == 'h' || tekrar == 'H')
                        {
                            Console.WriteLine("Güle Güle !");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Yanlış tuşlama tekrar tuşlayın: ");
                            goto varsayılan3;
                        }

                        break;


                    case '4':
                        Console.Write("Çıkış yapmak için bir tuşa basınız: ");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("----------------------------");
                        Console.Write("Lütfen Belirtilen Tuşlamayı Yapınız \nGeri dönmek için 'E/e' çıkış yapmak için 'H/h' harfine basınız: ");
                    varsayılan4:
                        tekrar = char.Parse(Console.ReadLine());
                        if (tekrar == 'e' || tekrar == 'E')
                        {

                            Console.Clear();
                            Console.WriteLine("-------------ATM PROGRAMINA HOŞGELDİNİZ-------------");
                            goto tekrar;

                        }
                        else if (tekrar == 'h' || tekrar == 'H')
                        {
                            Console.WriteLine("Güle Güle !");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Yanlış tuşlama tekrar tuşlayın: ");
                            goto varsayılan4;
                        }
                        break;
                }


            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Bir sorun oluştu ! ");
                Console.WriteLine("------------");
                Console.WriteLine("Programı yeniden başlatıldı");
                Console.WriteLine("------------");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("-------------ATM PROGRAMINA TEKRARDAN HOŞGELDİNİZ-------------");
                goto RESET;


            }
        }
    }
}
