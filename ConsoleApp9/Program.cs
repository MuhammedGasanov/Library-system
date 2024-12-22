using System;

namespace KitabxanaSistemi
{
    class Program
    {
        static string[] elverishliKitablar = { "Harry Potter", "Sefiller", "Tom Hesk", "Balaca Şahzadə" };
        static string[] alinanKitablar = new string[10];
        static int alinanKitabSay = 0;

        static void MenuGoster()
        {
            Console.WriteLine("Etmek istediyiniz prosesi secin");
            Console.WriteLine("1. Kitab Almaq");
            Console.WriteLine("2. Kitabı Qaytarmaq");
            Console.WriteLine("3. Oxumaq üçün Kitab Götürmek");
            Console.WriteLine("4. Cıxıs");
            Console.Write("Seçiminizi daxil edin (1-4): ");
        }

        static void ElverishliKitablariGoster()
        {
            Console.WriteLine("\nMövcud Kitablar:");
            for (int i = 0; i < elverishliKitablar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {elverishliKitablar[i]}");
            }
        }

        static void KitabAl()
        {
            ElverishliKitablariGoster();
            Console.Write("Almaq istədiyiniz kitabı seçin (1-4): ");
            int secim = int.Parse(Console.ReadLine());

            if (secim >= 1 && secim <= elverishliKitablar.Length)
            {
                string secilmisKitab = elverishliKitablar[secim - 1];
                bool artıqAlınmışdır = false;

                for (int i = 0; i < alinanKitabSay; i++)
                {
                    if (alinanKitablar[i] == secilmisKitab)
                    {
                        artıqAlınmışdır = true;
                        break;
                    }
                }

                if (!artıqAlınmışdır)
                {
                    alinanKitablar[alinanKitabSay] = secilmisKitab;
                    alinanKitabSay++;
                    Console.WriteLine($"'{secilmisKitab}' kitabını aldınız.");
                }
                else
                {
                    Console.WriteLine($"'{secilmisKitab}' kitabını artıq almısınız.");
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim. Yenidən cəhd edin.");
            }
        }

        static void KitabiQaytar()
        {
            if (alinanKitabSay > 0)
            {
                Console.WriteLine("\nAldığınız Kitablar:");
                for (int i = 0; i < alinanKitabSay; i++)
                {
                    Console.WriteLine($"{i + 1}. {alinanKitablar[i]}");
                }
                Console.Write("Qaytarmaq istədiyiniz kitabı seçin (1-N): ");
                int secim = int.Parse(Console.ReadLine());

                if (secim >= 1 && secim <= alinanKitabSay)
                {
                    string qaytarilanKitab = alinanKitablar[secim - 1];
                    for (int i = secim - 1; i < alinanKitabSay - 1; i++)
                    {
                        alinanKitablar[i] = alinanKitablar[i + 1];
                    }
                    alinanKitablar[alinanKitabSay - 1] = null;
                    alinanKitabSay--;
                    Console.WriteLine($"'{qaytarilanKitab}' kitabını qaytardınız.");
                }
                else
                {
                    Console.WriteLine("Yanlıs secm. Yenidən cəhd edin.");
                }
            }
            else
            {
                Console.WriteLine("Qaytarmaq ücün kitabınız yoxdur.");
            }
        }

        static void OxumaqÜçünKitabGotur()
        {
            if (alinanKitabSay > 0)
            {
                Console.WriteLine("\nAldığınız Kitablar:");
                for (int i = 0; i < alinanKitabSay; i++)
                {
                    Console.WriteLine($"{i + 1}. {alinanKitablar[i]}");
                }
                Console.Write("Oxumaq üçün kitabı seçin (1-N): ");
                int secim = int.Parse(Console.ReadLine());

                if (secim >= 1 && secim <= alinanKitabSay)
                {
                    Console.WriteLine($"'{alinanKitablar[secim - 1]}' kitabını oxuyursunuz. Yaxsi oxumaqlar!");
                }
                else
                {
                    Console.WriteLine("Yanlıs secim. Yenidən cəhd edin.");
                }
            }
            else
            {
                Console.WriteLine("Oxumaq ücün kitabınız yoxdur. Əvvəlcə kitab alın.");
            }
        }

        static void Main(string[] args)
        {
            int secim;

            do
            {
                MenuGoster();
                secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        KitabAl();
                        break;
                    case 2:
                        KitabiQaytar();
                        break;
                    case 3:
                        OxumaqÜçünKitabGotur();
                        break;
                    case 4:
                        Console.WriteLine("Kitabxana sistemindən çıxılır. Sağ olun!");
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim. Yenidən cəhd edin.");
                        break;
                }
            } while (secim != 4);
        }
    }
}

