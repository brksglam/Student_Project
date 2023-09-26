using System;
using System.Collections.Generic;

namespace AdvancedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Lütfen bir işlem seçin:");
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrenci Listele");
                Console.WriteLine("3. Çıkış");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Öğrenci Adı: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Öğrenci Yaşı: ");
                        int age = int.Parse(Console.ReadLine());
                        Student student = new Student { Name = name, Age = age };
                        students.Add(student);
                        Console.WriteLine("Öğrenci başarıyla eklendi.");
                        break;

                    case "2":
                        Console.WriteLine("Öğrenci Listesi:");
                        foreach (var s in students)
                        {
                            Console.WriteLine($"Adı: {s.Name}, Yaşı: {s.Age}");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Uygulama kapatılıyor.");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçenek, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
