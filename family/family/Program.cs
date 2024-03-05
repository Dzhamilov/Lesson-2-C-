using family.Models;
using family.Services;
using System;
using System.Runtime.Intrinsics.X86;

namespace family
{
    /*Доработайте приложение генеалогического дерева таким образом 
     * чтобы программа выводила на экран близких родственников (жену/мужа). 
     * Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.*/

    class Program
    {
        static void Main(string[] args)
        {
            var grandad = new FamilyMember()
            { Name = "Амир", SurName = "Сафаров", BrithData = new DateTime(1969, 12, 15), gender = Gender.Муж };
            var grandma = new FamilyMember()
            { Name = "Сафия", SurName = "Сафарова", BrithData = new DateTime(1971, 10, 20), gender = Gender.Жен };
            grandad.Spouse = grandma;
            grandma.Spouse = grandad;

            var father2 = new FamilyMember()
            { Name = "Антон", SurName = "Петров", BrithData = new DateTime(1978, 01, 10), gender = Gender.Муж};
            var mother2 = new FamilyMember()
            { Name = "Ольга", SurName = "Петрова", BrithData = new DateTime(1982, 03, 08), gender = Gender.Жен};
            father2.Spouse = mother2;
            mother2.Spouse = father2;

            var father = new FamilyMember()
            {Name = "Сергей", SurName = "Сафаров", BrithData = new DateTime(1995,02,15), gender = Gender.Муж, Mother= grandma, Father = grandad };
            var mother = new FamilyMember()
            { Name = "Наталия", SurName = "Сафарова", BrithData = new DateTime(1999, 08, 03), gender = Gender.Жен, Father = father2, Mother = mother2};
            father.Spouse = mother;
            mother.Spouse = father;

            var son = new FamilyMember()
            { Name = "Салим", SurName = "Амиров", BrithData = new DateTime(2021, 06, 21), gender = Gender.Муж, Mother = mother, Father = father };
            var daughter = new FamilyMember()
            { Name = "Саида", SurName = "Амирова", BrithData = new DateTime(2023, 09, 12), gender = Gender.Жен, Mother = mother, Father = father };

            var service = new FMService();
            service.AddMember(grandad,grandma,father2, mother2,father,mother,son,daughter);

            foreach (var member in service.GetGrandFather(son)) 
            {
                Console.Write($"Дудушка для {son} является - {member}\n");
            }

            Console.WriteLine("****");

            foreach (var member in service.GetGrandMothers(daughter))
            {
                Console.Write($"Бабушка для {daughter} является - {member}\n");
                
            }

            Console.WriteLine("****");

            Console.WriteLine("Самым старшим является - " + service.OldFamilyMember());

            Console.WriteLine("****");

            Console.WriteLine($"мужем для {grandma.Name} {grandma.SurName} является {service.FindCouple(grandma)}");
            Console.WriteLine($"мужем для {mother2.Name} {mother2.SurName} является {service.FindCouple(mother2)}");
            Console.WriteLine($"женой для {father.Name} {father.SurName} является {service.FindCouple(father)}");



        }
    }
}
