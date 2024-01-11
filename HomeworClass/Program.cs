using System;

namespace HomeworClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Fullname, BirthDate, GroupNo, Point xüsusiyyətlərinə və ShowInfo metoduna sahib Student class yaradırsınız.
            // FullName və Point dəyəri təyin olunmamış student obyekti yaradıla bilməz.
            // Proqram açıldıqda bizdən tələbə yaratmaq üçün datalar daxil etməyimizi istyir,
            // daxil edib tələbə obyektini yaradırıq və Shoüİnfo metodu ilə içindəki məlumatlara baxırıq
            #region task1

            //Console.WriteLine("Adini daxil edin");
            //string name = Console.ReadLine();

            //Console.WriteLine("Dogum tarixini qeyd edin");
            //string dateStr = Console.ReadLine();
            //DateTime date = Convert.ToDateTime(dateStr);

            //Console.WriteLine("GroupNo daxil edin");
            //string groupNo = Console.ReadLine();

            //Console.WriteLine("Pointini daxil edin");

            //string pointStr;
            //int point = 0;
            //bool check;
            //do
            //{
            //    check = false;
            //    pointStr = Console.ReadLine();
            //    try
            //    {
            //        point = Convert.ToInt32(pointStr);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Xeta bas verdi");
            //        check = true;
            //    }
            //} while (check);


            //Student stu1 = new Student(name, date, groupNo, point);
            //stu1.ShowInfo();
            #endregion

            //2 Name və Price dəyərləri olan Product classı yaradırsınız. Name dəyəri daxil edilmədən product yaradıla bilməz,
            //Price isə default 10 olur. Proqram işə düşdükdə bizdən neçə ədəd product yaradacağımızı soruşur və
            //daha sonra o sayda product dataları yaradırıq.
            //Bunları bir array içərisində saxlayırsınız və daxil etdiyimiz sayda product datalarını daxil etdikdən sonra o
            //product arrayındəki bütün productların qiymətlərini ortalaması, ən bahalı productın adı və ən ucuz productın adı
            //console-da göstərilir
            #region task2



            //Console.WriteLine("Productun uzunluqunu qeyd edin");
            //string lenhtStr = Console.ReadLine();
            //int length = int.Parse(lenhtStr);


            //Console.WriteLine("Qiymetini daxil edin");
            //string productPriceStr = Console.ReadLine();
            //int productPrice = int.Parse(productPriceStr);

            //string nn = Console.ReadLine();

            //Product[] products = new Product[length];
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.Write($"product daxil edin #{i + 1}: ");
            //    products[i].Name = Console.ReadLine();
            //    products[i].Price = productPrice;

            //}


            //for (int i = 0;i < products.Length; i++)
            //{
            //    Console.WriteLine($"{products[i].Name}-{products[i]}");
            //}
            #endregion





        }
    }
}
