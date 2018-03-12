using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            // add, remove,clear,count
            List<Student> db = new List<Student>();
            var count = 0;

            void Instructions()
            {

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Melumat daxil et"); // Create
                Console.WriteLine("2. Melumatlari goster"); // Read
                Console.WriteLine("3. Melumati yenile"); // Update
                Console.WriteLine("4. Melumati sil"); // Delete
                Console.WriteLine("-----------------------------------");
                Console.Write("Istediyiniz emrin nomresini daxil edin: ");
                var emrNomresi = Convert.ToInt32(Console.ReadLine());


                switch (emrNomresi)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Clear();
                        Create();

                        break;

                    case 2:
                        Console.WriteLine();
                        Console.Clear();
                        Read();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.Clear();
                        Update();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.Clear();
                        Delete();
                        break;

                    default:
                        Console.WriteLine("Sehv komanda secmisiniz");
                        Console.WriteLine();
                        Console.Clear();
                        Instructions();
                        break;

                }
            }
            void Create()
            {

                Console.WriteLine("Ad daxil et");
                var ad = Console.ReadLine();
                Console.WriteLine("Soyad daxil et");
                var soyad = Console.ReadLine();
                Console.WriteLine("Yas daxil et");
                var yas = Convert.ToInt32(Console.ReadLine());
                count++;
                var Telebe = new Student(ad, soyad, yas, count);
                db.Add(Telebe);
                Console.WriteLine();
                Console.Clear();
                Instructions();

            }

            void Read()
            {              
                foreach (var item in db)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age);
                }
                
                Instructions();
            }

            void Update()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Deyismek istediyiniz melumatin nomresini daxil edin: ");
                foreach (var item in db)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age);
                }
                var emrNomresi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} Melumatinin evezine yazmaq istediyiniz melumati daxil edin: ", db[emrNomresi - 1].Name);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Ad daxil et");
                var ad = Console.ReadLine();
                Console.WriteLine("Soyad daxil et");
                var soyad = Console.ReadLine();
                Console.WriteLine("Yas daxil et");
                var yas = Convert.ToInt32(Console.ReadLine());
                var Telebe = new Student(ad, soyad, yas, emrNomresi);
                db[emrNomresi - 1] = Telebe;
                Console.WriteLine();
                Console.Clear();
                Instructions();
            }

            void Delete()
            {
                Console.WriteLine("-----------------------------------");
                foreach (var item in db)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname + " " + item.Age);
                }
                Console.Write("Silmek istediyiniz melumatin nomresini daxil edin: ");
                var emrNomresi = Convert.ToInt32(Console.ReadLine());
                db.Remove(db[emrNomresi - 1]);
                Console.WriteLine();
                Console.Clear();
                Instructions();
            }
            Instructions();

        }
      
    }
}
