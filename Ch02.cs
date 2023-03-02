using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ch02Function {
    public static void ch2_q1() {
        Console.Write("Please enter the 1st integer : ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.Write("Please enter the 2nd integer : ");
        int num2 = int.Parse(Console.ReadLine()!);
        Console.Write("Please enter the 3rd integer : ");
        int num3 = int.Parse(Console.ReadLine()!);
        Console.WriteLine();

        //solution without if/else
        //int max, min;
        //max = Math.Max(num1, Math.Max(num2,num3));
        //min = Math.Min(num1, Math.Min(num2,num3));
        //Console.WriteLine($"Among the three numbers {num1}, {num2}, {num3}the maximum is " +
        //    $"{max} " +
        //    $"and the minimum is " +
        //    $"{min}.");

        Console.WriteLine($"Among the three numbers {num1}, {num2}, {num3}the maximum is " +
            $"{Math.Max(num1,Math.Max(num2,num3))} " +
            $"and the minimum is " +
            $"{Math.Min(num1,Math.Min(num2,num3))}.");
    }
    public static void ch2_q2() {
        Console.Write("Please enter your Height(cm) : ");
        int height = int.Parse(Console.ReadLine()!);
        char gender;
        try {
            Console.Write("Please enter your gender(Male-M, Female-F) : ");
            gender = char.Parse(Console.ReadLine()!);

            if(gender == 'M' || gender == 'F') {
                if(gender == 'M') {
                    Console.WriteLine($"Your height is {height} cm, the standard weight is {(height - 80) * 0.7} kg");
                }
                else {
                    Console.WriteLine($"Your height is {height} cm, the standard weight is {(height - 70) * 0.6} kg");
                }
            }
            else {
                throw new Exception();
            }

            //advanced solution (conditional operator)
            //double weight;
            //weight = (gender == 'M' || gender == 'F') ? gender == 'M' ? (height-80)*0.7 : (height-70)*0.6 : throw new Exception();
            //Console.WriteLine($"Your height is {height} cm, the standard weight is {weight} kg");
        }

        catch(Exception) {
            Console.WriteLine("Gender input error, cannot be calculated!(Please enter M or F)");
        }
    }
    public static void ch2_q3() {
        for(int i = 0; i < 5; i++) {
            for(int j = 0; j < i + 1; j++) {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for(int i = 0; i < 5; i++) {
            for(int j = 0; j < i; j++) {
                Console.Write(' ');
            }
            for(int j = 0; j < 5 - i; j++) {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
    public static void ch2_q4() {
        int i = 1, j;
        do {
            j = 1;
            do {
                Console.Write($"{i}x{j}={i * j++}\t");
            } while(j < 10);
            i++;
            Console.WriteLine();
        } while(i < 10);
    }

    public static void ch2_q5() {
        int start, final;

        for(; ; ) {
            try {
                Console.Write("Please enter the starting value: ");
                start = int.Parse(Console.ReadLine()!);
                break;
            }
            catch(System.FormatException) {
                Console.WriteLine("Wrong format. Please enter an integer.");
            }
        }

        for(; ; ) {
            try {
                Console.Write("Please enter the final value: ");
                final = int.Parse(Console.ReadLine()!);
                if(final <= start) {
                    Console.WriteLine("Final value should greater then starting value !!!");
                }
                else {
                    break;
                }
            }
            catch(System.FormatException) {
                Console.WriteLine("Wrong format. Please enter an integer.");
            }
        }


        for(; ; ) {
            try {
                char func;
                int ans = 0;
                Console.Write("\nPlease enter A, B, C or D to choose the function." +
                "(A- sum, B- odd sum, C- even sum, D- exit): ");
                func = char.ToUpper(char.Parse(Console.ReadLine()!));
                switch(func) {
                    case 'A':
                    for(int i = start; i <= final; i++) {
                        ans += i;
                    }
                    Console.WriteLine($"The sum from {start} to {final} is {ans}.");
                    break;
                    case 'B':
                    for(int i = start; i <= final; i++) {
                        if(i % 2 != 0) {
                            ans += i;
                        }
                        else {
                            continue;
                        }
                    }
                    Console.WriteLine($"The odd sum from {start} to {final} is {ans}.");
                    break;
                    case 'C':
                    for(int i = start; i <= final; i++) {
                        if(i % 2 == 0) {
                            ans += i;
                        }
                        else {
                            continue;
                        }
                    }
                    Console.WriteLine($"The even sum from {start} to {final} is {ans}.");
                    break;
                    case 'D':
                    Console.Write("Press Enter to exit...");
                    Console.Read();
                    return;
                    default:
                    throw new System.FormatException();
                }
            }
            catch(System.FormatException) {
                Console.WriteLine("Please enter A, B, C or D!!");
            }
        }
    }
}