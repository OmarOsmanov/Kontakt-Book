using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            byte saygac = 255;

            KontaktServiceClass kont = new KontaktServiceClass();
            KontaktBookOzellikleri kontsoz = new KontaktBookOzellikleri();

            Console.WriteLine("Kontakt Book Baza proqramina xos gelmissiniz");
            Console.WriteLine("--------------------------------------------");

            do
            {
                Console.WriteLine("Istediyiniz emeliyyati icra ede bilmek ucun muvafiq nomreni bazaya daxil edin:");
                Console.WriteLine();
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("1 --> Bazaya yeni user daxil edin");
                Console.WriteLine("2 --> Bazadan user silmek ucun daxil edin");
                Console.WriteLine("3 --> Bazaya evvelceden daxil edilen user uzerinde deyisiklik edin:");
                Console.WriteLine("4 --> Bazada olan Useri id ye gore axtarin:");
                Console.WriteLine("5 --> Bazada olan Butun userler haqqinda tam melumat alin:");
                Console.WriteLine("0 --> Bazadan cixis etmek ucun daxil edin:");


                if (byte.TryParse(Console.ReadLine(), out saygac))
                {
                    switch (saygac)
                    {
                        case 1:
                            KontaktBookOzellikleri newKontaktOzellikleri = new KontaktBookOzellikleri();

                            newKontaktOzellikleri.ID = kont.FindId();

                            Console.WriteLine();
                            Console.WriteLine("Zehmet olmasa yeni kontaktin Adini daxil edin:");
                            newKontaktOzellikleri.Name = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Soyadini daxil edin:");
                            newKontaktOzellikleri.Surname = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Yasini daxil edin:");
                            newKontaktOzellikleri.Age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Telefon Nomresini daxil edin:");
                            newKontaktOzellikleri.PhoneNumber = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Olkesini daxil edin:");
                            newKontaktOzellikleri.Country = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Yasadigi Seheri daxil edin:");
                            newKontaktOzellikleri.City = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Yasadigi Kuceni daxil edin:");
                            newKontaktOzellikleri.Street = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Evinin Nomresini daxil edin:");
                            newKontaktOzellikleri.HomeNumber = Console.ReadLine();

                            Console.WriteLine("Zehmet olmasa yeni kontaktin Qapi Nomresini daxil edin:");
                            newKontaktOzellikleri.DourNumber = Console.ReadLine();

                            kont.New(newKontaktOzellikleri);

                            break;


                        case 2:
                            Console.WriteLine("Kontaktin id sini daxil et ve hemin idiye gore melumatlari bazadan silin");
                            KontaktBookOzellikleri[] ozellik2 = kont.Read();
                            for (int i = 0; i < ozellik2.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id:{ozellik2[i].ID} | Name:{ozellik2[i].Name} | Surname:{ozellik2[i].Surname} | Age:{ozellik2[i].Age} | Phone number:{ozellik2[i].PhoneNumber} | Country:{ozellik2[i].Country} | City:{ozellik2[i].City} | Street:{ozellik2[i].Street} | HomeNumber:{ozellik2[i].HomeNumber} | DourNumber:{ozellik2[i].DourNumber}");
                            }
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            kont.Dalete(id2);
                            Console.WriteLine("Silme prosessi ugurla basa catdi");
                            break;



                        case 3:
                            Console.WriteLine("Update etmek istediyiniz id ni secin");
                            foreach (var item in kont.Read())
                            {
                                Console.WriteLine($" Id : {item.ID} | Name:{item.Name} | Surname:{item.Surname} | Age:{item.Age} | Phone number:{item.PhoneNumber} | Country:{item.Country} | City:{item.City} | Street:{item.Street} | HomeNumber:{item.HomeNumber} | DourNumber:{item.DourNumber} ");
                            }
                            int booId = Convert.ToInt32(Console.ReadLine());
                            KontaktBookOzellikleri user = kont.Find(booId);
                            Console.WriteLine($"Yeni adi daxil edin : {user.Name}");
                            user.Name = Console.ReadLine();

                            Console.WriteLine($"Yeni soyadi daxil edin : {user.Surname}");
                            user.Surname = Console.ReadLine();

                            Console.WriteLine($"Yeni yasi daxil edin : {user.Age}");
                            user.Age = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Yeni nomreni daxil edin : {user.PhoneNumber}");
                            user.PhoneNumber = Console.ReadLine();

                            Console.WriteLine($"Yeni Olkeni daxil edin  : {user.Country}");
                            user.Country = Console.ReadLine();

                            Console.WriteLine($"Yeni seheri daxil edin : {user.City}");
                            user.City = Console.ReadLine();

                            Console.WriteLine($"Yeni ev nomresini daxil edin : {user.HomeNumber}");
                            user.HomeNumber = Console.ReadLine();

                            Console.WriteLine($"Yeni qapi nomrenisi daxil edin : {user.DourNumber}");
                            user.DourNumber = Console.ReadLine();


                            kont.Update(booId, user);
                            Console.WriteLine("Update ugurludur!");

                            break;



                        case 4:
                            Console.Write("Haqqinda melumat almaq istediyiniz kontaktin id-sini daxil edin:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            KontaktBookOzellikleri Books2 = kont.Find(id);
                            Console.WriteLine($"Id:{Books2.ID} | Name:{Books2.Name} | Surname:{Books2.Surname} | Age:{Books2.Age} | Phone number:{Books2.PhoneNumber} | Country:{Books2.Country} | City:{Books2.City} | Street:{Books2.Street} | HomeNumber:{Books2.HomeNumber} | DourNumber:{Books2.DourNumber}");

                            break;



                        case 5:
                            KontaktBookOzellikleri[] ozellik = kont.Read();
                            for (int i = 0; i < ozellik.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. Id:{ozellik[i].ID} | Name:{ozellik[i].Name} | Surname:{ozellik[i].Surname} | Age:{ozellik[i].Age} | Phone number:{ozellik[i].PhoneNumber} | Country:{ozellik[i].Country} | City:{ozellik[i].City} | Street:{ozellik[i].Street} | HomeNumber:{ozellik[i].HomeNumber} | DourNumber:{ozellik[i].DourNumber}");
                            }

                            break;


                        case 0:
                            Console.WriteLine("Siz Kontakt Book Baza proqramindan cixis etdiniz!");
                            break;

                        default:
                            Console.WriteLine("---");
                            break;
                    }
                }


                else
                {
                    Console.WriteLine("Her hansisa bir xetaya yol verdiniz, ona gorede yeniden baslamali olacaqsiniz!!!");
                    saygac = 255;
                }

            } while (saygac!=0);
        }
    }
}
