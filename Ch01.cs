using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ch01Function {
    public static void ch1_q1() {
        Console.WriteLine("Contacts");
        Console.WriteLine("Name\tTelephone\tNationality");
        Console.WriteLine("Jack\t02-12345678\tTaiwan");
        Console.WriteLine("Ken\t04-12345678\tAmerica");
        Console.WriteLine("Marry\t07-1234567\tUnited Kingdom");
    }

    public static void ch1_q2() {
        string name, color;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine()!;
        Console.Write($"Hello, {name}. Please enter your favorite color: ");
        color = Console.ReadLine()!;
        Console.WriteLine($"{name}, your favorite color is {color}.");
        Console.Write("Press Enter to exit...");
        Console.Read();
    }

    public static void ch1_q3() {
        int r;
        Console.Write("Please enter the circle radius: ");
        r = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"radius: {r} cm; area: {Math.Pow(r,2) * Math.PI:F2} square centimeter");
        Console.Write("Press enter to exit...");
        Console.Read();
    }
    public static void ch1_q4() {
        Console.Write("Please enter your tuition: ");
        double tuition;
        tuition = int.Parse(Console.ReadLine()!);
        //Console.WriteLine("Your tuition is : " + tuition.ToString("#,#.000"));
        Console.WriteLine("Your tuition is : " + "{0:n}",tuition);
    }
    public static void ch1_q5() {
        Console.Write("Please enter 1st Introduction to Computers score : ");
        double score1 = double.Parse(Console.ReadLine()!);
        Console.Write("Please enter 2nd Introduction to Computers score : ");
        double score2 = double.Parse(Console.ReadLine()!);
        Console.Write("Please enter 3rd Introduction to Computers score : ");
        double score3 = double.Parse(Console.ReadLine()!);
        string title = "Score1\tScore2\tScore3\tTotal\tAverage\t";
        Console.WriteLine(title);
        for(int i = 0; i < 40; i++) {
            Console.Write('=');
        }
        Console.WriteLine($"\n{score1}\t{score2}\t{score3}\t{score1 + score2 + score3}\t{((score1 + score2 + score3) / 3).ToString("##.00")}");
    }
}
