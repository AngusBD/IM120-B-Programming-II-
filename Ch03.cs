using System.Diagnostics;

public static class ch03Function {
    public static void ch03_q1() {
        string[] name = new string[] { "錢一文","李四維","周六合" };
        int[,] score = new int[,] { { 89,73,90 },{ 88,79,85 },{ 79,83,76 },{ 70,89,82 },{ 93,67,82 } };
        int[] finalScore = new int[] { 0,0,0 };
        for(int i = 0; i < 3; i++) {
            for(int j = 0; j < 5; j++) {
                finalScore[i] += score[j,i];
            }
        }

        Array.Sort(finalScore,name);
        Array.Reverse(name);
        Array.Reverse(finalScore);
        for(int i = 0; i < 3; i++) {
            Console.WriteLine($"第 {i + 1} 名 : {name[i]} {finalScore[i]}");
        }
    }
    public static void ch03_q2() {
        int[] numAry = new int[] { 23,12,34,12,45,12,23 };
        Console.Write("Array initial value : ");
        
        //simple solution
        foreach(int i in numAry) {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        Array.Sort(numAry);
        int[] ansAry = new int[4];
        int temp = 0;
        for(int i = 0, j = 0; i < numAry.Length; i++) {
            if(temp == numAry[i]) {
                continue;
            }
            else {
                ansAry[j] = numAry[i];
                temp = numAry[i];
                j++;
            }
        }
        Console.WriteLine(String.Join(' ',ansAry));


        //advanced solution
        //Console.WriteLine(String.Join(", ",numAry));
        //Console.Write("After removing duplicate values : ");
        //HashSet<int> numSet = numAry.ToHashSet<int>();
        //Console.WriteLine(String.Join(", ",numSet));
    }
    public static void ch03_q3() {
        string numStr = "12/38/7/94/216/51/83";
        string[] splAry = numStr.Split('/');
        Console.WriteLine(String.Join(", ",splAry));
        int[] ansAry = new int[splAry.Length];
        for(int i = 0; i < splAry.Length; i++) {
            ansAry[i] = Int32.Parse(splAry[i]);
        }
        Array.Sort(ansAry);
        Console.WriteLine($"Minimum value : {ansAry[0]}");
        Console.WriteLine($"Maximum value : {ansAry[ansAry.Length-1]}");
    }
    public static void ch03_q4() {
        string[] userName = { "cat","dog","cow","horse","lion","tiger" };
        string[] password = { "good123","best168","happy","first111","Lucky777","OKKO" };
        Console.Write("Please enter user name : ");
        string checkUserName = Console.ReadLine()!;
        int pos = Array.IndexOf(userName,checkUserName);
        if(pos == -1) {
            Console.WriteLine("Sorry the user name does not exist!");
            return;
        }
        else {
            Console.Write("Please enter the password : ");
        }
        string checkPassword = Console.ReadLine()!;
        if(checkPassword == password[pos]) {
            Console.WriteLine($"Welcome \"{userName[pos]}\" !");
        }
        else {
            Console.WriteLine("Sorry password incorrect!");
        }
    }
    public static void ch03_q5() {
        string[] title = { "座號","姓名","計概","程設","動畫","總分" };
        int[] number = { 1,2,3,4,5 };
        string[] name = { "Jack","Mary","Tom","Grace","Alice" };
        int[,] score = { { 80,75,60 },{ 65,67,62 },{ 100,93,91 },{ 98,25,50 },{ 83,82,87 } };
        int[] total = new int[score.GetLength(0)];

        for(int i = 0; i < score.GetLength(0); i++) {
            for(int j = 0; j < score.GetLength(1); j++) {
                total[i] += score[i,j];    
            }
        }

        int[] originalTotal = new int[total.Length];
        Array.Copy(total, originalTotal, total.Length);
        Array.Sort(total,number);
        Array.Reverse(number);
        Array.Copy(originalTotal, total, total.Length);
        Array.Sort(total,name);
        Array.Reverse(name);
        Array.Reverse(total);

        Console.WriteLine(String.Join("\t",title));
        for(int i = 0, j = 0; i < number.Length;i++,j=0) {
            Console.WriteLine($"{number[i]}\t{name[i]}\t{score[number[i] - 1,j]}\t{score[number[i] - 1,++j]}\t{score[number[i] - 1,++j]}\t{total[i]}");
        }
    }
}